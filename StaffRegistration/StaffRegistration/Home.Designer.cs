﻿namespace StaffRegistration
{
    partial class StaffRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffRegistration));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tStpBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tStpBtnReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tStpBtnOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tStpBtnAlerts = new System.Windows.Forms.ToolStripButton();
            this.tStpBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.tblSearch = new System.Windows.Forms.DataGridView();
            this.cmbBxSearchDepartment = new System.Windows.Forms.ComboBox();
            this.cmbBxSearchFaculty = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtPassportNo = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.txtSearchNIC = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.txtSearchUPF = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelAlerts = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblAlerts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlertView = new System.Windows.Forms.Button();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearch)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelAlerts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlerts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.generateReportToolStripMenuItem.Text = "Generate Report";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // editOptionsToolStripMenuItem
            // 
            this.editOptionsToolStripMenuItem.Name = "editOptionsToolStripMenuItem";
            this.editOptionsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editOptionsToolStripMenuItem.Text = "Edit Options";
            this.editOptionsToolStripMenuItem.Click += new System.EventHandler(this.editOptionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStpBtnAdd,
            this.toolStripLabel3,
            this.tStpBtnReport,
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.tStpBtnOptions,
            this.toolStripLabel4,
            this.tStpBtnAlerts,
            this.tStpBtnSearch,
            this.toolStripLabel5,
            this.toolStripButtonRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1354, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tStpBtnAdd
            // 
            this.tStpBtnAdd.AutoSize = false;
            this.tStpBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStpBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tStpBtnAdd.Image")));
            this.tStpBtnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tStpBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStpBtnAdd.Name = "tStpBtnAdd";
            this.tStpBtnAdd.Size = new System.Drawing.Size(35, 35);
            this.tStpBtnAdd.Text = "toolStripButton1";
            this.tStpBtnAdd.ToolTipText = "Add Staff Member";
            this.tStpBtnAdd.Click += new System.EventHandler(this.tStpBtnAdd_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel3.Text = " ";
            // 
            // tStpBtnReport
            // 
            this.tStpBtnReport.AutoSize = false;
            this.tStpBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStpBtnReport.Image = ((System.Drawing.Image)(resources.GetObject("tStpBtnReport.Image")));
            this.tStpBtnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tStpBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStpBtnReport.Name = "tStpBtnReport";
            this.tStpBtnReport.Size = new System.Drawing.Size(35, 35);
            this.tStpBtnReport.Text = "toolStripButton2";
            this.tStpBtnReport.ToolTipText = "Reports";
            this.tStpBtnReport.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 37);
            // 
            // tStpBtnOptions
            // 
            this.tStpBtnOptions.AutoSize = false;
            this.tStpBtnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStpBtnOptions.Image = ((System.Drawing.Image)(resources.GetObject("tStpBtnOptions.Image")));
            this.tStpBtnOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tStpBtnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStpBtnOptions.Name = "tStpBtnOptions";
            this.tStpBtnOptions.Size = new System.Drawing.Size(35, 35);
            this.tStpBtnOptions.Text = "toolStripButton3";
            this.tStpBtnOptions.ToolTipText = "Options";
            this.tStpBtnOptions.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel4.Text = " ";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // tStpBtnAlerts
            // 
            this.tStpBtnAlerts.AutoSize = false;
            this.tStpBtnAlerts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStpBtnAlerts.Image = ((System.Drawing.Image)(resources.GetObject("tStpBtnAlerts.Image")));
            this.tStpBtnAlerts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStpBtnAlerts.Name = "tStpBtnAlerts";
            this.tStpBtnAlerts.Size = new System.Drawing.Size(35, 35);
            this.tStpBtnAlerts.Text = "toolStripButton4";
            this.tStpBtnAlerts.ToolTipText = "Alerts";
            this.tStpBtnAlerts.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tStpBtnSearch
            // 
            this.tStpBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStpBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tStpBtnSearch.Image")));
            this.tStpBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStpBtnSearch.Name = "tStpBtnSearch";
            this.tStpBtnSearch.Size = new System.Drawing.Size(23, 37);
            this.tStpBtnSearch.Text = "Search";
            this.tStpBtnSearch.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 37);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnUpdate);
            this.groupBox1.Controls.Add(this.bttnDelete);
            this.groupBox1.Controls.Add(this.tblSearch);
            this.groupBox1.Controls.Add(this.cmbBxSearchDepartment);
            this.groupBox1.Controls.Add(this.cmbBxSearchFaculty);
            this.groupBox1.Controls.Add(this.label55);
            this.groupBox1.Controls.Add(this.txtPassportNo);
            this.groupBox1.Controls.Add(this.label53);
            this.groupBox1.Controls.Add(this.txtSearchNIC);
            this.groupBox1.Controls.Add(this.label54);
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.txtSearchUPF);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1354, 644);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(1174, 605);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(75, 31);
            this.bttnUpdate.TabIndex = 47;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Image = ((System.Drawing.Image)(resources.GetObject("bttnDelete.Image")));
            this.bttnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnDelete.Location = new System.Drawing.Point(1255, 605);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(75, 31);
            this.bttnDelete.TabIndex = 46;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // tblSearch
            // 
            this.tblSearch.AllowUserToAddRows = false;
            this.tblSearch.AllowUserToDeleteRows = false;
            this.tblSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSearch.Location = new System.Drawing.Point(25, 118);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSearch.Size = new System.Drawing.Size(1305, 465);
            this.tblSearch.TabIndex = 45;
            // 
            // cmbBxSearchDepartment
            // 
            this.cmbBxSearchDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxSearchDepartment.FormattingEnabled = true;
            this.cmbBxSearchDepartment.Location = new System.Drawing.Point(1101, 69);
            this.cmbBxSearchDepartment.Name = "cmbBxSearchDepartment";
            this.cmbBxSearchDepartment.Size = new System.Drawing.Size(229, 21);
            this.cmbBxSearchDepartment.TabIndex = 44;
            this.cmbBxSearchDepartment.DropDownClosed += new System.EventHandler(this.cmbBxSearchDepartment_DropDownClosed);
            // 
            // cmbBxSearchFaculty
            // 
            this.cmbBxSearchFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxSearchFaculty.FormattingEnabled = true;
            this.cmbBxSearchFaculty.Location = new System.Drawing.Point(1101, 42);
            this.cmbBxSearchFaculty.Name = "cmbBxSearchFaculty";
            this.cmbBxSearchFaculty.Size = new System.Drawing.Size(229, 21);
            this.cmbBxSearchFaculty.TabIndex = 43;
            this.cmbBxSearchFaculty.DropDownClosed += new System.EventHandler(this.cmbBxSearchFaculty_DropDownClosed);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(992, 72);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(62, 13);
            this.label55.TabIndex = 42;
            this.label55.Text = "Department";
            this.label55.Click += new System.EventHandler(this.label55_Click);
            // 
            // txtPassportNo
            // 
            this.txtPassportNo.Location = new System.Drawing.Point(654, 68);
            this.txtPassportNo.Name = "txtPassportNo";
            this.txtPassportNo.Size = new System.Drawing.Size(207, 20);
            this.txtPassportNo.TabIndex = 41;
            this.txtPassportNo.TextChanged += new System.EventHandler(this.txtPassportNo_TextChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(514, 71);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(88, 13);
            this.label53.TabIndex = 40;
            this.label53.Text = "Passport Number";
            // 
            // txtSearchNIC
            // 
            this.txtSearchNIC.Location = new System.Drawing.Point(654, 42);
            this.txtSearchNIC.Name = "txtSearchNIC";
            this.txtSearchNIC.Size = new System.Drawing.Size(207, 20);
            this.txtSearchNIC.TabIndex = 39;
            this.txtSearchNIC.TextChanged += new System.EventHandler(this.txtSearchNIC_TextChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(514, 45);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(100, 13);
            this.label54.TabIndex = 38;
            this.label54.Text = "National ID Number";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(992, 45);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(41, 13);
            this.label51.TabIndex = 37;
            this.label51.Text = "Faculty";
            this.label51.Click += new System.EventHandler(this.label51_Click);
            // 
            // txtSearchUPF
            // 
            this.txtSearchUPF.Location = new System.Drawing.Point(181, 68);
            this.txtSearchUPF.Name = "txtSearchUPF";
            this.txtSearchUPF.Size = new System.Drawing.Size(207, 20);
            this.txtSearchUPF.TabIndex = 35;
            this.txtSearchUPF.TextChanged += new System.EventHandler(this.txtSearchUPF_TextChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(22, 71);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(119, 13);
            this.label48.TabIndex = 34;
            this.label48.Text = "Provident Fund Number";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(181, 42);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(207, 20);
            this.txtSearchName.TabIndex = 33;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(22, 45);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(35, 13);
            this.label47.TabIndex = 32;
            this.label47.Text = "Name";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.groupBox1);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(0, 64);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1354, 644);
            this.panelSearch.TabIndex = 48;
            // 
            // panelAlerts
            // 
            this.panelAlerts.Controls.Add(this.groupBox2);
            this.panelAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlerts.Location = new System.Drawing.Point(0, 64);
            this.panelAlerts.Name = "panelAlerts";
            this.panelAlerts.Size = new System.Drawing.Size(1354, 644);
            this.panelAlerts.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblAlerts);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1354, 644);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alerts";
            // 
            // tblAlerts
            // 
            this.tblAlerts.AllowUserToAddRows = false;
            this.tblAlerts.AllowUserToDeleteRows = false;
            this.tblAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAlerts.Location = new System.Drawing.Point(12, 61);
            this.tblAlerts.Name = "tblAlerts";
            this.tblAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblAlerts.Size = new System.Drawing.Size(1333, 571);
            this.tblAlerts.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnAlertView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 31);
            this.panel1.TabIndex = 48;
            // 
            // btnAlertView
            // 
            this.btnAlertView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlertView.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAlertView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnAlertView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAlertView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertView.Image = ((System.Drawing.Image)(resources.GetObject("btnAlertView.Image")));
            this.btnAlertView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlertView.Location = new System.Drawing.Point(0, 0);
            this.btnAlertView.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlertView.Name = "btnAlertView";
            this.btnAlertView.Size = new System.Drawing.Size(72, 31);
            this.btnAlertView.TabIndex = 1;
            this.btnAlertView.Text = "View";
            this.btnAlertView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlertView.UseVisualStyleBackColor = false;
            this.btnAlertView.Click += new System.EventHandler(this.btnAlertView_Click);
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.BackColor = System.Drawing.Color.Red;
            this.lblIndicator.Enabled = false;
            this.lblIndicator.Location = new System.Drawing.Point(146, 28);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(13, 13);
            this.lblIndicator.TabIndex = 51;
            this.lblIndicator.Text = "0";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(10, 37);
            this.toolStripLabel5.Text = " ";
            // 
            // StaffRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 708);
            this.Controls.Add(this.lblIndicator);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelAlerts);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StaffRegistration";
            this.Text = "Staff Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffRegistration_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSearch)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelAlerts.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblAlerts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tblSearch;
        private System.Windows.Forms.ComboBox cmbBxSearchDepartment;
        private System.Windows.Forms.ComboBox cmbBxSearchFaculty;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtPassportNo;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txtSearchNIC;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtSearchUPF;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.ToolStripButton tStpBtnAdd;
        private System.Windows.Forms.ToolStripButton tStpBtnReport;
        private System.Windows.Forms.ToolStripButton tStpBtnOptions;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton tStpBtnAlerts;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelAlerts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tblAlerts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlertView;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tStpBtnSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.Label lblIndicator;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
    }
}

