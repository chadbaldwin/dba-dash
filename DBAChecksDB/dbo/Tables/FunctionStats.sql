﻿CREATE TABLE [dbo].[FunctionStats] (
    [InstanceID]           INT           NOT NULL,
    [FunctionID]           INT           NOT NULL,
    [SnapshotDate]         DATETIME2 (3) NOT NULL,
    [PeriodTime]           BIGINT        NOT NULL,
    [total_worker_time]    BIGINT        NOT NULL,
    [total_elapsed_time]   BIGINT        NOT NULL,
    [total_logical_reads]  BIGINT        NOT NULL,
    [total_logical_writes] BIGINT        NOT NULL,
    [total_physical_reads] BIGINT        NOT NULL,
    [execution_count]      BIGINT        NOT NULL,
    [IsCompile]            BIT           NOT NULL,
    CONSTRAINT [PK_FunctionStats] PRIMARY KEY CLUSTERED ([InstanceID] ASC, [SnapshotDate] ASC, [FunctionID] ASC) WITH (DATA_COMPRESSION = PAGE) ON [PS_FunctionStats] ([SnapshotDate]),
    CONSTRAINT [FK_FunctionStats_Functions] FOREIGN KEY ([FunctionID]) REFERENCES [dbo].[Functions] ([FunctionID])
) ON [PS_FunctionStats] ([SnapshotDate]);






