using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace StaffRegistration
{
    class AddStaff
    {
        
        Connection conn = new Connection();
        private String primaryKey = null;
        private bool unique = false;
       

        public void saveAcademicStaff(String title, String txtFullName, String txtInitials, String dateDob, String gender, String txtTelePrivate, String txtTeleOffice, String txtEmailPrivate, String txtEmailOffice,
            String txtNIC, String txtPassport, String cmbBxDesignation, String cmbBxFaculty, String cmbBxDepartment, String txtUPF, String dateAppointment, String dateRetirement, String txtMarriageCertificate, String txtServiceNo,
            String personalPicLoc, String marriageCertificateLoc, String cmbBxSalaryStep, String dateIncrement, String cmbBxSalaryScale, String healthInsurance, String ETFno, String salaryStepAmount, String highestQualification)
        {
           // try
            {

                MessageBox.Show("0");

                byte[] marriageImg = null;
                byte[] personalImg = null;

                if (personalPicLoc != null)
                {

                    FileStream personalFs = new FileStream(personalPicLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader personalBr = new BinaryReader(personalFs);
                    personalImg = personalBr.ReadBytes((int)personalFs.Length);
                }

                if (marriageCertificateLoc != null)
                {

                    FileStream marriageFs = new FileStream(marriageCertificateLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader marriageBr = new BinaryReader(marriageFs);
                    marriageImg = marriageBr.ReadBytes((int)marriageFs.Length);
                }

                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();
                if (marriageImg == null && personalImg != null)
                {
                    MessageBox.Show("1");
                    cmd = new MySqlCommand("INSERT INTO `academicstaff`(`NIC`, `Title`, `Full Name`, `Name with Initials`, `DOB`, `Gender`, `Private Contact No`, `Office Contact No`, `Private Email`, `Office Email`, `Passport No`, `UPF No`, `Appointment Date`, `Retirement Date`, `Marriage Certificate No`, `Person Pic`, `Type`, `ServiceNo`, `Department Name`, `Designation`, `Salary Step`, `Increment Date`, `Salary Scale`, `Health Insurance`, `ETF no`, `Salary Step Amount`,`Highest Qualification`) values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@17,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27,@28);", conn.connConnection());
                    cmd.Parameters.AddWithValue("@17", personalImg);


                }
                else if (personalImg == null && marriageImg != null)
                {
                    MessageBox.Show("2");
                    cmd = new MySqlCommand("INSERT INTO `academicstaff`(`NIC`, `Title`, `Full Name`, `Name with Initials`, `DOB`, `Gender`, `Private Contact No`, `Office Contact No`, `Private Email`, `Office Email`, `Passport No`, `UPF No`, `Appointment Date`, `Retirement Date`, `Marriage Certificate No`, `Marriage Certificate Pic`, `Type`, `ServiceNo`, `Department Name`, `Designation`, `Salary Step`, `Increment Date`, `Salary Scale`, `Health Insurance`, `ETF no`, `Salary Step Amount`,`Highest Qualification`) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27,@28);", conn.connConnection());
                    cmd.Parameters.AddWithValue("@16", marriageImg);


                }
                else if (marriageImg == null && personalImg == null)
                {
                    MessageBox.Show("3");
                    cmd = new MySqlCommand("INSERT INTO `academicstaff`(`NIC`, `Title`, `Full Name`, `Name with Initials`, `DOB`, `Gender`, `Private Contact No`, `Office Contact No`, `Private Email`, `Office Email`, `Passport No`, `UPF No`, `Appointment Date`, `Retirement Date`, `Marriage Certificate No`,  `Type`, `ServiceNo`, `Department Name`, `Designation`, `Salary Step`, `Increment Date`, `Salary Scale`, `Health Insurance`, `ETF no`, `Salary Step Amount`,`Highest Qualification`) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27,@28);", conn.connConnection());



                }
                else
                {
                    MessageBox.Show("4");
                    cmd = new MySqlCommand("INSERT INTO `academicstaff` VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24,@25,@26,@27,@28);", conn.connConnection());
                    cmd.Parameters.AddWithValue("@16", marriageImg);
                    cmd.Parameters.AddWithValue("@17", personalImg);
                    



                }
                cmd.Parameters.AddWithValue("@1", txtNIC);
                cmd.Parameters.AddWithValue("@2", title);
                cmd.Parameters.AddWithValue("@3", txtFullName);
                cmd.Parameters.AddWithValue("@4", txtInitials);
                cmd.Parameters.AddWithValue("@5", dateDob);
                cmd.Parameters.AddWithValue("@6", gender);
                cmd.Parameters.AddWithValue("@7", txtTelePrivate);
                cmd.Parameters.AddWithValue("@8", txtTeleOffice);
                cmd.Parameters.AddWithValue("@9", txtEmailPrivate);
                cmd.Parameters.AddWithValue("@10", txtEmailOffice);
                
                cmd.Parameters.AddWithValue("@11", txtPassport);
                cmd.Parameters.AddWithValue("@12", txtUPF);
                cmd.Parameters.AddWithValue("@13", dateAppointment);
                cmd.Parameters.AddWithValue("@14", dateRetirement);
                cmd.Parameters.AddWithValue("@15", txtMarriageCertificate);


                cmd.Parameters.AddWithValue("@18", "Permanent");
                cmd.Parameters.AddWithValue("@19", txtServiceNo);
                cmd.Parameters.AddWithValue("@20", cmbBxDepartment);
                cmd.Parameters.AddWithValue("@21", cmbBxDesignation);
                cmd.Parameters.AddWithValue("@22", cmbBxSalaryStep);
                cmd.Parameters.AddWithValue("@23", dateIncrement);
                cmd.Parameters.AddWithValue("@24", cmbBxSalaryScale);
                cmd.Parameters.AddWithValue("@25", healthInsurance);
                cmd.Parameters.AddWithValue("@26", ETFno);
                cmd.Parameters.AddWithValue("@27", salaryStepAmount);
                //if (highestQualification == "")
                   // highestQualification = "None";
                cmd.Parameters.AddWithValue("@28", highestQualification);
                cmd.ExecuteNonQuery();
                unique = false;

              //  cmd = new MySqlCommand("SELECT ASID FROM AcademicStaff where [NIC No] = @1; ", conn.connConnection());
              //  cmd.Parameters.AddWithValue("@1", txtNIC);

             //   MySqlDataReader read = cmd.ExecuteReader();

             //   while (read.Read())
                {
               //     primaryKey = read[0].ToString();

                }
             //   read.Close();


                conn.closeConnection();
                cmd.Dispose();

                primaryKey = txtNIC;

            }
          //  catch (Exception ex)
            {
             //   MessageBox.Show(ex.Message);
            }
        }

        public void addChildrenDetail(DataGridView tblChildren)
        {
            try
            {
                int childrenCount = tblChildren.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                for (int i = 0; i < childrenCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new MySqlCommand("INSERT INTO `childrendetail` VALUES(@1, @2, @3,@4)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", primaryKey);
                    cmd.Parameters.AddWithValue("@2", tblChildren.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblChildren.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblChildren.Rows[i].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addQulifications(DataGridView tblEducation)
        {
            try
            {

                int educationCount = tblEducation.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                for (int i = 0; i < educationCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new MySqlCommand("INSERT INTO `educationalqulifications` VALUES(@1, @2, @3,@4,@5)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", primaryKey);
                    cmd.Parameters.AddWithValue("@2", tblEducation.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblEducation.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblEducation.Rows[i].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@5", tblEducation.Rows[i].Cells[3].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addOtherPositions(DataGridView tblOtherPositions)
        {
            try
            {

                int otherPositionsCount = tblOtherPositions.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                for (int i = 0; i < otherPositionsCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new MySqlCommand("INSERT INTO `otherpositions` VALUES(@1, @2, @3,@4)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", primaryKey);
                    cmd.Parameters.AddWithValue("@2", tblOtherPositions.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblOtherPositions.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblOtherPositions.Rows[i].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addServiceRecords(DataGridView tblService)
        {
            try
            {
                int serviceCount = tblService.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                for (int i = 0; i < serviceCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new MySqlCommand("INSERT INTO `servicerecords` VALUES(@1, @2, @3,@4)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", primaryKey);
                    cmd.Parameters.AddWithValue("@2", tblService.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblService.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblService.Rows[i].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addLeave(DataGridView tblLeave)
        {
            try
            {
                int leaveCount = tblLeave.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                for (int i = 0; i < leaveCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new MySqlCommand("INSERT INTO `leave` VALUES(@1, @2, @3,@4,@5)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", primaryKey);
                    cmd.Parameters.AddWithValue("@2", tblLeave.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblLeave.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblLeave.Rows[i].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@5", tblLeave.Rows[i].Cells[3].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addAddress(String txtAddress1Mail, String txtCityMail, String txtMailZipCode, String txtAddress1Home, String txtCityHome, String txtHomeZipCode)
        {
            conn.connOpen();
            conn.connConnection();
            MySqlCommand cmd = conn.connConnection().CreateCommand();
            cmd = new MySqlCommand("INSERT INTO `address` VALUES (@1,@2,@3,@4,@5,@6,@7);", conn.connConnection());


            cmd.Parameters.AddWithValue("@1", primaryKey);
            cmd.Parameters.AddWithValue("@2", txtAddress1Mail);
            cmd.Parameters.AddWithValue("@3", txtCityMail);
            cmd.Parameters.AddWithValue("@4", txtMailZipCode);
            cmd.Parameters.AddWithValue("@5", txtAddress1Home);
            cmd.Parameters.AddWithValue("@6", txtCityHome);
            cmd.Parameters.AddWithValue("@7", txtHomeZipCode);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
        }


        public void facultyComboBox(ComboBox cmbBxFaculty)
        {
            try
            {
                cmbBxFaculty.Items.Clear();
                cmbBxFaculty.Items.Add("");
                string selectSQL = "SELECT `Faculty Name` FROM `Faculty`;";

                conn.connOpen();
                conn.connConnection();

                MySqlCommand comm = new MySqlCommand(selectSQL, conn.connConnection());
                MySqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxFaculty.Items.Add(reader["Faculty Name"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void departmentComboBox(ComboBox cmbBxDepartment)
        {
            try
            {
                cmbBxDepartment.Items.Clear();
                cmbBxDepartment.Items.Add("");
                string selectSQL = "SELECT `Department Name` FROM `department`;";

                conn.connOpen();
                conn.connConnection();

                MySqlCommand comm = new MySqlCommand(selectSQL, conn.connConnection());
                MySqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxDepartment.Items.Add(reader["Department Name"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void designationComboBox(ComboBox cmbBxDesignation)
        {
            try
            {
                cmbBxDesignation.Items.Clear();
                string selectSQL = "SELECT `Designation` FROM `designations`;";

                conn.connOpen();
                conn.connConnection();

                MySqlCommand comm = new MySqlCommand(selectSQL, conn.connConnection());
                MySqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {

                    cmbBxDesignation.Items.Add(reader["Designation"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salaryCodeComboBox(ComboBox cmbBxSalaryCode)
        {
            try
            {
                cmbBxSalaryCode.Items.Clear();
                string selectSQL = "SELECT `Salary Code` FROM `salarycode`;";

                conn.connOpen();
                conn.connConnection();

                MySqlCommand comm = new MySqlCommand(selectSQL, conn.connConnection());
                MySqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxSalaryCode.Items.Add(reader["Salary Code"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salaryScaleComboBox(ComboBox cmbBxSalaryScale)
        {
            try
            {
                cmbBxSalaryScale.Items.Clear();
                string selectSQL = "SELECT `Salary Scale` FROM `salaryscale`;";

                conn.connOpen();
                conn.connConnection();

                MySqlCommand comm = new MySqlCommand(selectSQL, conn.connConnection());
                MySqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxSalaryScale.Items.Add(reader["Salary Scale"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void salaryStepComboBox(ComboBox cmbBxSalaryStep, String salaryScale, String salaryCode)
        {
            try
            {
                cmbBxSalaryStep.Items.Clear();
                string selectSQL = "SELECT `Salary Steps` FROM `salaryscale` WHERE `Salary Scale` = @1 AND `Salary Code` = @2";

                conn.connOpen();
                conn.connConnection();

                MySqlCommand comm = new MySqlCommand(selectSQL, conn.connConnection());
                MySqlDataReader reader;

                comm.Parameters.AddWithValue("@1", salaryScale);
                comm.Parameters.AddWithValue("@2", salaryCode);
                int count = 1;
                //MessageBox.Show("test");

                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    int salaryStep = int.Parse(reader["Salary Steps"].ToString());
                    while (count <= salaryStep)
                    {
                        cmbBxSalaryStep.Items.Add(count);
                        count++;
                    }                    

                    //MessageBox.Show(salaryStep.ToString());
                    //cmbBxSalaryStep.Items.Add(reader["Salary Step"]);


                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadLeaveCombo(ComboBox cmbBxLeave)
        {
            try
            {
                cmbBxLeave.Items.Clear();
                string selectSQL = "SELECT * FROM `leavetype`;";

                conn.connOpen();
                conn.connConnection();

                MySqlCommand comm = new MySqlCommand(selectSQL, conn.connConnection());
                MySqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxLeave.Items.Add(reader["Leave Type"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void selectFaculty(ComboBox cmbBxFaculty, String department)
        {
            try
            {
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT `Faculty Name` FROM `Department` where `Department Name` = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", department);

                conn.connOpen();
                conn.connConnection();

                MySqlDataReader reader;
                string a = null;


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    a = reader.GetValue(0).ToString();
                    cmbBxFaculty.SelectedItem = a;
                }

                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void selectDepartment(ComboBox cmbBxDepartment, String faculty)
        {
            try
            {
                cmbBxDepartment.Items.Clear();
                cmbBxDepartment.Items.Add("");
                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT `Department Name` FROM `Department` where `Faculty Name` = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", faculty);

                conn.connOpen();
                conn.connConnection();


                MySqlDataReader reader1;


                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {

                    cmbBxDepartment.Items.Add(reader1["Department Name"]);
                }
                reader1.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void selectSalaryCode(ComboBox cmbBxSalaryCode, String salaryScale)
        {
            try
            {
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT  `SalaryScale`.`Salary Scale`,`Salary Code` FROM `SalaryScale` WHERE `Salary Scale` =  @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryScale);

                conn.connOpen();
                conn.connConnection();

                MySqlDataReader reader;
                string a = null;
                string b = null;


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbBxSalaryCode.Items.Add(reader["Salary Code"]);
                    a = reader.GetValue(0).ToString();
                    b = reader.GetValue(1).ToString();
                    //cmbBxSalaryScale.SelectedItem = a;
                    cmbBxSalaryCode.SelectedItem = b;
                    
                }

                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void calculateSalaryStep(String code,String scale, String step, ref TextBox amount)
        {
            try
            {
                //cmbBxSalaryStep.Items.Clear();
                double total = 0.0;
                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT `Step Amount` FROM `salaryscale` WHERE `Salary Scale` = @1 AND `Salary Code` = @2", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", scale);
                cmd.Parameters.AddWithValue("@2", code);

                conn.connOpen();
                conn.connConnection();


                MySqlDataReader reader1;


                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    total = double.Parse(step) * double.Parse(reader1["Step Amount"].ToString());
                    amount.Text = total.ToString();
                    //cmbBxSalaryStep.Items.Add(reader1["Salary Step"]);
                }
                reader1.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void selectSalaryScale(ComboBox cmbBxSalaryScale, String code)
        {
            try
            {
                cmbBxSalaryScale.Items.Clear();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT `Salary Scale` FROM `SalaryScale` where `Salary Code` = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", code);

                conn.connOpen();
                conn.connConnection();


                MySqlDataReader reader1;


                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {

                    cmbBxSalaryScale.Items.Add(reader1["Salary Scale"]);
                }
                reader1.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void checkAddStaffPanel1(RadioButton rdoBtnMr, RadioButton rdoBtnMrs, RadioButton rdoBtnMiss, TextBox txtFullName, TextBox txtInitials, RadioButton rdoBtnMale, RadioButton rdoBtnFemale, TextBox txtTelePrivate, TextBox txtTeleOffice, MaskedTextBox txtNIC, TextBox txtNicUpdate, ref Button btnNextPanel2)
        {
            if (txtNicUpdate.Text.Length > 0)
            {
                btnNextPanel2.Enabled = true;
            }
            else if ((rdoBtnMr.Checked || rdoBtnMrs.Checked || rdoBtnMiss.Checked) && txtFullName.Text.Length > 0 && txtInitials.Text.Length > 0 && (rdoBtnMale.Checked || rdoBtnFemale.Checked) && (txtTelePrivate.Text.Length > 0 || txtTeleOffice.Text.Length > 0) && unique == true && (txtNIC.MaskCompleted == true  && !String.IsNullOrEmpty(txtNIC.Text) ))
            {
                btnNextPanel2.Enabled = true;
            }
            else
            {
                btnNextPanel2.Enabled = false;
            }
        }

        public void checkAddStaffPanel2(RadioButton rdoBtnYes, RadioButton rdoBtnNo, ComboBox cmbBxDesignation, ComboBox cmbBxFaculty, ComboBox cmbBxDepartment, TextBox txtUPF, TextBox txtServiceNo, ComboBox cmbBxSalaryCode, ComboBox cmbBxSalaryScale, ComboBox cmbBxSalaryStep, TextBox txtSalaryStep, TextBox txtETF, ref Button btnNextPanel3)
        {
            if ((rdoBtnYes.Checked || rdoBtnNo.Checked) && cmbBxDesignation.Text.Length>0  && cmbBxFaculty.Text.Length > 0 && cmbBxDepartment.Text.Length > 0 && txtUPF.Text.Length > 0 && txtServiceNo.Text.Length > 0 && cmbBxSalaryCode.Text.Length > 0 && cmbBxSalaryScale.Text.Length > 0 && cmbBxSalaryStep.Text.Length > 0  && txtSalaryStep.Text.Length > 0 && txtETF.Text.Length > 0 )
            {
                btnNextPanel3.Enabled = true;
            }
            else
            {
                btnNextPanel3.Enabled = false;
            }
        }

        public void checkNIC(MaskedTextBox txtNIC)
        {
            try
            {
   
                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT `NIC` FROM `academicstaff` WHERE `NIC` = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNIC.Text);

                conn.connOpen();
                conn.connConnection();


                MySqlDataReader reader1;


                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    MessageBox.Show("NIC no already exits");
                    txtNIC.Text = "";
                }
                else
                {
                    unique = true;
                }
                reader1.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*  public void clearAll(ref String title, ref String gender, ref RadioButton Mr, ref RadioButton Mrs, ref RadioButton Miss, ref TextBox txtFullName, ref TextBox txtInitials, ref DateTimePicker dateDob, ref RadioButton male, ref RadioButton female, ref TextBox txtTelePrivate, ref TextBox txtTeleOffice, ref TextBox txtEmailPrivate, ref TextBox txtEmailOffice,
              ref MaskedTextBox txtNIC, ref TextBox txtPassport, ref ComboBox cmbBxDesignation, ref ComboBox cmbBxFaculty, ref ComboBox cmbBxDepartment, ref TextBox txtUPF, ref DateTimePicker dateAppointment, ref DateTimePicker dateRetirement, ref TextBox txtMarriageCertificate, ref TextBox txtServiceNo,
              ref String personalPicLoc, ref String marriageCertificateLoc, ref ComboBox cmbBxSalaryCode, ref ComboBox cmbBxScale, ref ComboBox cmbBxSalaryStep, ref DateTimePicker dateIncrement, ref TextBox txtAddress1Mail, ref TextBox txtCityMail, ref TextBox txtMailZipCode, ref TextBox txtAddress1Home, ref TextBox txtCityHome, ref TextBox txtHomeZipCode,
              DataGridView tblChildren, DataGridView tblEducation, DataGridView tblOtherPositions, DataGridView tblService, ref PictureBox ptBxPersonalPic, ref PictureBox ptBxMarriageCertificate, ref CheckBox chkBxSame)
          {
              tblChildren.DataSource = null;
              tblEducation.DataSource = null;
              tblService.DataSource = null;
              tblOtherPositions.DataSource = null;

              if (tblChildren.Rows.Count != 0)
                  tblChildren.Rows.Clear();
              if (tblEducation.Rows.Count != 0)
                  tblEducation.Rows.Clear();
              if (tblService.Rows.Count != 0)
                  tblService.Rows.Clear();
              if (tblOtherPositions.Rows.Count != 0)
                  tblOtherPositions.Rows.Clear();

              title = null;
              Miss.Checked = false;
              Mr.Checked = false;
              Mrs.Checked = false;

              txtFullName.Text = "";
              txtInitials.Text = "";
              dateDob.Value = DateTime.Now;

              gender = null;
              male.Checked = false;
              female.Checked = false;

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
              dateIncrement.Value = DateTime.Now;

              chkBxSame.Checked = false;
              txtAddress1Mail.Text = "";
              txtCityMail.Text = "";
              txtMailZipCode.Text = "";
              txtAddress1Home.Text = "";
              txtCityHome.Text = "";
              txtHomeZipCode.Text = "";


          }*/

    }
}
