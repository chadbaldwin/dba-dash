﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBADashGUI.DBFiles
{
    public partial class DBFilesControl : UserControl
    {
        public DBFilesControl()
        {
            InitializeComponent();
        }

        public List<Int32> InstanceIDs;
        public string ConnectionString;
        public Int32? DatabaseID;

        public bool IncludeCritical
        {
            get
            {
                return criticalToolStripMenuItem.Checked;
            }
            set
            {
                criticalToolStripMenuItem.Checked = value;
            }
        }

        public bool IncludeWarning
        {
            get
            {
                return warningToolStripMenuItem.Checked;
            }
            set
            {
                warningToolStripMenuItem.Checked = value;
            }
        }
        public bool IncludeNA
        {
            get
            {
                return undefinedToolStripMenuItem.Checked;
            }
            set
            {
                undefinedToolStripMenuItem.Checked = value;
            }
        }
        public bool IncludeOK
        {
            get
            {
                return OKToolStripMenuItem.Checked;
            }
            set
            {
                OKToolStripMenuItem.Checked = value;
            }
        }

        public void RefreshData()
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            using (cn)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("dbo.DBFiles_Get", cn);
                cmd.Parameters.AddWithValue("InstanceIDs", string.Join(",",InstanceIDs));
                if (DatabaseID != null) { cmd.Parameters.AddWithValue("DatabaseID", DatabaseID); }
                cmd.Parameters.AddWithValue("IncludeNA", IncludeNA);
                cmd.Parameters.AddWithValue("IncludeOK", IncludeOK);
                cmd.Parameters.AddWithValue("IncludeWarning", IncludeWarning);
                cmd.Parameters.AddWithValue("IncludeCritical", IncludeCritical);
                cmd.Parameters.AddWithValue("FilegroupLevel", tsFilegroup.Checked);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFiles.AutoGenerateColumns = false;
                dgvFiles.DataSource = new DataView(dt);
            }

            configureInstanceThresholdsToolStripMenuItem.Enabled = InstanceIDs.Count == 1;
            configureDatabaseThresholdsToolStripMenuItem.Enabled = InstanceIDs.Count == 1 && DatabaseID > 0;
   
        }

        private void criticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void warningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void undefinedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void OKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = (DataRowView)dgvFiles.Rows[e.RowIndex].DataBoundItem;
                if (dgvFiles.Columns[e.ColumnIndex].HeaderText == "Configure")
                {
                    ConfigureThresholds((Int32)row["InstanceID"], (Int32)row["DatabaseID"], (Int32)row["data_space_id"]);
                }
                else if (dgvFiles.Columns[e.ColumnIndex].HeaderText == "History")
                {
                    var frm = new DBSpaceHistoryView();
                    frm.DatabaseID = (Int32)row["DatabaseID"];
                    frm.DataSpaceID = row["data_space_id"] == DBNull.Value ? null : (Int32?)row["data_space_id"];
                    frm.Instance = (string)row["Instance"];
                    frm.DBName = (string)row["name"];
                    frm.FileName = row["file_name"] == DBNull.Value ? null : (string)row["file_name"];
                    frm.Show();
                }
            }
        }

        public void ConfigureThresholds(Int32 InstanceID, Int32 DatabaseID,Int32 DataSpaceID)
        {
            var threshold = FileThreshold.GetFileThreshold(InstanceID, DatabaseID, DataSpaceID, ConnectionString);
            var frm = new FileThresholdConfig();
            frm.FileThreshold = threshold;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void dgvFiles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (Int32 idx = e.RowIndex; idx < e.RowIndex + e.RowCount; idx += 1)
            {
                var row = (DataRowView)dgvFiles.Rows[idx].DataBoundItem;
                var Status = (DBADashStatus.DBADashStatusEnum)row["FreeSpaceStatus"];
                var snapshotStatus = (DBADashStatus.DBADashStatusEnum)row["FileSnapshotAgeStatus"];
                string checkType = row["FreeSpaceCheckType"] == DBNull.Value ? "-" : (string)row["FreeSpaceCheckType"];
                dgvFiles.Rows[idx].Cells["FileSnapshotAge"].Style.BackColor = DBADashStatus.GetStatusColour(snapshotStatus);
                dgvFiles.Rows[idx].Cells["FilegroupPctFree"].Style.BackColor = Color.White;
                dgvFiles.Rows[idx].Cells["FilegroupFreeMB"].Style.BackColor = Color.White;
                if (checkType != "M")
                {
                    dgvFiles.Rows[idx].Cells["FilegroupPctFree"].Style.BackColor = DBADashStatus.GetStatusColour(Status);
                }
                if (checkType != "%")
                {
                    dgvFiles.Rows[idx].Cells["FilegroupFreeMB"].Style.BackColor = DBADashStatus.GetStatusColour(Status);
                }

                if (row["ConfiguredLevel"]!=DBNull.Value && (string)row["ConfiguredLevel"] == "FG")
                {
                    dgvFiles.Rows[idx].Cells["Configure"].Style.Font = new Font(dgvFiles.Font, FontStyle.Bold);
                }
                else
                {
                    dgvFiles.Rows[idx].Cells["Configure"].Style.Font = new Font(dgvFiles.Font, FontStyle.Regular);
                }
            }
        }

        private void configureDatabaseThresholdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(InstanceIDs.Count==1 && DatabaseID > 0)
            {
                ConfigureThresholds(InstanceIDs[0], (Int32)DatabaseID, -1);
            }
        }

        private void configureInstanceThresholdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InstanceIDs.Count == 1) {
                ConfigureThresholds(InstanceIDs[0], -1, -1);
            }
        }

        private void configureRootThresholdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigureThresholds(-1, -1, -1);
        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void tsCopy_Click(object sender, EventArgs e)
        {
            Configure.Visible = false;
            History.Visible = false;
            Common.CopyDataGridViewToClipboard(dgvFiles);
            Configure.Visible = true;
            History.Visible = true;
        }

        private void tsFilegroup_Click(object sender, EventArgs e)
        {
            toggleFileLevel(false);
            RefreshData();
        }

        private void tsFile_Click(object sender, EventArgs e)
        {
            toggleFileLevel(true);
            RefreshData();
        }

        private void toggleFileLevel(bool isFileLevel)
        {
            tsFilegroup.Checked = !isFileLevel;
            tsFile.Checked = isFileLevel;
            foreach(DataGridViewColumn col in dgvFiles.Columns)
            {
                if (col.Name.StartsWith("FileLevel_")){
                    col.Visible = isFileLevel;
                }
            }
        }
    }
}