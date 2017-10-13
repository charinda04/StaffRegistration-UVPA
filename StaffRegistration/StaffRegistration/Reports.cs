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
    public partial class Reports : Form
    {

        CustomReport report = new CustomReport();
        public Reports()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

            // report.populateTreeView(ref trVwFaculty, ref trVwDesignation, ref trVwDepartment);
            report.populateCheckListBox(ref chkLtBxDesignation, ref chkLtBxFaculty, ref chkLtBxDepartment, ref chkLtBxLeaveCategory, ref chkLtBxSalaryCode, ref chkLtBxSalaryScale);


        }

        private void trVwAddress_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void trVwPersonal_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    report.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }

        private void btnGeneate_Click(object sender, EventArgs e)
        {
            if (chkLtBxPersonal.CheckedItems.Count == 0 && chkLtBxFamily.CheckedItems.Count == 0 && chkLtBxEducation.CheckedItems.Count == 0 &&
                 chkLtBxServiceRecord.CheckedItems.Count == 0 && chkLtBxOtherPositions.CheckedItems.Count == 0 && chkLtBxSalaryCode.CheckedItems.Count == 0 && 
                 chkLtBxSalaryScale.CheckedItems.Count == 0 && chkLtBxFaculty.CheckedItems.Count == 0 && chkLtBxAddress.CheckedItems.Count == 0 &&
                 chkLtBxLeave.CheckedItems.Count == 0 && chkLtBxLeaveCategory.CheckedItems.Count == 0 && chkLtBxDepartment.CheckedItems.Count == 0 && chkLtBxDesignation.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select relavent fields first");
            }
            else
            {
                report.loadReportTable(chkLtBxPersonal, chkLtBxFamily, chkLtBxEducation, chkLtBxServiceRecord, chkLtBxOtherPositions, tblReport, chkLtBxAddress, chkLtBxFaculty, chkLtBxSalaryScale, chkLtBxSalaryCode,chkLtBxDesignation,chkLtBxLeave,chkLtBxDepartment,chkLtBxLeaveCategory);

                report_view.Visible = true;
                report_view.BringToFront();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void chkBxPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxPersonal.Checked)
            {
                for (int i = 0; i < chkLtBxPersonal.Items.Count; i++)
                {
                    chkLtBxPersonal.SetItemChecked(i, true);
                }
            }
            else if (!chkBxPersonal.Checked)
            {
                for (int i = 0; i < chkLtBxPersonal.Items.Count; i++)
                {
                    chkLtBxPersonal.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxFamily_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxFamily.Checked)
            {
                for (int i = 0; i < chkLtBxFamily.Items.Count; i++)
                {
                    chkLtBxFamily.SetItemChecked(i, true);
                }
            }
            else if (!chkBxFamily.Checked)
            {
                for (int i = 0; i < chkLtBxFamily.Items.Count; i++)
                {
                    chkLtBxFamily.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxEducation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxEducation.Checked)
            {
                for (int i = 0; i < chkLtBxEducation.Items.Count; i++)
                {
                    chkLtBxEducation.SetItemChecked(i, true);
                }
            }
            else if (!chkBxEducation.Checked)
            {
                for (int i = 0; i < chkLtBxEducation.Items.Count; i++)
                {
                    chkLtBxEducation.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxAddress.Checked)
            {
                for (int i = 0; i < chkLtBxAddress.Items.Count; i++)
                {
                    chkLtBxAddress.SetItemChecked(i, true);
                }
            }
            else if (!chkBxAddress.Checked)
            {
                for (int i = 0; i < chkLtBxAddress.Items.Count; i++)
                {
                    chkLtBxAddress.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxServiceRecord_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxServiceRecord.Checked)
            {
                for (int i = 0; i < chkLtBxServiceRecord.Items.Count; i++)
                {
                    chkLtBxServiceRecord.SetItemChecked(i, true);
                }
            }
            else if (!chkBxServiceRecord.Checked)
            {
                for (int i = 0; i < chkLtBxServiceRecord.Items.Count; i++)
                {
                    chkLtBxServiceRecord.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxOtherPositions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxOtherPositions.Checked)
            {
                for (int i = 0; i < chkLtBxOtherPositions.Items.Count; i++)
                {
                    chkLtBxOtherPositions.SetItemChecked(i, true);
                }
            }
            else if (!chkBxOtherPositions.Checked)
            {
                for (int i = 0; i < chkLtBxOtherPositions.Items.Count; i++)
                {
                    chkLtBxOtherPositions.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxLeave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxLeave.Checked)
            {
                for (int i = 0; i < chkLtBxLeave.Items.Count; i++)
                {
                    chkLtBxLeave.SetItemChecked(i, true);
                }
            }
            else if (!chkBxLeave.Checked)
            {
                for (int i = 0; i < chkLtBxLeave.Items.Count; i++)
                {
                    chkLtBxLeave.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxFaculty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxFaculty.Checked)
            {
                for (int i = 0; i < chkLtBxFaculty.Items.Count; i++)
                {
                    chkLtBxFaculty.SetItemChecked(i, true);
                }
            }
            else if (!chkBxFaculty.Checked)
            {
                for (int i = 0; i < chkLtBxFaculty.Items.Count; i++)
                {
                    chkLtBxFaculty.SetItemChecked(i, false);
                }
            }
        }

        private void chkLtBxDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkBxDesignation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxDesignation.Checked)
            {
                for (int i = 0; i < chkLtBxDesignation.Items.Count; i++)
                {
                    chkLtBxDesignation.SetItemChecked(i, true);
                }
            }
            else if (!chkBxDesignation.Checked)
            {
                for (int i = 0; i < chkLtBxDesignation.Items.Count; i++)
                {
                    chkLtBxDesignation.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxDepartment.Checked)
            {
                for (int i = 0; i < chkLtBxDepartment.Items.Count; i++)
                {
                    chkLtBxDepartment.SetItemChecked(i, true);
                }
            }
            else if (!chkBxDepartment.Checked)
            {
                for (int i = 0; i < chkLtBxDepartment.Items.Count; i++)
                {
                    chkLtBxDepartment.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxSalaryScale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxSalaryScale.Checked)
            {
                for (int i = 0; i < chkLtBxSalaryScale.Items.Count; i++)
                {
                    chkLtBxSalaryScale.SetItemChecked(i, true);
                }
            }
            else if (!chkBxSalaryScale.Checked)
            {
                for (int i = 0; i < chkLtBxSalaryScale.Items.Count; i++)
                {
                    chkLtBxSalaryScale.SetItemChecked(i, false);
                }
            }
        }

        private void chkBxSalaryCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxSalaryCode.Checked)
            {
                for (int i = 0; i < chkLtBxSalaryCode.Items.Count; i++)
                {
                    chkLtBxSalaryCode.SetItemChecked(i, true);
                }
            }
            else if (!chkBxSalaryCode.Checked)
            {
                for (int i = 0; i < chkLtBxSalaryCode.Items.Count; i++)
                {
                    chkLtBxSalaryCode.SetItemChecked(i, false);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBxLeaveCatergory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxLeaveCatergory.Checked)
            {
                for (int i = 0; i < chkLtBxLeaveCategory.Items.Count; i++)
                {
                    chkLtBxLeaveCategory.SetItemChecked(i, true);
                }
            }
            else if (!chkBxLeaveCatergory.Checked)
            {
                for (int i = 0; i < chkLtBxLeaveCategory.Items.Count; i++)
                {
                    chkLtBxLeaveCategory.SetItemChecked(i, false);
                }
            }
        }

        private void btnPrintPdf_Click(object sender, EventArgs e)
        {
            report.dataGridPdf(tblReport, txtHeader.Text, dateReport.Text);
        }

        private void btnShowExcel_Click(object sender, EventArgs e)
        {
            report.ExportToExcel(tblReport, txtHeader.Text, dateReport.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
