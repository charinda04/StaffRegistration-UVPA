using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffRegistration
{
    public partial class Options : Form
    {
        OptionPanel opt = new OptionPanel();
        public Options()
        {
            InitializeComponent();
        }

        private void cmbBxEditField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxEditField.SelectedIndex == 0)
            {
                panelAddDesignation.Visible = false;
                panelChangeSalaryCode.Visible = false;
                panelAddFaculty.Visible = true;
                panelAddFaculty.BringToFront();
            }
            else if (cmbBxEditField.SelectedIndex == 1)
            {
                panelChangeSalaryCode.Visible = false;
                panelAddFaculty.Visible = false;
                panelAddDesignation.Visible = true;
                panelAddDesignation.BringToFront();
            }
            else if (cmbBxEditField.SelectedIndex == 2)
            {
                panelChangeSalaryCode.Visible = true;
                panelChangeSalaryCode.BringToFront();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewFaculty_Click(object sender, EventArgs e)
        {
            if (txtboxNewFaculty.Text == "")
                MessageBox.Show("Faculty name cannot be empty");
            else
            {
                opt.insertFaculty(txtboxNewFaculty.Text);
                txtboxNewFaculty.Text = "";
                opt.loadFaculty(tblFaculty);
            }
        }

        private void btnRemoveFaculty_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want delete this faculty?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                opt.deleteFaculty(tblFaculty[0, tblFaculty.CurrentRow.Index].Value.ToString());
            }
            opt.loadFaculty(tblFaculty);
            opt.loadDepartment(tblDepartment, tblFaculty[0, tblFaculty.CurrentRow.Index].Value.ToString());
        }

        private void tblFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            opt.loadDepartment(tblDepartment, tblFaculty[0, tblFaculty.CurrentRow.Index].Value.ToString());
        }

        private void bttnAddNewDpt_Click(object sender, EventArgs e)
        {
            if (txtboxNewDpt.Text == "")
                MessageBox.Show("Department name cannot be empty");
            else
            {
                opt.insertDepartment(txtboxNewDpt.Text, tblFaculty[0, tblFaculty.CurrentRow.Index].Value.ToString());
                txtboxNewDpt.Text = "";
                opt.loadDepartment(tblDepartment, tblFaculty[0, tblFaculty.CurrentRow.Index].Value.ToString());
            }
        }

        private void bttnRemoveDpt_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want delete this Department?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                opt.deleteDepartment(tblDepartment[0, tblDepartment.CurrentRow.Index].Value.ToString());
            }
            opt.loadDepartment(tblDepartment, tblFaculty[0, tblFaculty.CurrentRow.Index].Value.ToString());
        }

        private void Options_Load(object sender, EventArgs e)
        {
            cmbBxEditField.SelectedIndex = 0;
            opt.loadSalaryCode(tblOldCode);
            opt.loadSalaryScale(tblOldScale, tblOldCode[0, tblOldCode.CurrentRow.Index].Value.ToString());
            //if (tblOldScalePopulated == false)
             //   opt.loadSalaryStep(tblOldStep, "");
           // else
            //    opt.loadSalaryStep(tblOldStep, tblOldScale[0, tblOldScale.CurrentRow.Index].Value.ToString());

            opt.loadFaculty(tblFaculty);
            if (tblFaculty.RowCount>0)
                opt.loadDepartment(tblDepartment, tblFaculty[0, tblFaculty.CurrentRow.Index].Value.ToString());

            opt.loadDesignation(tblDesignation);
        }

        private void bttnNewDesignation_Click(object sender, EventArgs e)
        {
            if (txtboxNewDesignation.Text == "")
                MessageBox.Show("Designation name cannot be empty");
            else
            {
                opt.insertDesignation(txtboxNewDesignation.Text);
                txtboxNewDesignation.Text = "";
                opt.loadDesignation(tblDesignation);
            }
        }

        private void bttnRemoveDesignation_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want delete this Designation?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                opt.deleteDesignation(tblDesignation[0, tblDesignation.CurrentRow.Index].Value.ToString());
            }
            opt.loadDesignation(tblDesignation);
        }

        private void btnAddSalaryCode_Click(object sender, EventArgs e)
        {
            if (txtboxNewSalaryCode.Text == "")
                MessageBox.Show("SalaryCode cannot be empty");
            else
            {
                opt.insertSalaryCode(txtboxNewSalaryCode.Text);
                txtboxNewSalaryCode.Text = "";
                opt.loadSalaryCode(tblOldCode);
            }
        }

        private void btnRemoveSalaaryCode_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want delete this SalaaryCode?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                opt.deleteSalaryCode(tblOldCode[0, tblOldCode.CurrentRow.Index].Value.ToString());
            }
            opt.loadSalaryCode(tblOldCode);
            opt.loadSalaryScale(tblOldScale, tblOldCode[0, tblOldCode.CurrentRow.Index].Value.ToString());
            
        }

        private void tblOldCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            opt.loadSalaryScale(tblOldScale, tblOldCode[0, tblOldCode.CurrentRow.Index].Value.ToString());
            
        }

        private void btnAddSalarySalaryScale_Click(object sender, EventArgs e)
        {
            if (txtboxNewSalaryScale.Text == "" || txtSalarySteps.Text == "")
                MessageBox.Show("Salary Scale and Salary Steps cannot be empty");
            else
            {
                opt.insertSalaryScale(txtboxNewSalaryScale.Text, tblOldCode[0, tblOldCode.CurrentRow.Index].Value.ToString(),txtSalarySteps.Text,txtStepAmount.Text);
                txtboxNewSalaryScale.Text = "";
                txtSalarySteps.Text = "";
                txtStepAmount.Text = "";
                opt.loadSalaryScale(tblOldScale, tblOldCode[0, tblOldCode.CurrentRow.Index].Value.ToString());
            }
        }

        private void btnRemoveSalaryScale_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want delete this SalaryScale?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                opt.deleteSalaryScale(tblOldScale[0, tblOldScale.CurrentRow.Index].Value.ToString());
            }
            opt.loadSalaryScale(tblOldScale, tblOldCode[0, tblOldCode.CurrentRow.Index].Value.ToString());
            
        }
    }
}
