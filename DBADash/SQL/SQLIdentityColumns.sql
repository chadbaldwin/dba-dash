﻿SET NOCOUNT ON 
SET TRAN ISOLATION LEVEL READ UNCOMMITTED

DECLARE @DBName SYSNAME
DECLARE @IdentSQL NVARCHAR(MAX)
DECLARE @SQL NVARCHAR(MAX)
SET @IdentSQL = N'
/* Using a temp table which can help when the database has a large number of tables */
SELECT IC.object_id,
	IC.name,
	IC.last_value,
	IC.system_type_id,
	IC.user_type_id,
	IC.max_length,
	IC.increment_value,
	IC.seed_value
INTO #IC
FROM  sys.identity_columns IC
OPTION(RECOMPILE)

SELECT PS.object_id,
		SUM(PS.row_count) row_count
INTO #ICRowCount
FROM sys.dm_db_partition_stats PS 
WHERE PS.index_id < 2 -- HEAP/CLUSTERED
AND EXISTS(SELECT 1 
			FROM #IC T 
			WHERE T.object_id = PS.object_id
			)
GROUP BY PS.object_id
OPTION(RECOMPILE)

SELECT DB_ID() AS database_id,
	IC.object_id,
	T.name AS object_name,
	IC.name AS column_name,
	CAST(IC.last_value AS BIGINT) AS last_value,
	RC.row_count,
	IC.system_type_id,
	IC.user_type_id,
	IC.max_length,
	CAST(IC.increment_value AS BIGINT) AS increment_value,
	CAST(IC.seed_value AS BIGINT) AS seed_value,
	S.name AS schema_name
FROM #IC IC
INNER JOIN sys.tables T ON IC.object_id = T.object_id
INNER JOIN sys.schemas S ON T.schema_id = S.schema_id
OUTER APPLY(SELECT	CASE IC.max_length
						WHEN 1 THEN POWER(2.,IC.max_length*8) 
							ELSE POWER(2.,IC.max_length*8-1)-1 
					END AS max_ident,
					POWER(2.,IC.max_length*8) AS max_rows,
					CAST(IC.last_value AS BIGINT) as last_value_big
			) calc
LEFT JOIN #ICRowCount RC ON RC.object_id = IC.object_id
WHERE (
	/* last_value is more than threshold percent of the max identity value */
	calc.last_value_big / CAST(calc.max_ident AS FLOAT) * 100 > @IdentityCollectionThreshold 
	/* Table row count is more than the threshold percent of the max number of rows (taking negative values into account)  
	   This is useful if identity was started with a negative number or if the identity was reseeded later with a negative number
	*/
	OR RC.row_count  / CAST(calc.max_rows AS FLOAT) * 100 > @IdentityCollectionThreshold 
	)
AND IC.max_length < 9 /* Exclude decimal types that would be larger than BIGINT and break calculations */
OPTION(RECOMPILE);'

CREATE TABLE #ident(
    database_id SMALLINT NOT NULL,
    object_id INT NOT NULL,
    object_name NVARCHAR(128)  NULL,
    column_name NVARCHAR(128) NULL,
    last_value BIGINT NULL,
    row_count BIGINT NULL,
    system_type_id TINYINT NOT NULL,
    user_type_id INT NOT NULL,
    max_length SMALLINT NOT NULL,
    increment_value BIGINT NULL,
    seed_value BIGINT NULL,
	schema_name NVARCHAR(128) NULL
);


DECLARE DBs CURSOR FAST_FORWARD READ_ONLY LOCAL FOR
			SELECT D.name
			FROM sys.databases D
			WHERE state = 0
			AND HAS_DBACCESS(D.name) = 1
			AND D.is_in_standby = 0
			AND D.database_id <> 2
			AND DATABASEPROPERTYEX(D.name, 'Updateability') = 'READ_WRITE';

OPEN DBs;

WHILE 1=1
BEGIN
	FETCH NEXT FROM DBs INTO @DBName
	IF @@FETCH_STATUS<>0
		BREAK
	IF HAS_DBACCESS(@DBName)=1
	BEGIN
		SET @SQL =  N'USE ' + QUOTENAME(@DBName)  + '
		' + @IdentSQL

		INSERT INTO #ident
		(
		    database_id,
		    object_id,
		    object_name,
		    column_name,
		    last_value,
		    row_count,
		    system_type_id,
		    user_type_id,
		    max_length,
		    increment_value,
		    seed_value,
			schema_name
		)
		EXEC sp_executesql @SQL,N'@IdentityCollectionThreshold INT',@IdentityCollectionThreshold
	END
END
CLOSE DBs 
DEALLOCATE DBs

SELECT database_id,
       object_id,
       object_name,
       column_name,
       last_value,
       row_count,
       system_type_id,
       user_type_id,
       max_length,
       increment_value,
       seed_value,
	   schema_name
FROM #ident

DROP TABLE #ident