﻿namespace DBAChecksGUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tv1 = new System.Windows.Forms.TreeView();
            this.TreeViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dBDiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabSnapshotsSummary = new System.Windows.Forms.TabPage();
            this.splitSnapshotSummary = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsSummaryBack = new System.Windows.Forms.ToolStripButton();
            this.tsSummaryPageNum = new System.Windows.Forms.ToolStripLabel();
            this.tsSummaryNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsSummaryPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.gvSnapshots = new System.Windows.Forms.DataGridView();
            this.DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnapshotDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidForDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysSinceValidation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dropped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSnapshotsDetail = new System.Windows.Forms.DataGridView();
            this.colObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchemaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Diff = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabSchema = new System.Windows.Forms.TabPage();
            this.splitSchemaSnapshot = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsPageNum = new System.Windows.Forms.ToolStripLabel();
            this.tsNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.gvHistory = new System.Windows.Forms.DataGridView();
            this.ObjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchemaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnapshotValidFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SnapshotValidTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectDateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabSnapshotsSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSnapshotSummary)).BeginInit();
            this.splitSnapshotSummary.Panel1.SuspendLayout();
            this.splitSnapshotSummary.Panel2.SuspendLayout();
            this.splitSnapshotSummary.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSnapshots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSnapshotsDetail)).BeginInit();
            this.tabSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSchemaSnapshot)).BeginInit();
            this.splitSchemaSnapshot.Panel1.SuspendLayout();
            this.splitSchemaSnapshot.Panel2.SuspendLayout();
            this.splitSchemaSnapshot.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tv1
            // 
            this.tv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv1.ImageIndex = 0;
            this.tv1.ImageList = this.TreeViewImageList;
            this.tv1.Location = new System.Drawing.Point(0, 0);
            this.tv1.Name = "tv1";
            this.tv1.SelectedImageIndex = 0;
            this.tv1.Size = new System.Drawing.Size(406, 841);
            this.tv1.TabIndex = 0;
            this.tv1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv1_BeforeExpand);
            this.tv1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv1_AfterSelect);
            // 
            // TreeViewImageList
            // 
            this.TreeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeViewImageList.ImageStream")));
            this.TreeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeViewImageList.Images.SetKeyName(0, "ServerProject_16x.png");
            this.TreeViewImageList.Images.SetKeyName(1, "DataServer_16x.png");
            this.TreeViewImageList.Images.SetKeyName(2, "Database_16x.png");
            this.TreeViewImageList.Images.SetKeyName(3, "FolderClosed_16x.png");
            this.TreeViewImageList.Images.SetKeyName(4, "Table_16x.png");
            this.TreeViewImageList.Images.SetKeyName(5, "StoredProcedureScript_16x.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBDiffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dBDiffToolStripMenuItem
            // 
            this.dBDiffToolStripMenuItem.Name = "dBDiffToolStripMenuItem";
            this.dBDiffToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.dBDiffToolStripMenuItem.Text = "DBDiff";
            this.dBDiffToolStripMenuItem.Click += new System.EventHandler(this.dBDiffToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 841);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitMain
            // 
            this.splitMain.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(3, 28);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.tv1);
            this.splitMain.Panel1MinSize = 50;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tabs);
            this.splitMain.Panel2MinSize = 100;
            this.splitMain.Size = new System.Drawing.Size(1184, 841);
            this.splitMain.SplitterDistance = 406;
            this.splitMain.TabIndex = 3;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabSnapshotsSummary);
            this.tabs.Controls.Add(this.tabSchema);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(774, 841);
            this.tabs.TabIndex = 0;
            // 
            // tabSnapshotsSummary
            // 
            this.tabSnapshotsSummary.Controls.Add(this.splitSnapshotSummary);
            this.tabSnapshotsSummary.Location = new System.Drawing.Point(4, 25);
            this.tabSnapshotsSummary.Name = "tabSnapshotsSummary";
            this.tabSnapshotsSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSnapshotsSummary.Size = new System.Drawing.Size(766, 812);
            this.tabSnapshotsSummary.TabIndex = 1;
            this.tabSnapshotsSummary.Text = "Snapshot Summary";
            this.tabSnapshotsSummary.UseVisualStyleBackColor = true;
            // 
            // splitSnapshotSummary
            // 
            this.splitSnapshotSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSnapshotSummary.Location = new System.Drawing.Point(3, 3);
            this.splitSnapshotSummary.Name = "splitSnapshotSummary";
            this.splitSnapshotSummary.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitSnapshotSummary.Panel1
            // 
            this.splitSnapshotSummary.Panel1.Controls.Add(this.toolStrip2);
            this.splitSnapshotSummary.Panel1.Controls.Add(this.gvSnapshots);
            // 
            // splitSnapshotSummary.Panel2
            // 
            this.splitSnapshotSummary.Panel2.Controls.Add(this.gvSnapshotsDetail);
            this.splitSnapshotSummary.Size = new System.Drawing.Size(760, 806);
            this.splitSnapshotSummary.SplitterDistance = 249;
            this.splitSnapshotSummary.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSummaryBack,
            this.tsSummaryPageNum,
            this.tsSummaryNext,
            this.toolStripLabel3,
            this.tsSummaryPageSize});
            this.toolStrip2.Location = new System.Drawing.Point(0, 221);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(760, 28);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsSummaryBack
            // 
            this.tsSummaryBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSummaryBack.Image = ((System.Drawing.Image)(resources.GetObject("tsSummaryBack.Image")));
            this.tsSummaryBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSummaryBack.Name = "tsSummaryBack";
            this.tsSummaryBack.Size = new System.Drawing.Size(29, 25);
            this.tsSummaryBack.Text = "Previous";
            this.tsSummaryBack.Click += new System.EventHandler(this.tsSummaryBack_Click);
            // 
            // tsSummaryPageNum
            // 
            this.tsSummaryPageNum.Name = "tsSummaryPageNum";
            this.tsSummaryPageNum.Size = new System.Drawing.Size(53, 25);
            this.tsSummaryPageNum.Text = "Page 1";
            // 
            // tsSummaryNext
            // 
            this.tsSummaryNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSummaryNext.Image = ((System.Drawing.Image)(resources.GetObject("tsSummaryNext.Image")));
            this.tsSummaryNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSummaryNext.Name = "tsSummaryNext";
            this.tsSummaryNext.Size = new System.Drawing.Size(29, 25);
            this.tsSummaryNext.Text = "Next";
            this.tsSummaryNext.Click += new System.EventHandler(this.tsSummaryNext_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(75, 25);
            this.toolStripLabel3.Text = "Page Size:";
            // 
            // tsSummaryPageSize
            // 
            this.tsSummaryPageSize.Items.AddRange(new object[] {
            "100",
            "200",
            "500",
            "1000",
            "5000"});
            this.tsSummaryPageSize.Name = "tsSummaryPageSize";
            this.tsSummaryPageSize.Size = new System.Drawing.Size(121, 28);
            this.tsSummaryPageSize.Text = "100";
            this.tsSummaryPageSize.Validating += new System.ComponentModel.CancelEventHandler(this.tsSummaryPageSize_Validating);
            this.tsSummaryPageSize.Validated += new System.EventHandler(this.tsSummaryPageSize_Validated);
            // 
            // gvSnapshots
            // 
            this.gvSnapshots.AllowUserToAddRows = false;
            this.gvSnapshots.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSnapshots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvSnapshots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSnapshots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DB,
            this.SnapshotDate,
            this.ValidatedDate,
            this.ValidForDays,
            this.DaysSinceValidation,
            this.Created,
            this.Modified,
            this.Dropped});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSnapshots.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvSnapshots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSnapshots.Location = new System.Drawing.Point(0, 0);
            this.gvSnapshots.Name = "gvSnapshots";
            this.gvSnapshots.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSnapshots.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvSnapshots.RowHeadersWidth = 51;
            this.gvSnapshots.RowTemplate.Height = 24;
            this.gvSnapshots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSnapshots.Size = new System.Drawing.Size(760, 249);
            this.gvSnapshots.TabIndex = 0;
            this.gvSnapshots.SelectionChanged += new System.EventHandler(this.gvSnapshots_SelectionChanged);
            // 
            // DB
            // 
            this.DB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DB.DataPropertyName = "DB";
            this.DB.HeaderText = "DB";
            this.DB.MinimumWidth = 6;
            this.DB.Name = "DB";
            this.DB.ReadOnly = true;
            this.DB.Width = 56;
            // 
            // SnapshotDate
            // 
            this.SnapshotDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SnapshotDate.DataPropertyName = "SnapshotDate";
            this.SnapshotDate.HeaderText = "Snapshot Date";
            this.SnapshotDate.MinimumWidth = 6;
            this.SnapshotDate.Name = "SnapshotDate";
            this.SnapshotDate.ReadOnly = true;
            this.SnapshotDate.Width = 120;
            // 
            // ValidatedDate
            // 
            this.ValidatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ValidatedDate.DataPropertyName = "ValidatedDate";
            this.ValidatedDate.HeaderText = "Validated Date";
            this.ValidatedDate.MinimumWidth = 6;
            this.ValidatedDate.Name = "ValidatedDate";
            this.ValidatedDate.ReadOnly = true;
            this.ValidatedDate.Width = 119;
            // 
            // ValidForDays
            // 
            this.ValidForDays.DataPropertyName = "ValidForDays";
            this.ValidForDays.HeaderText = "Valid For (Days)";
            this.ValidForDays.MinimumWidth = 6;
            this.ValidForDays.Name = "ValidForDays";
            this.ValidForDays.ReadOnly = true;
            this.ValidForDays.Width = 125;
            // 
            // DaysSinceValidation
            // 
            this.DaysSinceValidation.DataPropertyName = "DaysSinceValidation";
            this.DaysSinceValidation.HeaderText = "Days Since Validation";
            this.DaysSinceValidation.MinimumWidth = 6;
            this.DaysSinceValidation.Name = "DaysSinceValidation";
            this.DaysSinceValidation.ReadOnly = true;
            this.DaysSinceValidation.Width = 125;
            // 
            // Created
            // 
            this.Created.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Created.DataPropertyName = "Created";
            this.Created.HeaderText = "Created";
            this.Created.MinimumWidth = 6;
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            this.Created.Width = 87;
            // 
            // Modified
            // 
            this.Modified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Modified.DataPropertyName = "Modified";
            this.Modified.HeaderText = "Modified";
            this.Modified.MinimumWidth = 6;
            this.Modified.Name = "Modified";
            this.Modified.ReadOnly = true;
            this.Modified.Width = 90;
            // 
            // Dropped
            // 
            this.Dropped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Dropped.DataPropertyName = "Dropped";
            this.Dropped.HeaderText = "Dropped";
            this.Dropped.MinimumWidth = 6;
            this.Dropped.Name = "Dropped";
            this.Dropped.ReadOnly = true;
            this.Dropped.Width = 92;
            // 
            // gvSnapshotsDetail
            // 
            this.gvSnapshotsDetail.AllowUserToAddRows = false;
            this.gvSnapshotsDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSnapshotsDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gvSnapshotsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSnapshotsDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colObjectName,
            this.colSchemaName,
            this.colAction,
            this.colView,
            this.Diff});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSnapshotsDetail.DefaultCellStyle = dataGridViewCellStyle14;
            this.gvSnapshotsDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSnapshotsDetail.Location = new System.Drawing.Point(0, 0);
            this.gvSnapshotsDetail.Name = "gvSnapshotsDetail";
            this.gvSnapshotsDetail.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSnapshotsDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gvSnapshotsDetail.RowHeadersWidth = 51;
            this.gvSnapshotsDetail.RowTemplate.Height = 24;
            this.gvSnapshotsDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvSnapshotsDetail.Size = new System.Drawing.Size(760, 553);
            this.gvSnapshotsDetail.TabIndex = 0;
            this.gvSnapshotsDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSnapshotsDetail_CellContentClick);
            // 
            // colObjectName
            // 
            this.colObjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colObjectName.DataPropertyName = "ObjectName";
            this.colObjectName.HeaderText = "Object Name";
            this.colObjectName.MinimumWidth = 6;
            this.colObjectName.Name = "colObjectName";
            this.colObjectName.ReadOnly = true;
            this.colObjectName.Width = 119;
            // 
            // colSchemaName
            // 
            this.colSchemaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSchemaName.DataPropertyName = "SchemaName";
            this.colSchemaName.HeaderText = "Schema Name";
            this.colSchemaName.MinimumWidth = 6;
            this.colSchemaName.Name = "colSchemaName";
            this.colSchemaName.ReadOnly = true;
            this.colSchemaName.Width = 129;
            // 
            // colAction
            // 
            this.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colAction.DataPropertyName = "Action";
            this.colAction.HeaderText = "Action";
            this.colAction.MinimumWidth = 6;
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Width = 76;
            // 
            // colView
            // 
            this.colView.DataPropertyName = "newDDLID";
            this.colView.HeaderText = "View";
            this.colView.MinimumWidth = 6;
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Text = "View";
            this.colView.UseColumnTextForLinkValue = true;
            this.colView.Width = 125;
            // 
            // Diff
            // 
            this.Diff.DataPropertyName = "OldDDLID";
            this.Diff.HeaderText = "Diff";
            this.Diff.MinimumWidth = 6;
            this.Diff.Name = "Diff";
            this.Diff.ReadOnly = true;
            this.Diff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Diff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Diff.Text = "Diff";
            this.Diff.UseColumnTextForLinkValue = true;
            this.Diff.Width = 125;
            // 
            // tabSchema
            // 
            this.tabSchema.Controls.Add(this.splitSchemaSnapshot);
            this.tabSchema.Location = new System.Drawing.Point(4, 25);
            this.tabSchema.Name = "tabSchema";
            this.tabSchema.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchema.Size = new System.Drawing.Size(766, 812);
            this.tabSchema.TabIndex = 0;
            this.tabSchema.Text = "Schema Snapshot";
            this.tabSchema.UseVisualStyleBackColor = true;
            // 
            // splitSchemaSnapshot
            // 
            this.splitSchemaSnapshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSchemaSnapshot.Location = new System.Drawing.Point(3, 3);
            this.splitSchemaSnapshot.Name = "splitSchemaSnapshot";
            this.splitSchemaSnapshot.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitSchemaSnapshot.Panel1
            // 
            this.splitSchemaSnapshot.Panel1.Controls.Add(this.label7);
            // 
            // splitSchemaSnapshot.Panel2
            // 
            this.splitSchemaSnapshot.Panel2.Controls.Add(this.toolStrip1);
            this.splitSchemaSnapshot.Panel2.Controls.Add(this.gvHistory);
            this.splitSchemaSnapshot.Panel2.Controls.Add(this.label1);
            this.splitSchemaSnapshot.Size = new System.Drawing.Size(760, 806);
            this.splitSchemaSnapshot.SplitterDistance = 489;
            this.splitSchemaSnapshot.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(331, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Diff (Loaded programatically due to designer issue)";
            this.label7.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPrevious,
            this.tsPageNum,
            this.tsNext,
            this.toolStripLabel1,
            this.tsPageSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 285);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsPrevious
            // 
            this.tsPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsPrevious.Image")));
            this.tsPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrevious.Name = "tsPrevious";
            this.tsPrevious.Size = new System.Drawing.Size(29, 25);
            this.tsPrevious.Text = "Previous";
            this.tsPrevious.Click += new System.EventHandler(this.tsPrevious_Click);
            // 
            // tsPageNum
            // 
            this.tsPageNum.Name = "tsPageNum";
            this.tsPageNum.Size = new System.Drawing.Size(53, 25);
            this.tsPageNum.Text = "Page 1";
            // 
            // tsNext
            // 
            this.tsNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNext.Image = ((System.Drawing.Image)(resources.GetObject("tsNext.Image")));
            this.tsNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNext.Name = "tsNext";
            this.tsNext.Size = new System.Drawing.Size(29, 25);
            this.tsNext.Text = "Next";
            this.tsNext.Click += new System.EventHandler(this.tsNext_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(75, 25);
            this.toolStripLabel1.Text = "Page Size:";
            // 
            // tsPageSize
            // 
            this.tsPageSize.Items.AddRange(new object[] {
            "100",
            "200",
            "500",
            "1000",
            "5000"});
            this.tsPageSize.Name = "tsPageSize";
            this.tsPageSize.Size = new System.Drawing.Size(121, 28);
            this.tsPageSize.Text = "100";
            this.tsPageSize.Validating += new System.ComponentModel.CancelEventHandler(this.tsPageSize_Validating);
            this.tsPageSize.Validated += new System.EventHandler(this.tsPageSize_Validated);
            // 
            // gvHistory
            // 
            this.gvHistory.AllowUserToAddRows = false;
            this.gvHistory.AllowUserToDeleteRows = false;
            this.gvHistory.AllowUserToOrderColumns = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjectName,
            this.SchemaName,
            this.ObjectType,
            this.SnapshotValidFrom,
            this.SnapshotValidTo,
            this.ObjectDateCreated,
            this.ObjectDateModified});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHistory.DefaultCellStyle = dataGridViewCellStyle17;
            this.gvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvHistory.Location = new System.Drawing.Point(0, 17);
            this.gvHistory.MultiSelect = false;
            this.gvHistory.Name = "gvHistory";
            this.gvHistory.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gvHistory.RowHeadersWidth = 51;
            this.gvHistory.RowTemplate.Height = 24;
            this.gvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHistory.Size = new System.Drawing.Size(760, 296);
            this.gvHistory.TabIndex = 0;
            this.gvHistory.SelectionChanged += new System.EventHandler(this.gvHistory_SelectionChanged);
            // 
            // ObjectName
            // 
            this.ObjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ObjectName.DataPropertyName = "ObjectName";
            this.ObjectName.HeaderText = "Object Name";
            this.ObjectName.MinimumWidth = 6;
            this.ObjectName.Name = "ObjectName";
            this.ObjectName.ReadOnly = true;
            this.ObjectName.Width = 109;
            // 
            // SchemaName
            // 
            this.SchemaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SchemaName.DataPropertyName = "SchemaName";
            this.SchemaName.HeaderText = "Schema Name";
            this.SchemaName.MinimumWidth = 6;
            this.SchemaName.Name = "SchemaName";
            this.SchemaName.ReadOnly = true;
            this.SchemaName.Width = 118;
            // 
            // ObjectType
            // 
            this.ObjectType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ObjectType.HeaderText = "Object Type";
            this.ObjectType.MinimumWidth = 6;
            this.ObjectType.Name = "ObjectType";
            this.ObjectType.ReadOnly = true;
            this.ObjectType.Width = 105;
            // 
            // SnapshotValidFrom
            // 
            this.SnapshotValidFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SnapshotValidFrom.DataPropertyName = "SnapshotValidFrom";
            this.SnapshotValidFrom.HeaderText = "Snapshot Valid From";
            this.SnapshotValidFrom.MinimumWidth = 6;
            this.SnapshotValidFrom.Name = "SnapshotValidFrom";
            this.SnapshotValidFrom.ReadOnly = true;
            this.SnapshotValidFrom.Width = 125;
            // 
            // SnapshotValidTo
            // 
            this.SnapshotValidTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SnapshotValidTo.DataPropertyName = "SnapshotValidTo";
            this.SnapshotValidTo.HeaderText = "Snapshot Valid To";
            this.SnapshotValidTo.MinimumWidth = 6;
            this.SnapshotValidTo.Name = "SnapshotValidTo";
            this.SnapshotValidTo.ReadOnly = true;
            this.SnapshotValidTo.Width = 125;
            // 
            // ObjectDateCreated
            // 
            this.ObjectDateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ObjectDateCreated.DataPropertyName = "ObjectDateCreated";
            this.ObjectDateCreated.HeaderText = "Date Created";
            this.ObjectDateCreated.MinimumWidth = 6;
            this.ObjectDateCreated.Name = "ObjectDateCreated";
            this.ObjectDateCreated.ReadOnly = true;
            this.ObjectDateCreated.Width = 111;
            // 
            // ObjectDateModified
            // 
            this.ObjectDateModified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ObjectDateModified.DataPropertyName = "ObjectDateModified";
            this.ObjectDateModified.HeaderText = "Date Modified";
            this.ObjectDateModified.MinimumWidth = 6;
            this.ObjectDateModified.Name = "ObjectDateModified";
            this.ObjectDateModified.ReadOnly = true;
            this.ObjectDateModified.Width = 114;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Snapshot History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 869);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabSnapshotsSummary.ResumeLayout(false);
            this.splitSnapshotSummary.Panel1.ResumeLayout(false);
            this.splitSnapshotSummary.Panel1.PerformLayout();
            this.splitSnapshotSummary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSnapshotSummary)).EndInit();
            this.splitSnapshotSummary.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSnapshots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSnapshotsDetail)).EndInit();
            this.tabSchema.ResumeLayout(false);
            this.splitSchemaSnapshot.Panel1.ResumeLayout(false);
            this.splitSchemaSnapshot.Panel1.PerformLayout();
            this.splitSchemaSnapshot.Panel2.ResumeLayout(false);
            this.splitSchemaSnapshot.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSchemaSnapshot)).EndInit();
            this.splitSchemaSnapshot.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSchema;
        private System.Windows.Forms.TabPage tabSnapshotsSummary;
        private System.Windows.Forms.ImageList TreeViewImageList;
        private System.Windows.Forms.SplitContainer splitSchemaSnapshot;
        private System.Windows.Forms.DataGridView gvHistory;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsPrevious;
        private System.Windows.Forms.ToolStripLabel tsPageNum;
        private System.Windows.Forms.ToolStripButton tsNext;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tsPageSize;
        private System.Windows.Forms.SplitContainer splitSnapshotSummary;
        private System.Windows.Forms.DataGridView gvSnapshots;
        private System.Windows.Forms.DataGridView gvSnapshotsDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchemaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.DataGridViewLinkColumn colView;
        private System.Windows.Forms.DataGridViewLinkColumn Diff;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsSummaryBack;
        private System.Windows.Forms.ToolStripLabel tsSummaryPageNum;
        private System.Windows.Forms.ToolStripButton tsSummaryNext;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox tsSummaryPageSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn DB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnapshotDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidForDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysSinceValidation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modified;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dropped;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchemaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnapshotValidFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnapshotValidTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectDateModified;
        private System.Windows.Forms.ToolStripMenuItem dBDiffToolStripMenuItem;
        private System.Windows.Forms.Label label7;
    }
}