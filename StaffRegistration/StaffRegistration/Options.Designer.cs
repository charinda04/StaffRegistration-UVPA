namespace StaffRegistration
{
    partial class Options
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBxEditField = new System.Windows.Forms.ComboBox();
            this.panelChangeSalaryCode = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStepAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalarySteps = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.btnRemoveSalaryScale = new System.Windows.Forms.Button();
            this.btnAddSalarySalaryScale = new System.Windows.Forms.Button();
            this.btnRemoveSalaaryCode = new System.Windows.Forms.Button();
            this.btnAddSalaryCode = new System.Windows.Forms.Button();
            this.tblOldScale = new System.Windows.Forms.DataGridView();
            this.txtboxNewSalaryScale = new System.Windows.Forms.TextBox();
            this.tblOldCode = new System.Windows.Forms.DataGridView();
            this.txtboxNewSalaryCode = new System.Windows.Forms.TextBox();
            this.lblNewSalaryCode = new System.Windows.Forms.Label();
            this.panelAddDesignation = new System.Windows.Forms.Panel();
            this.bttnRemoveDesignation = new System.Windows.Forms.Button();
            this.bttnNewDesignation = new System.Windows.Forms.Button();
            this.tblDesignation = new System.Windows.Forms.DataGridView();
            this.txtboxNewDesignation = new System.Windows.Forms.TextBox();
            this.lblNewFaculty = new System.Windows.Forms.Label();
            this.panelAddFaculty = new System.Windows.Forms.Panel();
            this.bttnRemoveDpt = new System.Windows.Forms.Button();
            this.bttnAddNewDpt = new System.Windows.Forms.Button();
            this.tblDepartment = new System.Windows.Forms.DataGridView();
            this.txtboxNewDpt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveFaculty = new System.Windows.Forms.Button();
            this.btnAddNewFaculty = new System.Windows.Forms.Button();
            this.tblFaculty = new System.Windows.Forms.DataGridView();
            this.txtboxNewFaculty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEditField = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.Leave = new System.Windows.Forms.Panel();
            this.btnRemoveLeave = new System.Windows.Forms.Button();
            this.btnAddLeave = new System.Windows.Forms.Button();
            this.tblLeave = new System.Windows.Forms.DataGridView();
            this.txtLeave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelChangeSalaryCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOldScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOldCode)).BeginInit();
            this.panelAddDesignation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDesignation)).BeginInit();
            this.panelAddFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaculty)).BeginInit();
            this.Leave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBxEditField);
            this.groupBox1.Controls.Add(this.Leave);
            this.groupBox1.Controls.Add(this.panelAddDesignation);
            this.groupBox1.Controls.Add(this.panelChangeSalaryCode);
            this.groupBox1.Controls.Add(this.panelAddFaculty);
            this.groupBox1.Controls.Add(this.lblEditField);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Fields";
            // 
            // cmbBxEditField
            // 
            this.cmbBxEditField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxEditField.FormattingEnabled = true;
            this.cmbBxEditField.Items.AddRange(new object[] {
            "Faculty & Department",
            "Designation",
            "Salary",
            "Leave Category"});
            this.cmbBxEditField.Location = new System.Drawing.Point(81, 43);
            this.cmbBxEditField.Name = "cmbBxEditField";
            this.cmbBxEditField.Size = new System.Drawing.Size(266, 21);
            this.cmbBxEditField.TabIndex = 35;
            this.cmbBxEditField.SelectedIndexChanged += new System.EventHandler(this.cmbBxEditField_SelectedIndexChanged);
            // 
            // panelChangeSalaryCode
            // 
            this.panelChangeSalaryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChangeSalaryCode.Controls.Add(this.label4);
            this.panelChangeSalaryCode.Controls.Add(this.txtStepAmount);
            this.panelChangeSalaryCode.Controls.Add(this.label3);
            this.panelChangeSalaryCode.Controls.Add(this.txtSalarySteps);
            this.panelChangeSalaryCode.Controls.Add(this.label42);
            this.panelChangeSalaryCode.Controls.Add(this.btnRemoveSalaryScale);
            this.panelChangeSalaryCode.Controls.Add(this.btnAddSalarySalaryScale);
            this.panelChangeSalaryCode.Controls.Add(this.btnRemoveSalaaryCode);
            this.panelChangeSalaryCode.Controls.Add(this.btnAddSalaryCode);
            this.panelChangeSalaryCode.Controls.Add(this.tblOldScale);
            this.panelChangeSalaryCode.Controls.Add(this.txtboxNewSalaryScale);
            this.panelChangeSalaryCode.Controls.Add(this.tblOldCode);
            this.panelChangeSalaryCode.Controls.Add(this.txtboxNewSalaryCode);
            this.panelChangeSalaryCode.Controls.Add(this.lblNewSalaryCode);
            this.panelChangeSalaryCode.Location = new System.Drawing.Point(31, 96);
            this.panelChangeSalaryCode.Name = "panelChangeSalaryCode";
            this.panelChangeSalaryCode.Size = new System.Drawing.Size(1110, 212);
            this.panelChangeSalaryCode.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(857, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Salary Step Amount";
            // 
            // txtStepAmount
            // 
            this.txtStepAmount.Location = new System.Drawing.Point(959, 4);
            this.txtStepAmount.Name = "txtStepAmount";
            this.txtStepAmount.Size = new System.Drawing.Size(144, 20);
            this.txtStepAmount.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Salary Steps";
            // 
            // txtSalarySteps
            // 
            this.txtSalarySteps.Location = new System.Drawing.Point(703, 4);
            this.txtSalarySteps.Name = "txtSalarySteps";
            this.txtSalarySteps.Size = new System.Drawing.Size(144, 20);
            this.txtSalarySteps.TabIndex = 65;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(371, 9);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(91, 13);
            this.label42.TabIndex = 64;
            this.label42.Text = "New Salary Scale";
            // 
            // btnRemoveSalaryScale
            // 
            this.btnRemoveSalaryScale.Location = new System.Drawing.Point(959, 71);
            this.btnRemoveSalaryScale.Name = "btnRemoveSalaryScale";
            this.btnRemoveSalaryScale.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSalaryScale.TabIndex = 63;
            this.btnRemoveSalaryScale.Text = "Remove";
            this.btnRemoveSalaryScale.UseVisualStyleBackColor = true;
            this.btnRemoveSalaryScale.Click += new System.EventHandler(this.btnRemoveSalaryScale_Click);
            // 
            // btnAddSalarySalaryScale
            // 
            this.btnAddSalarySalaryScale.Location = new System.Drawing.Point(959, 45);
            this.btnAddSalarySalaryScale.Name = "btnAddSalarySalaryScale";
            this.btnAddSalarySalaryScale.Size = new System.Drawing.Size(75, 23);
            this.btnAddSalarySalaryScale.TabIndex = 62;
            this.btnAddSalarySalaryScale.Text = "Add";
            this.btnAddSalarySalaryScale.UseVisualStyleBackColor = true;
            this.btnAddSalarySalaryScale.Click += new System.EventHandler(this.btnAddSalarySalaryScale_Click);
            // 
            // btnRemoveSalaaryCode
            // 
            this.btnRemoveSalaaryCode.Location = new System.Drawing.Point(312, 71);
            this.btnRemoveSalaaryCode.Name = "btnRemoveSalaaryCode";
            this.btnRemoveSalaaryCode.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSalaaryCode.TabIndex = 61;
            this.btnRemoveSalaaryCode.Text = "Remove";
            this.btnRemoveSalaaryCode.UseVisualStyleBackColor = true;
            this.btnRemoveSalaaryCode.Click += new System.EventHandler(this.btnRemoveSalaaryCode_Click);
            // 
            // btnAddSalaryCode
            // 
            this.btnAddSalaryCode.Location = new System.Drawing.Point(312, 45);
            this.btnAddSalaryCode.Name = "btnAddSalaryCode";
            this.btnAddSalaryCode.Size = new System.Drawing.Size(75, 23);
            this.btnAddSalaryCode.TabIndex = 60;
            this.btnAddSalaryCode.Text = "Add";
            this.btnAddSalaryCode.UseVisualStyleBackColor = true;
            this.btnAddSalaryCode.Click += new System.EventHandler(this.btnAddSalaryCode_Click);
            // 
            // tblOldScale
            // 
            this.tblOldScale.AllowUserToAddRows = false;
            this.tblOldScale.AllowUserToDeleteRows = false;
            this.tblOldScale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOldScale.Location = new System.Drawing.Point(406, 45);
            this.tblOldScale.Name = "tblOldScale";
            this.tblOldScale.ReadOnly = true;
            this.tblOldScale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblOldScale.Size = new System.Drawing.Size(515, 150);
            this.tblOldScale.TabIndex = 55;
            // 
            // txtboxNewSalaryScale
            // 
            this.txtboxNewSalaryScale.Location = new System.Drawing.Point(468, 4);
            this.txtboxNewSalaryScale.Name = "txtboxNewSalaryScale";
            this.txtboxNewSalaryScale.Size = new System.Drawing.Size(144, 20);
            this.txtboxNewSalaryScale.TabIndex = 54;
            // 
            // tblOldCode
            // 
            this.tblOldCode.AllowUserToAddRows = false;
            this.tblOldCode.AllowUserToDeleteRows = false;
            this.tblOldCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOldCode.Location = new System.Drawing.Point(49, 45);
            this.tblOldCode.Name = "tblOldCode";
            this.tblOldCode.ReadOnly = true;
            this.tblOldCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblOldCode.Size = new System.Drawing.Size(238, 150);
            this.tblOldCode.TabIndex = 53;
            this.tblOldCode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblOldCode_CellClick);
            // 
            // txtboxNewSalaryCode
            // 
            this.txtboxNewSalaryCode.Location = new System.Drawing.Point(141, 5);
            this.txtboxNewSalaryCode.Name = "txtboxNewSalaryCode";
            this.txtboxNewSalaryCode.Size = new System.Drawing.Size(147, 20);
            this.txtboxNewSalaryCode.TabIndex = 52;
            // 
            // lblNewSalaryCode
            // 
            this.lblNewSalaryCode.AutoSize = true;
            this.lblNewSalaryCode.Location = new System.Drawing.Point(46, 8);
            this.lblNewSalaryCode.Name = "lblNewSalaryCode";
            this.lblNewSalaryCode.Size = new System.Drawing.Size(89, 13);
            this.lblNewSalaryCode.TabIndex = 51;
            this.lblNewSalaryCode.Text = "New Salary Code";
            // 
            // panelAddDesignation
            // 
            this.panelAddDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddDesignation.Controls.Add(this.bttnRemoveDesignation);
            this.panelAddDesignation.Controls.Add(this.bttnNewDesignation);
            this.panelAddDesignation.Controls.Add(this.tblDesignation);
            this.panelAddDesignation.Controls.Add(this.txtboxNewDesignation);
            this.panelAddDesignation.Controls.Add(this.lblNewFaculty);
            this.panelAddDesignation.Location = new System.Drawing.Point(31, 96);
            this.panelAddDesignation.Name = "panelAddDesignation";
            this.panelAddDesignation.Size = new System.Drawing.Size(922, 212);
            this.panelAddDesignation.TabIndex = 36;
            // 
            // bttnRemoveDesignation
            // 
            this.bttnRemoveDesignation.Location = new System.Drawing.Point(328, 38);
            this.bttnRemoveDesignation.Name = "bttnRemoveDesignation";
            this.bttnRemoveDesignation.Size = new System.Drawing.Size(75, 23);
            this.bttnRemoveDesignation.TabIndex = 48;
            this.bttnRemoveDesignation.Text = "Remove";
            this.bttnRemoveDesignation.UseVisualStyleBackColor = true;
            this.bttnRemoveDesignation.Click += new System.EventHandler(this.bttnRemoveDesignation_Click);
            // 
            // bttnNewDesignation
            // 
            this.bttnNewDesignation.Location = new System.Drawing.Point(328, 12);
            this.bttnNewDesignation.Name = "bttnNewDesignation";
            this.bttnNewDesignation.Size = new System.Drawing.Size(75, 23);
            this.bttnNewDesignation.TabIndex = 47;
            this.bttnNewDesignation.Text = "Add";
            this.bttnNewDesignation.UseVisualStyleBackColor = true;
            this.bttnNewDesignation.Click += new System.EventHandler(this.bttnNewDesignation_Click);
            // 
            // tblDesignation
            // 
            this.tblDesignation.AllowUserToAddRows = false;
            this.tblDesignation.AllowUserToDeleteRows = false;
            this.tblDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDesignation.Location = new System.Drawing.Point(20, 52);
            this.tblDesignation.Name = "tblDesignation";
            this.tblDesignation.ReadOnly = true;
            this.tblDesignation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDesignation.Size = new System.Drawing.Size(286, 143);
            this.tblDesignation.TabIndex = 46;
            // 
            // txtboxNewDesignation
            // 
            this.txtboxNewDesignation.Location = new System.Drawing.Point(130, 12);
            this.txtboxNewDesignation.Name = "txtboxNewDesignation";
            this.txtboxNewDesignation.Size = new System.Drawing.Size(177, 20);
            this.txtboxNewDesignation.TabIndex = 45;
            // 
            // lblNewFaculty
            // 
            this.lblNewFaculty.AutoSize = true;
            this.lblNewFaculty.Location = new System.Drawing.Point(17, 15);
            this.lblNewFaculty.Name = "lblNewFaculty";
            this.lblNewFaculty.Size = new System.Drawing.Size(88, 13);
            this.lblNewFaculty.TabIndex = 44;
            this.lblNewFaculty.Text = "New Designation";
            // 
            // panelAddFaculty
            // 
            this.panelAddFaculty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddFaculty.Controls.Add(this.bttnRemoveDpt);
            this.panelAddFaculty.Controls.Add(this.bttnAddNewDpt);
            this.panelAddFaculty.Controls.Add(this.tblDepartment);
            this.panelAddFaculty.Controls.Add(this.txtboxNewDpt);
            this.panelAddFaculty.Controls.Add(this.label1);
            this.panelAddFaculty.Controls.Add(this.btnRemoveFaculty);
            this.panelAddFaculty.Controls.Add(this.btnAddNewFaculty);
            this.panelAddFaculty.Controls.Add(this.tblFaculty);
            this.panelAddFaculty.Controls.Add(this.txtboxNewFaculty);
            this.panelAddFaculty.Controls.Add(this.label2);
            this.panelAddFaculty.Location = new System.Drawing.Point(31, 96);
            this.panelAddFaculty.Name = "panelAddFaculty";
            this.panelAddFaculty.Size = new System.Drawing.Size(922, 212);
            this.panelAddFaculty.TabIndex = 37;
            // 
            // bttnRemoveDpt
            // 
            this.bttnRemoveDpt.Location = new System.Drawing.Point(827, 39);
            this.bttnRemoveDpt.Name = "bttnRemoveDpt";
            this.bttnRemoveDpt.Size = new System.Drawing.Size(75, 23);
            this.bttnRemoveDpt.TabIndex = 53;
            this.bttnRemoveDpt.Text = "Remove";
            this.bttnRemoveDpt.UseVisualStyleBackColor = true;
            this.bttnRemoveDpt.Click += new System.EventHandler(this.bttnRemoveDpt_Click);
            // 
            // bttnAddNewDpt
            // 
            this.bttnAddNewDpt.Location = new System.Drawing.Point(827, 13);
            this.bttnAddNewDpt.Name = "bttnAddNewDpt";
            this.bttnAddNewDpt.Size = new System.Drawing.Size(75, 23);
            this.bttnAddNewDpt.TabIndex = 52;
            this.bttnAddNewDpt.Text = "Add";
            this.bttnAddNewDpt.UseVisualStyleBackColor = true;
            this.bttnAddNewDpt.Click += new System.EventHandler(this.bttnAddNewDpt_Click);
            // 
            // tblDepartment
            // 
            this.tblDepartment.AllowUserToAddRows = false;
            this.tblDepartment.AllowUserToDeleteRows = false;
            this.tblDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDepartment.Location = new System.Drawing.Point(518, 53);
            this.tblDepartment.Name = "tblDepartment";
            this.tblDepartment.ReadOnly = true;
            this.tblDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDepartment.Size = new System.Drawing.Size(286, 142);
            this.tblDepartment.TabIndex = 51;
            // 
            // txtboxNewDpt
            // 
            this.txtboxNewDpt.Location = new System.Drawing.Point(628, 13);
            this.txtboxNewDpt.Name = "txtboxNewDpt";
            this.txtboxNewDpt.Size = new System.Drawing.Size(177, 20);
            this.txtboxNewDpt.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "New Department";
            // 
            // btnRemoveFaculty
            // 
            this.btnRemoveFaculty.Location = new System.Drawing.Point(328, 38);
            this.btnRemoveFaculty.Name = "btnRemoveFaculty";
            this.btnRemoveFaculty.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFaculty.TabIndex = 48;
            this.btnRemoveFaculty.Text = "Remove";
            this.btnRemoveFaculty.UseVisualStyleBackColor = true;
            this.btnRemoveFaculty.Click += new System.EventHandler(this.btnRemoveFaculty_Click);
            // 
            // btnAddNewFaculty
            // 
            this.btnAddNewFaculty.Location = new System.Drawing.Point(328, 12);
            this.btnAddNewFaculty.Name = "btnAddNewFaculty";
            this.btnAddNewFaculty.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewFaculty.TabIndex = 47;
            this.btnAddNewFaculty.Text = "Add";
            this.btnAddNewFaculty.UseVisualStyleBackColor = true;
            this.btnAddNewFaculty.Click += new System.EventHandler(this.btnAddNewFaculty_Click);
            // 
            // tblFaculty
            // 
            this.tblFaculty.AllowUserToAddRows = false;
            this.tblFaculty.AllowUserToDeleteRows = false;
            this.tblFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFaculty.Location = new System.Drawing.Point(20, 52);
            this.tblFaculty.Name = "tblFaculty";
            this.tblFaculty.ReadOnly = true;
            this.tblFaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFaculty.Size = new System.Drawing.Size(286, 143);
            this.tblFaculty.TabIndex = 46;
            this.tblFaculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblFaculty_CellClick);
            // 
            // txtboxNewFaculty
            // 
            this.txtboxNewFaculty.Location = new System.Drawing.Point(130, 12);
            this.txtboxNewFaculty.Name = "txtboxNewFaculty";
            this.txtboxNewFaculty.Size = new System.Drawing.Size(177, 20);
            this.txtboxNewFaculty.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "New Faculty";
            // 
            // lblEditField
            // 
            this.lblEditField.AutoSize = true;
            this.lblEditField.Location = new System.Drawing.Point(28, 46);
            this.lblEditField.Name = "lblEditField";
            this.lblEditField.Size = new System.Drawing.Size(29, 13);
            this.lblEditField.TabIndex = 34;
            this.lblEditField.Text = "Field";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(879, 366);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(110, 23);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // Leave
            // 
            this.Leave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Leave.Controls.Add(this.btnRemoveLeave);
            this.Leave.Controls.Add(this.btnAddLeave);
            this.Leave.Controls.Add(this.tblLeave);
            this.Leave.Controls.Add(this.txtLeave);
            this.Leave.Controls.Add(this.label5);
            this.Leave.Location = new System.Drawing.Point(31, 96);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(922, 212);
            this.Leave.TabIndex = 39;
            // 
            // btnRemoveLeave
            // 
            this.btnRemoveLeave.Location = new System.Drawing.Point(328, 38);
            this.btnRemoveLeave.Name = "btnRemoveLeave";
            this.btnRemoveLeave.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveLeave.TabIndex = 48;
            this.btnRemoveLeave.Text = "Remove";
            this.btnRemoveLeave.UseVisualStyleBackColor = true;
            this.btnRemoveLeave.Click += new System.EventHandler(this.btnRemoveLeave_Click);
            // 
            // btnAddLeave
            // 
            this.btnAddLeave.Location = new System.Drawing.Point(328, 12);
            this.btnAddLeave.Name = "btnAddLeave";
            this.btnAddLeave.Size = new System.Drawing.Size(75, 23);
            this.btnAddLeave.TabIndex = 47;
            this.btnAddLeave.Text = "Add";
            this.btnAddLeave.UseVisualStyleBackColor = true;
            this.btnAddLeave.Click += new System.EventHandler(this.btnAddLeave_Click);
            // 
            // tblLeave
            // 
            this.tblLeave.AllowUserToAddRows = false;
            this.tblLeave.AllowUserToDeleteRows = false;
            this.tblLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLeave.Location = new System.Drawing.Point(20, 52);
            this.tblLeave.Name = "tblLeave";
            this.tblLeave.ReadOnly = true;
            this.tblLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblLeave.Size = new System.Drawing.Size(286, 143);
            this.tblLeave.TabIndex = 46;
            // 
            // txtLeave
            // 
            this.txtLeave.Location = new System.Drawing.Point(130, 12);
            this.txtLeave.Name = "txtLeave";
            this.txtLeave.Size = new System.Drawing.Size(177, 20);
            this.txtLeave.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Leave Category";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 401);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.groupBox1);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelChangeSalaryCode.ResumeLayout(false);
            this.panelChangeSalaryCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOldScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOldCode)).EndInit();
            this.panelAddDesignation.ResumeLayout(false);
            this.panelAddDesignation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDesignation)).EndInit();
            this.panelAddFaculty.ResumeLayout(false);
            this.panelAddFaculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaculty)).EndInit();
            this.Leave.ResumeLayout(false);
            this.Leave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLeave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBxEditField;
        private System.Windows.Forms.Label lblEditField;
        private System.Windows.Forms.Panel panelAddDesignation;
        private System.Windows.Forms.Button bttnRemoveDesignation;
        private System.Windows.Forms.Button bttnNewDesignation;
        private System.Windows.Forms.DataGridView tblDesignation;
        private System.Windows.Forms.TextBox txtboxNewDesignation;
        private System.Windows.Forms.Label lblNewFaculty;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panelAddFaculty;
        private System.Windows.Forms.Button bttnRemoveDpt;
        private System.Windows.Forms.Button bttnAddNewDpt;
        private System.Windows.Forms.DataGridView tblDepartment;
        private System.Windows.Forms.TextBox txtboxNewDpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveFaculty;
        private System.Windows.Forms.Button btnAddNewFaculty;
        private System.Windows.Forms.DataGridView tblFaculty;
        private System.Windows.Forms.TextBox txtboxNewFaculty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelChangeSalaryCode;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnRemoveSalaryScale;
        private System.Windows.Forms.Button btnAddSalarySalaryScale;
        private System.Windows.Forms.Button btnRemoveSalaaryCode;
        private System.Windows.Forms.Button btnAddSalaryCode;
        private System.Windows.Forms.DataGridView tblOldScale;
        private System.Windows.Forms.TextBox txtboxNewSalaryScale;
        private System.Windows.Forms.DataGridView tblOldCode;
        private System.Windows.Forms.TextBox txtboxNewSalaryCode;
        private System.Windows.Forms.Label lblNewSalaryCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalarySteps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStepAmount;
        private System.Windows.Forms.Panel Leave;
        private System.Windows.Forms.Button btnRemoveLeave;
        private System.Windows.Forms.Button btnAddLeave;
        private System.Windows.Forms.DataGridView tblLeave;
        private System.Windows.Forms.TextBox txtLeave;
        private System.Windows.Forms.Label label5;
    }
}