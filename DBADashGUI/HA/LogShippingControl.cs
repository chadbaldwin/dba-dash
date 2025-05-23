﻿using DBADash;
using DBADashGUI.HA;
using DBADashGUI.Interface;
using DBADashGUI.Messaging;
using DBADashGUI.Performance;
using DBADashGUI.Theme;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml.InkML;
using Microsoft.Web.WebView2.Core.Raw;

namespace DBADashGUI.LogShipping
{
    public partial class LogShippingControl : UserControl, INavigation, ISetContext, ISetStatus
    {
        private List<int> InstanceIDs;
        private DBADashContext context;

        public bool IncludeCritical
        {
            get => statusFilterToolStrip1.Critical; set => statusFilterToolStrip1.Critical = value;
        }

        public bool IncludeWarning
        {
            get => statusFilterToolStrip1.Warning; set => statusFilterToolStrip1.Warning = value;
        }

        public bool IncludeNA
        {
            get => statusFilterToolStrip1.NA; set => statusFilterToolStrip1.NA = value;
        }

        public bool IncludeOK
        {
            get => statusFilterToolStrip1.OK; set => statusFilterToolStrip1.OK = value;
        }

        public bool CanNavigateBack => tsBack.Enabled;

        public void SetContext(DBADashContext _context)
        {
            this.context = _context;
            IncludeNA = _context.RegularInstanceIDs.Count == 1;
            IncludeOK = _context.RegularInstanceIDs.Count == 1;
            IncludeWarning = true;
            IncludeCritical = true;
            InstanceIDs = _context.RegularInstanceIDs.ToList();
            tsTrigger.Visible = _context.CanMessage;
            lblStatus.Text = "";
            RefreshData();
        }

