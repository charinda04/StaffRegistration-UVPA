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

        public void saveAcademicStaff(String title, String txtFullName, String txtInitials, String dateDob, String gender, String txtTelePrivate, String txtTeleOffice, String txtEmailPrivate, String txtEmailOffice,
            String txtNIC, String txtPassport, String cmbBxDesignation, String cmbBxFaculty, String cmbBxDepartment, String txtUPF, String dateAppointment, String dateRetirement, String txtMarriageCertificate, String txtServiceNo,
            String personalPicLoc, String marriageCertificateLoc, String cmbBxSalaryStep, String dateIncrement)
        {
           // try
            {



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
                    cmd = new MySqlCommand("INSERT INTO `academicstaff`(`NIC`, `Title`, `Full Name`, `Name with Initials`, `DOB`, `Gender`, `Private Contact No`, `Office Contact No`, `Private Email`, `Office Email`, `Passport No`, `UPF No`, `Appointment Date`, `Retirement Date`, `Marriage Certificate No`, `Person Pic`, `Type`, `ServiceNo`, `Department Name`, `Designation`, `Salary Step`, `Increment Date`, `Salary Scale`) values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23);", conn.connConnection());
                    cmd.Parameters.AddWithValue("@17", personalImg);


                }
                else if (personalImg == null && marriageImg != null)
                {
                    cmd = new MySqlCommand("insert into AcademicStaff ([Title],[Full Name],[Name with Initials],[DOB] ,[Gender],[Private Contact No] ,[Office Contact No] ,[Private Email],[Office Email],[NIC No],[Passport No],[UPF No],[Appointment Date] ,[Retirement Date] ,[Marriage Certificate No] ,[Marriage Certificate Pic],[Type] ,[ServiceNo] ,[Department Name] ,[Designation],[Salary Step],[Increment Date]) values (@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@19,@20,@21,@22,@23,@24);", conn.connConnection());
                    cmd.Parameters.AddWithValue("@16", marriageImg);


                }
                else if (marriageImg == null && personalImg == null)
                {
                    cmd = new MySqlCommand("insert into AcademicStaff ([Title],[Full Name],[Name with Initials],[DOB],[Gender],[Private Contact No],[Office Contact No],[Private Email],[Office Email],[NIC No] ,[Passport No] ,[UPF No],[Appointment Date],[Retirement Date] ,[Marriage Certificate No] ,[Type],[ServiceNo] ,[Department Name],[Designation],[Salary Step],[Increment Date]) values (@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@19,@20,@21,@22,@23,@24);", conn.connConnection());



                }
                else
                {
                    cmd = new MySqlCommand("insert into AcademicStaff values (@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19,@20,@21,@22,@23,@24);", conn.connConnection());
                    cmd.Parameters.AddWithValue("@17", marriageImg);
                    cmd.Parameters.AddWithValue("@18", personalImg);



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

                cmd.ExecuteNonQuery();


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
                    cmd = new MySqlCommand("insert into ChildrenDetail values(@1, @2, @3,@4)", conn.connConnection());
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
                    cmd = new MySqlCommand("insert into EducationalQulifications values(@1, @2, @3,@4,@5)", conn.connConnection());
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
                    cmd = new MySqlCommand("insert into OtherPositions values(@1, @2, @3,@4)", conn.connConnection());
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
                    cmd = new MySqlCommand("insert into ServiceRecords values(@1, @2, @3,@4)", conn.connConnection());
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

        public void addAddress(String txtAddress1Mail, String txtCityMail, String txtMailZipCode, String txtAddress1Home, String txtCityHome, String txtHomeZipCode)
        {
            conn.connOpen();
            conn.connConnection();
            MySqlCommand cmd = conn.connConnection().CreateCommand();
            cmd = new MySqlCommand("insert into Address values (@1,@2,@3,@4,@5,@6,@7);", conn.connConnection());


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

        /*public void salaryStepComboBox(ComboBox cmbBxSalaryStep)
        {
            try
            {
                cmbBxSalaryStep.Items.Clear();
                string selectSQL = "SELECT [Salary Step] FROM [SalaryStep];";

                conn.connOpen();
                conn.connConnection();

                MySqlCommand comm = new MySqlCommand(selectSQL, conn.connConnection());
                MySqlDataReader reader;


                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //string faculty = reader.GetString("faculty");
                    cmbBxSalaryStep.Items.Add(reader["Salary Step"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

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

        public void selectSalaryCode(ComboBox cmbBxSalaryCode, ComboBox cmbBxSalaryScale, String salaryStep)
        {
            try
            {
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT  `SalaryScale`.`Salary Scale`,`Salary Code` FROM `SalaryScale`,`SalaryStep` WHERE `Salary Step` =  @1 AND  `SalaryStep`.`Salary Scale` =  `SalaryScale`.`Salary Scale`;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryStep);

                conn.connOpen();
                conn.connConnection();

                MySqlDataReader reader;
                string a = null;
                string b = null;


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    a = reader.GetValue(0).ToString();
                    b = reader.GetValue(1).ToString();
                    cmbBxSalaryScale.SelectedItem = a;
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

        public void selectSalaryStep(ComboBox cmbBxSalaryStep, String scale)
        {
            try
            {
                cmbBxSalaryStep.Items.Clear();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT `Salary Step` FROM `SalaryStep` where `Salary Scale` = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", scale);

                conn.connOpen();
                conn.connConnection();


                MySqlDataReader reader1;


                reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {

                    cmbBxSalaryStep.Items.Add(reader1["Salary Step"]);
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
