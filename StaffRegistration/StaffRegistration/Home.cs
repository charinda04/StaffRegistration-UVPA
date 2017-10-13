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
    public partial class StaffRegistration : Form
    {
        SearchStaff staff = new SearchStaff();
        AddStaff add = new AddStaff();
        DeleteStaff dstaff = new DeleteStaff();
        Alerts a1 = new Alerts();

        Connection cc = new Connection();
        private bool updateStatus = false;


        public StaffRegistration()
        {
            InitializeComponent();

        }

        public void reoad()
        {
            StaffRegistration s = new StaffRegistration();
            s.StartPosition = FormStartPosition.WindowsDefaultBounds;
            //s.Left = 250;
            //s.Top = 130;

            s.MdiParent = this.MdiParent;
            s.Show();
            this.Close();
        }

        private void addStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }

        private void tStpBtnAdd_Click(object sender, EventArgs e)
        {
            Add addStaff = new Add(updateStatus,"",this,tblSearch,tblAlerts,lblIndicator);
            addStaff.ShowDialog();
        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            staff.fillSearchTable(tblSearch);
            add.facultyComboBox(cmbBxSearchFaculty);
            a1.tblAlertsIncrement(tblAlerts);
            a1.checkNoofAlerts(lblIndicator,tblAlerts);
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tStpBtnAdd.PerformClick();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            panelAlerts.Visible = true;
            panelAlerts.BringToFront();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelSearch.BringToFront();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            staff.fillSearchTable(tblSearch);
            a1.tblAlertsIncrement(tblAlerts);
            a1.checkNoofAlerts(lblIndicator, tblAlerts);
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            staff.searchByName(txtSearchName.Text, tblSearch,cmbBxSearchFaculty.Text,cmbBxSearchDepartment.Text);
        }

        private void txtSearchNIC_TextChanged(object sender, EventArgs e)
        {
            staff.searchByNIC(txtSearchNIC.Text, tblSearch, cmbBxSearchFaculty.Text, cmbBxSearchDepartment.Text);
        }

        private void txtSearchUPF_TextChanged(object sender, EventArgs e)
        {
            staff.searchByUPF(txtSearchUPF.Text, tblSearch, cmbBxSearchFaculty.Text, cmbBxSearchDepartment.Text);
        }

        private void txtPassportNo_TextChanged(object sender, EventArgs e)
        {
            staff.searchByPassport(txtPassportNo.Text, tblSearch, cmbBxSearchFaculty.Text, cmbBxSearchDepartment.Text);
        }

        private void cmbBxSearchDepartment_DropDownClosed(object sender, EventArgs e)
        {
            staff.searchByName(txtSearchName.Text, tblSearch, cmbBxSearchFaculty.Text, cmbBxSearchDepartment.Text);
        }

        private void cmbBxSearchFaculty_DropDownClosed(object sender, EventArgs e)
        {
            add.selectDepartment(cmbBxSearchDepartment, cmbBxSearchFaculty.Text);
            staff.searchByName(txtSearchName.Text, tblSearch, cmbBxSearchFaculty.Text, cmbBxSearchDepartment.Text);
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (tblSearch.SelectedRows.Count == 1)
            {
                updateStatus = true;
                String ID = tblSearch[0, tblSearch.CurrentRow.Index].Value.ToString();
                Add addStaff = new Add(updateStatus,ID,this, tblSearch,tblAlerts, lblIndicator);
                addStaff.ShowDialog();
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
                dstaff.deleteAcademicStaff(tblSearch[0, tblSearch.CurrentRow.Index].Value.ToString());
            staff.fillSearchTable(tblSearch);
        }

        private void btnAlertView_Click(object sender, EventArgs e)
        {
            if (tblAlerts.SelectedRows.Count == 1)
            {
                updateStatus = true;
                String ID = tblAlerts[0, tblAlerts.CurrentRow.Index].Value.ToString();
                Add addStaff = new Add(updateStatus, ID, this, tblSearch, tblAlerts, lblIndicator);
                addStaff.ShowDialog();
            }
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tStpBtnReport.PerformClick();
        }

        private void editOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tStpBtnOptions.PerformClick();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            this.Dispose();
            l1.ShowDialog();
            
        }
    }
}
