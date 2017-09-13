using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffRegistration;

namespace StaffRegistration
{
    public partial class Add : Form
    {

        String personalPicLoc = null;
        String marriageCertificateLoc = null;
        Boolean PersonalPic = false;
        Boolean certificatePic = false;
        Boolean updateStatus = false;
        String nic = null;
        Boolean facultyFirst = true;
        Boolean tblOldScalePopulated = false;
        String title = null, gender = null;
        String healthInsurance = null;

        //public bool updateStatus = false;

        AddStaff add = new AddStaff();
        UpdateStaff upstaff = new UpdateStaff();

        

        public Add(bool updateStatus, String nic, Form home )
        {

            InitializeComponent();

            this.updateStatus = updateStatus;
            this.nic = nic;
           // h1 = home;
            
        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void tblChildren_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPersonalD2.Visible = true;
            panelPersonalD2.BringToFront();
        }

        private void btnNextPanel2_Click(object sender, EventArgs e)
        {
            panelPersonalD2.Visible = true;
            panelPersonalD2.BringToFront();
        }

        private void btnNextPanel3_Click(object sender, EventArgs e)
        {
            panelEduQual.Visible = true;
            panelEduQual.BringToFront();
        }

        private void btnPreviousPannel2_Click(object sender, EventArgs e)
        {
            panelPersonalD1.Visible = true;
            panelPersonalD1.BringToFront();
        }

        private void btnPreviousPannel1_Click(object sender, EventArgs e)
        {
            panelPersonalD1.Visible = true;
            panelPersonalD1.BringToFront();
        }

        private void btnNextPanel4_Click(object sender, EventArgs e)
        {
            panelOther.Visible = true;
            panelOther.BringToFront();
        }

        private void btnPreviousPanel2_Click(object sender, EventArgs e)
        {
            panelPersonalD2.Visible = true;
            panelPersonalD2.BringToFront();
        }

        private void btnPreviousPanel3_Click(object sender, EventArgs e)
        {
            panelEduQual.Visible = true;
            panelEduQual.BringToFront();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelPanel2_Click(object sender, EventArgs e)
        {
            bttnCancel.PerformClick();
                
        }

        private void btnCancelPanel4_Click(object sender, EventArgs e)
        {
            bttnCancel.PerformClick();
        }

        private void btnCancelPanel3_Click(object sender, EventArgs e)
        {
            bttnCancel.PerformClick();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            dateEffective.CustomFormat = "yyyy-MM-dd";
            dateDob.CustomFormat = "yyyy-MM-dd";
            dateAppointment.CustomFormat = "yyyy-MM-dd";
            dateRetirement.CustomFormat = "yyyy-MM-dd";
            dateIncrement.CustomFormat = "yyyy-MM-dd";
            dateChildDob.CustomFormat = "yyyy-MM-dd";
            dateOtherPositionFrom.CustomFormat = "yyyy-MM-dd";
            dateOtherPosistionTo.CustomFormat = "yyyy-MM-dd";
            dateServiceFrom.CustomFormat = "yyyy-MM-dd";
            dateServiceTo.CustomFormat = "yyyy-MM-dd";
            dateLeaveFrom.CustomFormat = "yyyy-MM-dd";
            dateLeaveTo.CustomFormat = "yyyy-MM-dd";
            //dateReport.CustomFormat = "yyyy-MM-dd";
            //dateReport.Value = DateTime.Now;

            //add.departmentComboBox(cmbBxDepartment);
            add.facultyComboBox(cmbBxFaculty);
            add.salaryCodeComboBox(cmbBxSalaryCode);
            //add.salaryScaleComboBox(cmbBxScale);
           // add.salaryStepComboBox(cmbBxSalaryStep);
            add.designationComboBox(cmbBxDesignation);
            add.designationComboBox(txtServicePosition);
            add.loadLeaveCombo(cmbBxLeaveCategory);

            if (updateStatus == true)
            {
                btnNextPanel2.Enabled = true;
                btnNextPanel3.Enabled = true;
                //txtNIC.Mask.Remove(10);
                txtNIC.Visible = false;
                txtNicUpdate.Visible = true;
                // txtNIC.ReadOnly = true;
                upstaff.fillForm(nic, ref rdoBtnMr, ref rdoBtnMrs, ref rdoBtnMiss, ref txtFullName, ref txtInitials, ref dateDob, ref rdoBtnMale, ref rdoBtnFemale, ref txtTelePrivate, ref txtTeleOffice, ref txtEmailPrivate, ref txtEmailOffice, ref txtNicUpdate, ref txtPassport,
                    ref cmbBxDesignation, ref cmbBxFaculty, ref cmbBxDepartment, ref txtUPF, ref dateAppointment, ref dateRetirement,ref rdoBtnYes,ref rdoBtnNo, ref txtMarriageCertificate, ref txtServiceNo, ref ptBxPersonalPic, ref ptBxMarriageCertificate, ref cmbBxSalaryStep, ref cmbBxScale, ref cmbBxSalaryCode, ref dateIncrement,
                    ref txtSalaryStep,ref txtETF,ref txtHighestQualification,ref txtAddress1Mail, ref txtCityMail, ref txtMailZipCode, ref txtAddress1Home, ref txtCityHome, ref txtHomeZipCode);
                upstaff.fillChildrentable(nic, tblChildren);
                upstaff.fillEducationTable(nic, tblEducation);
                upstaff.fillOtherPositionsTable(nic, tblOtherPositions);
                upstaff.fillServiceRecords(nic, tblService);
                upstaff.fillLeave(nic, tblLeave);
            }
        }

        private void chkBxSame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxSame.Checked)
            {
                txtAddress1Home.Enabled = false;

                txtCityHome.Enabled = false;
                txtHomeZipCode.Enabled = false;
                txtAddress1Home.Text = txtAddress1Mail.Text;

                txtCityHome.Text = txtCityMail.Text;
                txtHomeZipCode.Text = txtMailZipCode.Text;
            }
            else if (!chkBxSame.Checked)
            {
                txtAddress1Home.Enabled = true;

                txtCityHome.Enabled = true;
                txtHomeZipCode.Enabled = true;
                txtAddress1Home.Text = "";

                txtCityHome.Text = "";
                txtHomeZipCode.Text = "";
            }
        }