        private void RefreshSummary()
        {
            using var cn = new SqlConnection(Common.ConnectionString);
            using var cmd = new SqlCommand("dbo.LogShippingSummary_Get", cn) { CommandType = CommandType.StoredProcedure };
            using var da = new SqlDataAdapter(cmd);
            cn.Open();
            cmd.Parameters.AddWithValue("InstanceIDs", InstanceIDs.AsDataTable());
            cmd.Parameters.AddWithValue("ShowHidden", InstanceIDs.Count == 1 || Common.ShowHidden);
            DataTable dt = new();
            da.Fill(dt);
            DateHelper.ConvertUTCToAppTimeZone(ref dt);
            dgvSummary.AutoGenerateColumns = false;
            if (dgvSummary.Columns.Count == 0)
            {
                dgvSummary.Columns.Add(new DataGridViewLinkColumn() { HeaderText = "Instance", DataPropertyName = "InstanceDisplayName", SortMode = DataGridViewColumnSortMode.Automatic, LinkColor = DashColors.LinkColor, Frozen = Common.FreezeKeyColumn });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "StatusDescription" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Log Shipped DBs", DataPropertyName = "LogshippedDBCount" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Warning", DataPropertyName = "WarningCount" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Critical", DataPropertyName = "CriticalCount" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Max Total Time Behind (Mins)", DataPropertyName = "MaxTotalTimeBehind", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Min Total Time Behind (Mins)", DataPropertyName = "MinTotalTimeBehind", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Avg Total Time Behind (Mins)", DataPropertyName = "AvgTotalTimeBehind", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Max Latency of Last (Mins)", DataPropertyName = "MaxLatencyOfLast", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Avg Latency of Last (Mins)", DataPropertyName = "AvgLatencyOfLast", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Min Latency of Last (Mins)", DataPropertyName = "MinLatencyOfLast", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Max Time Since Last (Mins)", DataPropertyName = "MaxTimeSinceLast", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Min Time Since Last (Mins)", DataPropertyName = "MinTimeSinceLast", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Avg Time Since Last (Mins)", DataPropertyName = "AvgTimeSinceLast", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Max Total Time Behind", DataPropertyName = "MaxTotalTimeBehindDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Min Total Time Behind", DataPropertyName = "MinTotalTimeBehindDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Avg Total Time Behind", DataPropertyName = "AvgTotalTimeBehindDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Max Latency of Last", DataPropertyName = "MaxLatencyOfLastDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Min Latency of Last", DataPropertyName = "MinLatencyOfLastDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Avg Latency of Last", DataPropertyName = "AvgLatencyOfLastDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Max Time Since Last", DataPropertyName = "MaxTimeSinceLastDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Min Time Since Last", DataPropertyName = "MinTimeSinceLastDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Avg Time Since Last", DataPropertyName = "AvgTimeSinceLastDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { Name = "SnapshotAge", HeaderText = "Snapshot Age (Mins)", DataPropertyName = "SnapshotAge", Visible = false, DefaultCellStyle = Common.DataGridViewNumericCellStyleNoDigits });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { Name = "SnapshotAgeDuration", HeaderText = "Snapshot Age", DataPropertyName = "SnapshotAgeDuration" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Backup Date of Oldest File", DataPropertyName = "MinDateOfLastBackupRestored" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Backup Date of Newest File", DataPropertyName = "MaxDateOfLastBackupRestored" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Restore Date of Oldest File", DataPropertyName = "MinLastRestoreCompleted" });
                dgvSummary.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Restore Date of Newest File", DataPropertyName = "MaxLastRestoreCompleted" });
                dgvSummary.Columns.Add(new DataGridViewLinkColumn() { Name = "Configure", HeaderText = "Configure", Text = "Configure", UseColumnTextForLinkValue = true, LinkColor = DashColors.LinkColor });
            }
            dgvSummary.ApplyTheme();
            dgvSummary.DataSource = new DataView(dt);
            dgvSummary.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private DataTable GetLogShippingDataTable()
        {
            using var cn = new SqlConnection(Common.ConnectionString);
            using var cmd = new SqlCommand("dbo.LogShipping_Get", cn) { CommandType = CommandType.StoredProcedure };
            using var da = new SqlDataAdapter(cmd);
            cn.Open();
            cmd.Parameters.AddWithValue("InstanceIDs", string.Join(",", InstanceIDs));
            cmd.Parameters.AddWithValue("ShowHidden", InstanceIDs.Count == 1 || Common.ShowHidden);
            cmd.Parameters.AddRange(statusFilterToolStrip1.GetSQLParams());

            DataTable dt = new();
            da.Fill(dt);
            DateHelper.ConvertUTCToAppTimeZone(ref dt);
            dt.Columns["restore_date_utc"].ColumnName = "restore_date";
            dt.Columns["backup_start_date_utc"].ColumnName = "backup_start_date";
            return dt;
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke(RefreshData);
                return;
            }
            RefreshSummary();
            var dt = GetLogShippingDataTable();
            // Metrics config visible to App role and admin users.  Not visible to AppReadOnly role.
            tsConfigureMetrics.Visible = DBADashUser.IsAdmin || DBADashUser.Roles.Contains("App");
            tsBack.Enabled = (context.RegularInstanceIDs.Count > 1 && InstanceIDs.Count == 1);
            dgvLogShipping.AutoGenerateColumns = false;
            dgvLogShipping.Columns[0].Frozen = Common.FreezeKeyColumn;
            dgvLogShipping.DataSource = new DataView(dt);
            dgvLogShipping.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            tsConfigureInstance.Enabled = InstanceIDs.Count == 1;
            configureInstanceThresholdsToolStripMenuItem.Enabled = InstanceIDs.Count == 1;
        }

        public void SetStatus(string message, string tooltip, Color color)
        {
            lblStatus.InvokeSetStatus(message, tooltip, color);
        }

        public LogShippingControl()
        {
            InitializeComponent();
            dgvSummary.RegisterClearFilter(tsClearFilterSummary);
            dgvLogShipping.RegisterClearFilter(tsClearFilterDetail);
        }

