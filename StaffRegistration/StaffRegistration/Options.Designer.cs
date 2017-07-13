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
            this.lblEditField = new System.Windows.Forms.Label();
            this.panelAddFaculty = new System.Windows.Forms.Panel();
            this.bttnRemoveFaculty = new System.Windows.Forms.Button();
            this.bttnAddNewFaculty = new System.Windows.Forms.Button();
            this.tblFaculty = new System.Windows.Forms.DataGridView();
            this.txtboxNewFaculty = new System.Windows.Forms.TextBox();
            this.lblNewFaculty = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAddDesignation = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelAddFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaculty)).BeginInit();
            this.panelAddDesignation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBxEditField);
            this.groupBox1.Controls.Add(this.panelAddFaculty);
            this.groupBox1.Controls.Add(this.panelAddDesignation);
            this.groupBox1.Controls.Add(this.lblEditField);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Fields";
            // 
            // cmbBxEditField
            // 
            this.cmbBxEditField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxEditField.FormattingEnabled = true;
            this.cmbBxEditField.Items.AddRange(new object[] {
            "<Select an option>",
            "Faculty & Department",
            "Designation",
            "Salary"});
            this.cmbBxEditField.Location = new System.Drawing.Point(81, 43);
            this.cmbBxEditField.Name = "cmbBxEditField";
            this.cmbBxEditField.Size = new System.Drawing.Size(266, 21);
            this.cmbBxEditField.TabIndex = 35;
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
            // panelAddFaculty
            // 
            this.panelAddFaculty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddFaculty.Controls.Add(this.bttnRemoveFaculty);
            this.panelAddFaculty.Controls.Add(this.bttnAddNewFaculty);
            this.panelAddFaculty.Controls.Add(this.tblFaculty);
            this.panelAddFaculty.Controls.Add(this.txtboxNewFaculty);
            this.panelAddFaculty.Controls.Add(this.lblNewFaculty);
            this.panelAddFaculty.Location = new System.Drawing.Point(31, 96);
            this.panelAddFaculty.Name = "panelAddFaculty";
            this.panelAddFaculty.Size = new System.Drawing.Size(922, 212);
            this.panelAddFaculty.TabIndex = 36;
            // 
            // bttnRemoveFaculty
            // 
            this.bttnRemoveFaculty.Location = new System.Drawing.Point(328, 38);
            this.bttnRemoveFaculty.Name = "bttnRemoveFaculty";
            this.bttnRemoveFaculty.Size = new System.Drawing.Size(75, 23);
            this.bttnRemoveFaculty.TabIndex = 48;
            this.bttnRemoveFaculty.Text = "Remove";
            this.bttnRemoveFaculty.UseVisualStyleBackColor = true;
            // 
            // bttnAddNewFaculty
            // 
            this.bttnAddNewFaculty.Location = new System.Drawing.Point(328, 12);
            this.bttnAddNewFaculty.Name = "bttnAddNewFaculty";
            this.bttnAddNewFaculty.Size = new System.Drawing.Size(75, 23);
            this.bttnAddNewFaculty.TabIndex = 47;
            this.bttnAddNewFaculty.Text = "Add";
            this.bttnAddNewFaculty.UseVisualStyleBackColor = true;
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
            // 
            // txtboxNewFaculty
            // 
            this.txtboxNewFaculty.Location = new System.Drawing.Point(130, 12);
            this.txtboxNewFaculty.Name = "txtboxNewFaculty";
            this.txtboxNewFaculty.Size = new System.Drawing.Size(177, 20);
            this.txtboxNewFaculty.TabIndex = 45;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(879, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelAddDesignation
            // 
            this.panelAddDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddDesignation.Controls.Add(this.button2);
            this.panelAddDesignation.Controls.Add(this.button3);
            this.panelAddDesignation.Controls.Add(this.dataGridView1);
            this.panelAddDesignation.Controls.Add(this.textBox1);
            this.panelAddDesignation.Controls.Add(this.label1);
            this.panelAddDesignation.Controls.Add(this.button4);
            this.panelAddDesignation.Controls.Add(this.button5);
            this.panelAddDesignation.Controls.Add(this.dataGridView2);
            this.panelAddDesignation.Controls.Add(this.textBox2);
            this.panelAddDesignation.Controls.Add(this.label2);
            this.panelAddDesignation.Location = new System.Drawing.Point(31, 96);
            this.panelAddDesignation.Name = "panelAddDesignation";
            this.panelAddDesignation.Size = new System.Drawing.Size(922, 212);
            this.panelAddDesignation.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(827, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(827, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 52;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(286, 142);
            this.dataGridView1.TabIndex = 51;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(628, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 50;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 48;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(328, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 47;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(286, 143);
            this.dataGridView2.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 45;
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
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Options";
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAddFaculty.ResumeLayout(false);
            this.panelAddFaculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaculty)).EndInit();
            this.panelAddDesignation.ResumeLayout(false);
            this.panelAddDesignation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBxEditField;
        private System.Windows.Forms.Label lblEditField;
        private System.Windows.Forms.Panel panelAddFaculty;
        private System.Windows.Forms.Button bttnRemoveFaculty;
        private System.Windows.Forms.Button bttnAddNewFaculty;
        private System.Windows.Forms.DataGridView tblFaculty;
        private System.Windows.Forms.TextBox txtboxNewFaculty;
        private System.Windows.Forms.Label lblNewFaculty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAddDesignation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}