        private void btnAddChildren_Click(object sender, EventArgs e)
        {
            if (txtChildName.Text.Length == 0 || txtChildBirthCertificate.Text.Length == 0)
            {
                MessageBox.Show("Fill all the fields first");
            }
            else if (updateStatus == true)
            {
                upstaff.updateChildrenTable(nic, txtChildName.Text, dateChildDob.Text, txtChildBirthCertificate.Text);
                upstaff.fillChildrentable(nic, tblChildren);
            }
            else
            {
                tblChildren.Rows.Add(txtChildName.Text, dateChildDob.Text, txtChildBirthCertificate.Text);
                txtChildName.Text = "";
                txtChildBirthCertificate.Text = "";
                dateChildDob.Value = DateTime.Now;
                //MessageBox.Show(tblChildren.Rows.Count.ToString());
            }
        }

        private void btnRemoveChildren_Click(object sender, EventArgs e)
        {
            if (tblChildren.Rows.Count == 0)
            {
                MessageBox.Show("The table is empty. No record has been selected");
            }
            else if (updateStatus == true)
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    upstaff.deleteFromChildrenTable(nic, tblChildren[6, tblChildren.CurrentRow.Index].Value.ToString());
                upstaff.fillChildrentable(nic, tblChildren);
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    tblChildren.Rows.Remove(tblChildren.Rows[tblChildren.SelectedCells[0].RowIndex]);
            }
        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (txtQulification.Text.Length == 0 || txtUniversity.Text.Length == 0 || txtGrade.Text.Length == 0)
            {
                MessageBox.Show("Fill all the fields first");
            }
            else if (updateStatus == true)
            {
                upstaff.updateEducationTable(nic, txtQulification.Text, txtUniversity.Text, dateEffective.Text, txtGrade.Text);
                upstaff.fillEducationTable(nic, tblEducation);
            }
            else
            {
                tblEducation.Rows.Add(txtQulification.Text, txtUniversity.Text, dateEffective.Text, txtGrade.Text);
                txtQulification.Text = "";
                txtUniversity.Text = "";
                dateEffective.Value = DateTime.Now;
                txtGrade.Text = "";
            }
        }

        private void btnRemoveEducation_Click(object sender, EventArgs e)
        {
            if (tblEducation.Rows.Count == 0)
            {
                MessageBox.Show("The table is empty. No record has been selected");
            }
            else if (updateStatus == true)
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    upstaff.deleteFromEducationTable(nic, tblEducation[5, tblEducation.CurrentRow.Index].Value.ToString());
                upstaff.fillEducationTable(nic, tblEducation);
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    tblEducation.Rows.Remove(tblEducation.Rows[tblEducation.SelectedCells[0].RowIndex]);
            }
        }

        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            if (txtServicePosition.Text.Length == 0)
            {
                MessageBox.Show("Fill all the fields first");
            }
            else if (updateStatus == true)
            {
                upstaff.updateServiceRecords(nic, txtServicePosition.Text, dateServiceFrom.Text, dateServiceTo.Text);
                upstaff.fillServiceRecords(nic, tblService);
            }
            else
            {
                tblService.Rows.Add(txtServicePosition.Text, dateServiceFrom.Text, dateServiceTo.Text);
                txtServicePosition.Text = "";
                dateServiceFrom.Value = DateTime.Now;
                dateServiceTo.Value = DateTime.Now;
            }
        }

        private void btnServiceRemove_Click(object sender, EventArgs e)
        {
            if (tblService.Rows.Count == 0)
            {
                MessageBox.Show("The table is empty. No record has been selected");
            }
            else if (updateStatus == true)
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    upstaff.deleteFromServiceRecords(nic, tblService[4, tblService.CurrentRow.Index].Value.ToString());
                upstaff.fillServiceRecords(nic, tblService);
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    tblService.Rows.Remove(tblService.Rows[tblService.SelectedCells[0].RowIndex]);
            }
        }

        private void btnAddOtherPosition_Click(object sender, EventArgs e)
        {
            if (txtOtherPosition.Text.Length == 0)
            {
                MessageBox.Show("Fill all the fields first");
            }
            else if (updateStatus == true)
            {
                upstaff.updateOtherpositionsTable(nic, txtOtherPosition.Text, dateOtherPositionFrom.Text, dateOtherPosistionTo.Text);
                upstaff.fillOtherPositionsTable(nic, tblOtherPositions);
            }
            else
            {
                tblOtherPositions.Rows.Add(txtOtherPosition.Text, dateOtherPositionFrom.Text, dateOtherPosistionTo.Text);
                txtOtherPosition.Text = "";
                dateOtherPositionFrom.Value = DateTime.Now;
                dateOtherPosistionTo.Value = DateTime.Now;
            }
        }

        private void btnRemoveOtherPosition_Click(object sender, EventArgs e)
        {
            if (tblOtherPositions.Rows.Count == 0)
            {
                MessageBox.Show("The table is empty. No record has been selected");
            }
            else if (updateStatus == true)
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    upstaff.deleteFromOtherpositionsTable(nic, tblOtherPositions[4, tblOtherPositions.CurrentRow.Index].Value.ToString());
                upstaff.fillOtherPositionsTable(nic, tblOtherPositions);
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    tblOtherPositions.Rows.Remove(tblOtherPositions.Rows[tblOtherPositions.SelectedCells[0].RowIndex]);
            }
        }

        private void btnAddLeave_Click(object sender, EventArgs e)
        {
            if (cmbBxLeaveCategory.Text.Length == 0 || cmbBxLeaveType.Text.Length == 0)
            {
                MessageBox.Show("Fill all the fields first");
            }
            else if (updateStatus == true)
            {
                upstaff.updateLeave(nic, cmbBxLeaveCategory.Text, cmbBxLeaveType.Text, dateLeaveFrom.Text, dateLeaveTo.Text);
                upstaff.fillLeave(nic, tblLeave);
            }
            else
            {
                tblLeave.Rows.Add(cmbBxLeaveCategory.Text, cmbBxLeaveType.Text, dateLeaveFrom.Text, dateLeaveTo.Text);
                cmbBxLeaveCategory.Text = "";
                cmbBxLeaveType.Text = "";
                dateLeaveFrom.Value = DateTime.Now;
                dateLeaveTo.Value = DateTime.Now;
            }
        }

        private void btnRemoveLeave_Click(object sender, EventArgs e)
        {
            if (tblLeave.Rows.Count == 0)
            {
                MessageBox.Show("The table is empty. No record has been selected");
            }
            else if (updateStatus == true)
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                   upstaff.deleteFromLeave(nic, tblLeave[5, tblLeave.CurrentRow.Index].Value.ToString());
                upstaff.fillLeave(nic, tblLeave);
            }
            else
            {
                DialogResult answer;
                answer = MessageBox.Show("Do you want to delete this record?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                    tblLeave.Rows.Remove(tblLeave.Rows[tblLeave.SelectedCells[0].RowIndex]);
            }
        }

        private void btnPersonalPic_Click(object sender, EventArgs e)
        {
            openFileDialogPersonalPic.FileName = "";
            if (openFileDialogPersonalPic.ShowDialog() == DialogResult.OK)
            {
                ptBxPersonalPic.Image = Image.FromFile(openFileDialogPersonalPic.FileName);
                personalPicLoc = openFileDialogPersonalPic.FileName.ToString();
            }
        }

        private void btnAddMarriageCertificate_Click(object sender, EventArgs e)
        {
            openFileDialogMarriageCertificate.FileName = "";
            if (openFileDialogMarriageCertificate.ShowDialog() == DialogResult.OK)
            {
                ptBxMarriageCertificate.Image = Image.FromFile(openFileDialogMarriageCertificate.FileName);
                marriageCertificateLoc = openFileDialogMarriageCertificate.FileName.ToString();
            }
        }

        private void cmbBxFaculty_DropDownClosed(object sender, EventArgs e)
        {
            add.selectDepartment(cmbBxDepartment, cmbBxFaculty.Text);
        }

        private void cmbBxDepartment_DropDownClosed(object sender, EventArgs e)
        {
            //add.selectFaculty(cmbBxFaculty, cmbBxDepartment.Text);
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr,rdoBtnMrs,rdoBtnMiss,txtFullName,txtInitials,rdoBtnMale,rdoBtnFemale,txtTelePrivate,txtTeleOffice,txtNIC, txtNicUpdate, ref btnNextPanel2);
        }

        private void txtInitials_TextChanged(object sender, EventArgs e)
        {
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr, rdoBtnMrs, rdoBtnMiss, txtFullName, txtInitials, rdoBtnMale, rdoBtnFemale, txtTelePrivate, txtTeleOffice, txtNIC, txtNicUpdate, ref btnNextPanel2);
        }

        private void rdoBtnMr_CheckedChanged(object sender, EventArgs e)
        {
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr, rdoBtnMrs, rdoBtnMiss, txtFullName, txtInitials, rdoBtnMale, rdoBtnFemale, txtTelePrivate, txtTeleOffice, txtNIC, txtNicUpdate, ref btnNextPanel2);
        }

        private void rdoBtnMrs_CheckedChanged(object sender, EventArgs e)
        {
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr, rdoBtnMrs, rdoBtnMiss, txtFullName, txtInitials, rdoBtnMale, rdoBtnFemale, txtTelePrivate, txtTeleOffice, txtNIC,txtNicUpdate, ref btnNextPanel2);
        }

        private void rdoBtnMiss_CheckedChanged(object sender, EventArgs e)
        {
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr, rdoBtnMrs, rdoBtnMiss, txtFullName, txtInitials, rdoBtnMale, rdoBtnFemale, txtTelePrivate, txtTeleOffice, txtNIC, txtNicUpdate, ref btnNextPanel2);
        }

        private void rdoBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr, rdoBtnMrs, rdoBtnMiss, txtFullName, txtInitials, rdoBtnMale, rdoBtnFemale, txtTelePrivate, txtTeleOffice, txtNIC, txtNicUpdate, ref btnNextPanel2);
        }

        private void rdoBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr, rdoBtnMrs, rdoBtnMiss, txtFullName, txtInitials, rdoBtnMale, rdoBtnFemale, txtTelePrivate, txtTeleOffice, txtNIC, txtNicUpdate, ref btnNextPanel2);
        }

        private void txtNIC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtTelePrivate_TextChanged(object sender, EventArgs e)
        {
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr, rdoBtnMrs, rdoBtnMiss, txtFullName, txtInitials, rdoBtnMale, rdoBtnFemale, txtTelePrivate, txtTeleOffice, txtNIC, txtNicUpdate, ref btnNextPanel2);
        }

        private void txtTeleOffice_TextChanged(object sender, EventArgs e)
        {
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr, rdoBtnMrs, rdoBtnMiss, txtFullName, txtInitials, rdoBtnMale, rdoBtnFemale, txtTelePrivate, txtTeleOffice, txtNIC, txtNicUpdate, ref btnNextPanel2);
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            //bool nicUnique = false;
            if (txtNIC.MaskCompleted)
            {
                add.checkNIC(txtNIC);
            }
            if (updateStatus == false)
                add.checkAddStaffPanel1(rdoBtnMr, rdoBtnMrs, rdoBtnMiss, txtFullName, txtInitials, rdoBtnMale, rdoBtnFemale, txtTelePrivate, txtTeleOffice, txtNIC, txtNicUpdate, ref btnNextPanel2);
        }

        private void rdoBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            healthInsurance = "yes";
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
        }

        private void rdoBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            healthInsurance = "no";
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
        }

        private void txtServiceNo_TextChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep,txtSalaryStep,txtETF, ref btnNextPanel3);
        }

        private void cmbBxDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
        }

        private void cmbBxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
        }

        private void cmbBxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
        }

        private void txtUPF_TextChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
        }

        private void cmbBxSalaryCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
        }

        private void cmbBxScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
            add.salaryStepComboBox(cmbBxSalaryStep,cmbBxScale.Text,cmbBxSalaryCode.Text);
        }

        private void cmbBxSalaryStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
            add.calculateSalaryStep(cmbBxSalaryCode.Text,cmbBxScale.Text,cmbBxSalaryStep.Text, ref txtSalaryStep);
        }

        private void txtSalaryStep_TextChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
        }

        private void txtETF_TextChanged(object sender, EventArgs e)
        {
            add.checkAddStaffPanel2(rdoBtnYes, rdoBtnNo, cmbBxDesignation, cmbBxFaculty, cmbBxDepartment, txtUPF, txtServiceNo, cmbBxSalaryCode, cmbBxScale, cmbBxSalaryStep, txtSalaryStep, txtETF, ref btnNextPanel3);
        }

        private void cmbBxSalaryCode_DropDownClosed(object sender, EventArgs e)
        {
            add.selectSalaryScale(cmbBxScale,cmbBxSalaryCode.Text);
        }

        private void btnHighestQualification_Click(object sender, EventArgs e)
        {
            if(updateStatus==true)
                txtHighestQualification.Text = tblEducation[5, tblEducation.CurrentRow.Index].Value.ToString();
            else
                txtHighestQualification.Text = tblEducation[0,tblEducation.CurrentRow.Index].Value.ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String primaryKey = null;

                if (rdoBtnMr.Checked)
                    title = "Mr";
                else if (rdoBtnMrs.Checked)
                    title = "Mrs";
                else if (rdoBtnMiss.Checked)
                    title = "Miss";

                if (rdoBtnMale.Checked)
                    gender = "Male";
                else if (rdoBtnFemale.Checked)
                    gender = "Female";

                if (updateStatus == true)
                {
                    upstaff.updateAcademicStaff(nic, title, txtFullName.Text, txtInitials.Text, dateDob.Text, gender, txtTelePrivate.Text, txtTeleOffice.Text, txtEmailPrivate.Text,
                         txtEmailOffice.Text, txtNicUpdate.Text, txtPassport.Text, cmbBxDesignation.Text, cmbBxFaculty.Text, cmbBxDepartment.Text, txtUPF.Text, dateAppointment.Text,
                         dateRetirement.Text, txtMarriageCertificate.Text,
                         txtServiceNo.Text, personalPicLoc, marriageCertificateLoc, cmbBxSalaryStep.Text, dateIncrement.Text, cmbBxScale.Text, healthInsurance,txtETF.Text,txtSalaryStep.Text,txtHighestQualification.Text);
                    //upstaff.updateAddress(txtAddress1Mail.Text, txtCityMail.Text, txtMailZipCode.Text, txtAddress1Home.Text, txtCityHome.Text, txtHomeZipCode.Text);
                    //upstaff.updateChildrenDetail(ASID, tblChildren);
                    //upstaff.updateQulifications(ASID, tblEducation);
                    //upstaff.updateServiceRecords(ASID, tblService);
                    //upstaff.updateOtherPositions(ASID, tblOtherPositions);



                    MessageBox.Show("record updated");
                    updateStatus = false;
                    //staff.fillSearchTable(tblSearch);
                    //search.Visible = true;
                    //search.BringToFront();
                }
                else
                {
                    add.saveAcademicStaff(title, txtFullName.Text, txtInitials.Text, dateDob.Text, gender, txtTelePrivate.Text, txtTeleOffice.Text, txtEmailPrivate.Text,
                         txtEmailOffice.Text, txtNIC.Text, txtPassport.Text, cmbBxDesignation.Text, cmbBxFaculty.Text, cmbBxDepartment.Text, txtUPF.Text, dateAppointment.Text,
                         dateRetirement.Text, txtMarriageCertificate.Text,
                         txtServiceNo.Text, personalPicLoc, marriageCertificateLoc, cmbBxSalaryStep.Text, dateIncrement.Text,cmbBxScale.Text,healthInsurance,txtETF.Text,txtSalaryStep.Text,txtHighestQualification.Text);
                    add.addAddress(txtAddress1Mail.Text, txtCityMail.Text, txtMailZipCode.Text, txtAddress1Home.Text, txtCityHome.Text, txtHomeZipCode.Text);
                    add.addChildrenDetail(tblChildren);
                    add.addQulifications(tblEducation);
                    add.addServiceRecords(tblService);
                    add.addOtherPositions(tblOtherPositions);
                    add.addLeave(tblLeave);
                    MessageBox.Show("record saved");
                    
                    this.Close();
                   // staff.fillSearchTable(Form.);
                    //personal_detail1.Visible = true;
                    //personal_detail1.BringToFront();
                }


                /*

                if (tblChildren.Rows.Count != 0 )
                    tblChildren.Rows.Clear();
                if (tblEducation.Rows.Count != 0)
                    tblEducation.Rows.Clear();
                if (tblService.Rows.Count != 0)
                    tblService.Rows.Clear();
                if (tblOtherPositions.Rows.Count != 0)
                    tblOtherPositions.Rows.Clear();

                title = null;
                rdoBtnMiss.Checked = false;
                rdoBtnMr.Checked = false;
                rdoBtnMrs.Checked = false;

                txtFullName.Text = "";
                txtInitials.Text = "";
                dateDob.Value = DateTime.Now;

                gender = null;
                rdoBtnMale.Checked = false;
                rdoBtnFemale.Checked = false;

                txtTelePrivate.Text = "";
                txtTeleOffice.Text = "";
                txtEmailPrivate.Text = "";
                txtEmailOffice.Text = "";
                txtNIC.Text = "";
                txtPassport.Text = "";
                cmbBxDesignation.Text = "";
                cmbBxFaculty.Text = "";
                cmbBxDepartment.Text = "";
                txtUPF.Text = "";
                dateAppointment.Value = DateTime.Now;

                dateRetirement.Value = DateTime.Now; 
                txtMarriageCertificate.Text = "";

                txtServiceNo.Text = "";
                personalPicLoc = null;
                ptBxPersonalPic.Image = null;
                ptBxMarriageCertificate.Image = null;
                marriageCertificateLoc = null; 
                cmbBxSalaryStep.Text = "";
                cmbBxSalaryCode.Text = "";
                cmbBxScale.Text = "";
                dateIncrement.Value = DateTime.Now;*/

                /*add.clearAll(ref title, ref gender, ref rdoBtnMr, ref rdoBtnMrs, ref rdoBtnMiss, ref txtFullName, ref txtInitials, ref dateDob, ref rdoBtnMale, ref rdoBtnFemale, ref txtTelePrivate, ref txtTeleOffice, ref txtEmailPrivate, ref txtEmailOffice, ref txtNIC, ref txtPassport,
                    ref cmbBxDesignation, ref cmbBxFaculty, ref cmbBxDepartment, ref txtUPF, ref dateAppointment, ref dateRetirement, ref txtMarriageCertificate, ref txtServiceNo, ref personalPicLoc, ref marriageCertificateLoc, ref cmbBxSalaryCode, ref cmbBxScale, ref cmbBxSalaryStep, ref dateIncrement,
                    ref txtAddress1Mail, ref txtCityMail, ref txtMailZipCode, ref txtAddress1Home, ref txtCityHome, ref txtHomeZipCode, tblChildren, tblEducation, tblOtherPositions, tblService, ref ptBxPersonalPic, ref ptBxMarriageCertificate,
                    ref chkBxSame);
                */
                facultyFirst = true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //conn.Close();
            }
        }
    }
}