        private void TsFilter_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DgvLogShipping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvLogShipping.Columns[e.ColumnIndex].HeaderText == "Configure")
                {
                    var row = (DataRowView)dgvLogShipping.Rows[e.RowIndex].DataBoundItem;
                    ConfigureThresholds((int)row["InstanceID"], (int)row["DatabaseID"]);
                }
            }
        }

        public void ConfigureThresholds(int InstanceID, int DatabaseID)
        {
            var frm = new LogShippingThresholdsConfig
            {
                InstanceID = InstanceID,
                DatabaseID = DatabaseID
            };
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void ConfigureInstanceThresholdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InstanceIDs.Count == 1)
            {
                ConfigureThresholds(InstanceIDs[0], -1);
            }
        }

        private void ConfigureRootThresholdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigureThresholds(-1, -1);
        }

        private void DgvLogShipping_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (var idx = e.RowIndex; idx < e.RowIndex + e.RowCount; idx += 1)
            {
                var row = (DataRowView)dgvLogShipping.Rows[idx].DataBoundItem;
                var status = (DBADashStatus.DBADashStatusEnum)row["Status"];
                var snapshotStatus = (DBADashStatus.DBADashStatusEnum)row["SnapshotAgeStatus"];
                dgvLogShipping.Rows[idx].Cells["SnapshotAge"].SetStatusColor(snapshotStatus);
                dgvLogShipping.Rows[idx].Cells["SnapshotAgeDuration"].SetStatusColor(snapshotStatus);
                dgvLogShipping.Rows[idx].Cells["Status"].SetStatusColor(status);
                dgvLogShipping.Rows[idx].Cells["Configure"].Style.Font = (string)row["ThresholdConfiguredLevel"] == "Database" ? new Font(dgvLogShipping.Font, FontStyle.Bold) : new Font(dgvLogShipping.Font, FontStyle.Regular);
            }
        }

        private void TsCopy_Click(object sender, EventArgs e)
        {
            dgvSummary.Columns["Configure"].Visible = false;
            dgvSummary.CopyGrid();
            dgvSummary.Columns["Configure"].Visible = true;
        }

        private void TsRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void TsExcel_Click(object sender, EventArgs e)
        {
            dgvSummary.Columns["Configure"].Visible = false;
            dgvSummary.ExportToExcel();
            dgvSummary.Columns["Configure"].Visible = true;
        }

        private void DgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var r = (DataRowView)dgvSummary.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex == 0)
                {
                    var instanceId = (int)r["InstanceID"];
                    InstanceIDs = new List<int> { instanceId };
                    IncludeCritical = true;
                    IncludeNA = true;
                    IncludeOK = true;
                    IncludeWarning = true;
                    var tempContext = (DBADashContext)context.Clone();
                    tempContext.InstanceID = instanceId;
                    tsTrigger.Visible = tempContext.CanMessage;
                    RefreshData();
                }
                else if (dgvSummary.Columns[e.ColumnIndex].HeaderText == "Configure")
                {
                    ConfigureThresholds((int)r["InstanceID"], -1);
                }
            }
        }

        private void TsBack_Click(object sender, EventArgs e)
        {
            NavigateBack();
        }

        public bool NavigateBack()
        {
            if (CanNavigateBack)
            {
                SetContext(context);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DgvSummary_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int idx = e.RowIndex; idx < e.RowIndex + e.RowCount; idx += 1)
            {
                var row = (DataRowView)dgvSummary.Rows[idx].DataBoundItem;
                var Status = (DBADashStatus.DBADashStatusEnum)row["Status"];
                var snapshotStatus = (DBADashStatus.DBADashStatusEnum)row["SnapshotAgeStatus"];
                dgvSummary.Rows[idx].Cells["SnapshotAge"].SetStatusColor(snapshotStatus);
                dgvSummary.Rows[idx].Cells["SnapshotAgeDuration"].SetStatusColor(snapshotStatus);
                dgvSummary.Rows[idx].Cells["Status"].SetStatusColor(Status);
                if ((bool)row["InstanceLevelThreshold"])
                {
                    dgvSummary.Rows[idx].Cells["Configure"].Style.Font = new Font(dgvSummary.Font, FontStyle.Bold);
                }
                else
                {
                    dgvSummary.Rows[idx].Cells["Configure"].Style.Font = new Font(dgvSummary.Font, FontStyle.Regular);
                }
            }
        }

        private void TsCopyDetail_Click(object sender, EventArgs e)
        {
            Configure.Visible = false;
            dgvLogShipping.CopyGrid();
            Configure.Visible = true;
        }

        private void TsExportExcelDetail_Click(object sender, EventArgs e)
        {
            Configure.Visible = false;
            dgvLogShipping.ExportToExcel();
            Configure.Visible = true;
        }

        private async void tsTrigger_Click(object sender, EventArgs e)
        {
            if (InstanceIDs.Count != 1)
            {
                lblStatus.Text = "Please select a single instance to trigger a collection";
            }
            var instanceId = InstanceIDs[0];
            await CollectionMessaging.TriggerCollection(instanceId, new List<CollectionType>() { CollectionType.LogRestores, CollectionType.Databases }, this);
        }

        private void ConfigureRoot_Click(object sender, EventArgs e)
        {
            ConfigureMetrics(-1);
        }

        private static void ConfigureMetrics(int instanceId)
        {
            using var metricsConfig = new RepositoryMetricsConfig() { InstanceID = instanceId, MetricType = RepositoryMetricsConfig.RepositoryMetricTypes.LogShipping };
            metricsConfig.ShowDialog();
        }

        private void ConfigureInstance_Click(object sender, EventArgs e)
        {
            if (InstanceIDs.Count != 1) return;
            ConfigureMetrics(InstanceIDs[0]);
        }
    }
}