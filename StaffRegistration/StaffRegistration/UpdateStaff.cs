using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Data;

namespace StaffRegistration
{
    class UpdateStaff
    {
        
         
         
         Connection conn = new Connection();
        AddStaff a1 = new AddStaff();

        public void fillForm(String ASID,ref RadioButton Mr, ref RadioButton Mrs, ref RadioButton Miss,ref TextBox txtFullName,ref TextBox txtInitials,ref DateTimePicker dateDob,ref RadioButton male,ref RadioButton female,ref TextBox txtTelePrivate,ref TextBox txtTeleOffice, ref TextBox txtEmailPrivate,ref TextBox txtEmailOffice,
            ref TextBox txtNIC,ref TextBox txtPassport,ref  ComboBox cmbBxDesignation,ref ComboBox cmbBxFaculty, ref ComboBox cmbBxDepartment, ref TextBox txtUPF,ref  DateTimePicker dateAppointment,ref  DateTimePicker dateRetirement,ref RadioButton rdoBtnYes,ref RadioButton rdoBtnNo,ref TextBox txtMarriageCertificate, ref TextBox txtServiceNo,
            ref PictureBox personalPicLoc, ref PictureBox marriageCertificateLoc, ref ComboBox cmbBxSalaryStep,ref ComboBox cmbBxScale,ref ComboBox cmbBxSalaryCode, ref DateTimePicker dateIncrement,ref TextBox stepAmount,ref TextBox etfNo,ref TextBox highestQualification, ref TextBox txtAddress1Mail, ref TextBox txtCityMail, ref TextBox txtMailZipCode, ref TextBox txtAddress1Home,  ref TextBox txtCityHome, ref TextBox txtHomeZipCode)
        {
            try
            {
                
                string selectSQL = "SELECT * FROM `academicstaff` WHERE `NIC` = @1;";
                

                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = new MySqlCommand(selectSQL, conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                MySqlDataReader reader;


                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                   
                    Mr.Checked = reader["Title"].ToString() == "Mr";
                    Mrs.Checked = reader["Title"].ToString() == "Mrs";
                    Miss.Checked = reader["Title"].ToString() == "Miss";

                    txtFullName.Text = reader["Full Name"].ToString() ;
                    txtInitials.Text = reader["Name with Initials"].ToString();
                    dateDob.Text = reader["DOB"].ToString();

                    

                    male.Checked = reader["Gender"].ToString() == "Male";
                    female.Checked = reader["Gender"].ToString() == "Female";

                    txtTelePrivate.Text = reader["Private Contact No"].ToString();
                    txtTeleOffice.Text = reader["Office Contact No"].ToString();
                    txtEmailPrivate.Text = reader["Private Email"].ToString();
                    txtEmailOffice.Text = reader["Office Email"].ToString();
                    int txt = int.Parse(reader["NIC"].ToString().Remove(reader["NIC"].ToString().Length - 1));
                    
                    txtNIC.Text = txt.ToString();
                    //txtNIC.Text = "123456789";
                    txtPassport.Text = reader["Passport No"].ToString();
                    txtUPF.Text = reader["UPF No"].ToString();
                    dateAppointment.Text = reader["Appointment Date"].ToString();
                    dateRetirement.Text = reader["Retirement Date"].ToString();
                    txtMarriageCertificate.Text = reader["Marriage Certificate No"].ToString();
                    


                    if (DBNull.Value.Equals(reader["Person Pic"]))
                    {
                        personalPicLoc.Image = null;
                        
                    }

                    else
                    {
                        
                        byte[] img = (byte[])(reader["Person Pic"]);
                        //if (img == null)
                            //personalPicLoc.Image = null;
                        MemoryStream ms = new MemoryStream(img);
                        personalPicLoc.Image = Image.FromStream(ms);

                    }

                    if (DBNull.Value.Equals(reader["Marriage Certificate Pic"]))
                    {
                        marriageCertificateLoc.Image = null;

                    }

                    else
                    {

                        byte[] img = (byte[])reader["Marriage Certificate Pic"];
                        MemoryStream ms = new MemoryStream(img);
                        marriageCertificateLoc.Image = Image.FromStream(ms);

                    }
                    
                    // type
                    txtServiceNo.Text = reader["ServiceNo"].ToString();
                    //MessageBox.Show("test");
                    a1.departmentComboBox(cmbBxDepartment);
                    cmbBxDepartment.Text = reader["Department Name"].ToString();
                    a1.selectFaculty(cmbBxFaculty, reader["Department Name"].ToString());
                    cmbBxDesignation.Text = reader["Designation"].ToString();
                    rdoBtnYes.Checked = reader["Health Insurance"].ToString() == "yes";
                    rdoBtnNo.Checked = reader["Health Insurance"].ToString() == "no";

                    a1.salaryScaleComboBox(cmbBxScale);
                    cmbBxScale.Text = reader["Salary Scale"].ToString();
                    a1.selectSalaryCode(cmbBxSalaryCode, reader["Salary Scale"].ToString());
                    a1.salaryStepComboBox(cmbBxSalaryStep, reader["Salary Scale"].ToString(), cmbBxSalaryCode.Text);

                    cmbBxSalaryStep.Text = reader["Salary Step"].ToString();
                    
                    dateIncrement.Text = reader["Increment Date"].ToString();
                    stepAmount.Text = reader["Salary Step Amount"].ToString();
                    etfNo.Text = reader["ETF no"].ToString();

                    highestQualification.Text = reader["Highest Qualification"].ToString();

                    //


                }
                reader.Close();



                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();


                conn.closeConnection();
               

                cmd.Dispose();
                dataAdapter.Dispose();

                conn.connOpen();
                conn.connConnection();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `address` WHERE `NIC` = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtAddress1Mail.Text = reader["Maling Address"].ToString();
                    txtCityMail.Text = reader["Maling City"].ToString();
                    txtMailZipCode.Text = reader["Maling ZipCode"].ToString();
                    txtAddress1Home.Text = reader["Home Address"].ToString();
                    txtCityHome.Text = reader["Home City"].ToString();
                    txtHomeZipCode.Text = reader["Home ZipCode"].ToString();
                }
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillChildrentable(String ASID, DataGridView tblChildren)
        {
            conn.connOpen();
            conn.connConnection();
            MySqlCommand cmd = conn.connConnection().CreateCommand();
            cmd = conn.connConnection().CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM `childrendetail` WHERE `NIC` = @1; ", conn.connConnection());
            cmd.Parameters.AddWithValue("@1", ASID);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            dataAdapter = new MySqlDataAdapter(cmd);

            table = new DataTable();
            dataAdapter.Fill(table);
            
            tblChildren.DataSource = table;

            tblChildren.Columns[0].Visible = false;
            tblChildren.Columns[1].Visible = false;
            tblChildren.Columns[2].Visible = false;
            tblChildren.Columns[3].Visible = false;

            conn.closeConnection();

            cmd.Dispose();
            dataAdapter.Dispose();
        }

        public void fillEducationTable(String ASID, DataGridView tblEducation)
        {
            conn.connOpen();
            conn.connConnection();
            MySqlCommand cmd = conn.connConnection().CreateCommand();
            cmd = conn.connConnection().CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM `educationalqulifications` WHERE `NIC` = @1; ", conn.connConnection());
            cmd.Parameters.AddWithValue("@1", ASID);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            dataAdapter = new MySqlDataAdapter(cmd);

            table = new DataTable();
            dataAdapter.Fill(table);

            tblEducation.DataSource = table;
            tblEducation.Columns[0].Visible = false;
            tblEducation.Columns[1].Visible = false;
            tblEducation.Columns[2].Visible = false;
            tblEducation.Columns[3].Visible = false;
            tblEducation.Columns[4].Visible = false;
            conn.closeConnection();

            cmd.Dispose();
            dataAdapter.Dispose();
        }

        public void fillOtherPositionsTable(String ASID, DataGridView tblOtherPositions)
        {
            conn.connOpen();
            conn.connConnection();
            MySqlCommand cmd = conn.connConnection().CreateCommand();
            cmd = conn.connConnection().CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM `otherpositions` WHERE `NIC` = @1; ", conn.connConnection());
            cmd.Parameters.AddWithValue("@1", ASID);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            dataAdapter = new MySqlDataAdapter(cmd);

            table = new DataTable();
            dataAdapter.Fill(table);

            tblOtherPositions.DataSource = table;

            tblOtherPositions.Columns[0].Visible = false;
            tblOtherPositions.Columns[1].Visible = false;
            tblOtherPositions.Columns[2].Visible = false;
            tblOtherPositions.Columns[3].Visible = false;
            conn.closeConnection();

            cmd.Dispose();
            dataAdapter.Dispose();
        }

        public void fillServiceRecords(String ASID, DataGridView tblService)
        {
            conn.connOpen();
            conn.connConnection();
            MySqlCommand cmd = conn.connConnection().CreateCommand();
            cmd = conn.connConnection().CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM `servicerecords` WHERE `NIC` = @1; ", conn.connConnection());
            cmd.Parameters.AddWithValue("@1", ASID);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            tblService.DataSource = table;
            tblService.Columns[0].Visible = false;
            tblService.Columns[1].Visible = false;
            tblService.Columns[2].Visible = false;
            tblService.Columns[3].Visible = false;
            conn.closeConnection();

            cmd.Dispose();
            dataAdapter.Dispose();
        }
        public void fillLeave(String ASID, DataGridView tblLeave)
        {
            conn.connOpen();
            conn.connConnection();
            MySqlCommand cmd = conn.connConnection().CreateCommand();
            cmd = conn.connConnection().CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM `leave` WHERE `NIC` = @1; ", conn.connConnection());
            cmd.Parameters.AddWithValue("@1", ASID);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            tblLeave.DataSource = table;
            tblLeave.Columns[0].Visible = false;
            tblLeave.Columns[1].Visible = false;
            tblLeave.Columns[2].Visible = false;
            tblLeave.Columns[3].Visible = false;
            tblLeave.Columns[4].Visible = false;
            conn.closeConnection();

            cmd.Dispose();
            dataAdapter.Dispose();
        }

        public void updateChildrenTable(String ASID, String name,String dob , String certicicateNo)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();
        
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("insert into ChildrenDetail values(@1, @2, @3,@4)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", name);
                cmd.Parameters.AddWithValue("@3", dob);
                cmd.Parameters.AddWithValue("@4", certicicateNo);
                        
                cmd.ExecuteNonQuery();
                   
                conn.closeConnection();
                cmd.Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateEducationTable(String ASID,String qulification, String university, String date, String grade)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("insert into EducationalQulifications values(@1, @2, @3,@4,@5)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", qulification);
                cmd.Parameters.AddWithValue("@3", university);
                cmd.Parameters.AddWithValue("@4", date);
                cmd.Parameters.AddWithValue("@5", grade);

                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateOtherpositionsTable(String ASID, String position, String fromDate, String toDate)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("insert into OtherPositions values(@1, @2, @3,@4)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", position);
                cmd.Parameters.AddWithValue("@3", fromDate);
                cmd.Parameters.AddWithValue("@4", toDate);

                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateServiceRecords(String ASID, String position, String fromDate, String toDate)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("insert into ServiceRecords values(@1, @2, @3,@4)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", position);
                cmd.Parameters.AddWithValue("@3", fromDate);
                cmd.Parameters.AddWithValue("@4", toDate);

                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateLeave(String ASID, String category,String type, String fromDate, String toDate)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("insert into `leave` values(@1, @2, @3,@4,@5)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", category);
                cmd.Parameters.AddWithValue("@3", type);
                cmd.Parameters.AddWithValue("@4", fromDate);
                cmd.Parameters.AddWithValue("@5", toDate);

                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteFromChildrenTable(String ASID,String certificateNo)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();

                cmd = new MySqlCommand("DELETE FROM ChildrenDetail WHERE `NIC` = @1 AND `Birth Certificate No` = @2;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", certificateNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                

        }

        public void deleteFromEducationTable(String ASID, String qulification)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();

                cmd = new MySqlCommand("DELETE FROM EducationalQulifications WHERE `NIC` = @1 AND `Qulification Obtained` = @2;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", qulification);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteFromOtherpositionsTable(String ASID, String position)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();

                cmd = new MySqlCommand("DELETE FROM OtherPositions WHERE `NIC` = @1 AND `Position` = @2;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", position);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteFromServiceRecords(String ASID, String position)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();

                cmd = new MySqlCommand("DELETE FROM ServiceRecords WHERE `NIC` = @1 AND `Position` = @2;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", position);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteFromLeave(String ASID, String leaveCategory)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();

                cmd = new MySqlCommand("DELETE FROM `leave` WHERE `NIC` = @1 AND `Leave Category` = @2;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.Parameters.AddWithValue("@2", leaveCategory);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void updateAcademicStaff(String ASID,String title, String txtFullName, String txtInitials, String dateDob, String gender, String txtTelePrivate, String txtTeleOffice, String txtEmailPrivate, String txtEmailOffice,
            String txtNIC, String txtPassport, String cmbBxDesignation, String cmbBxFaculty, String cmbBxDepartment, String txtUPF, String dateAppointment, String dateRetirement, String txtMarriageCertificate, String txtServiceNo,
            String personalPicLoc, String marriageCertificateLoc, String cmbBxSalaryStep, String dateIncrement, String salaryScale, String healthInsurance, String etfNo, String salaryStepAmount, String highestQualification)
        {
            try
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
                    cmd = new MySqlCommand("update AcademicStaff set `Title` = @2,`Full Name` = @3,`Name with Initials` = @4,`DOB`=@5 ,`Gender`=@6,`Private Contact No`=@7 ,`Office Contact No`=@8 ,`Private Email`=@9,`Office Email`=@10,`NIC`=@11,`Passport No`=@12,`UPF No`=@13,`Appointment Date`=@14 ,`Retirement Date`=@15 ,`Marriage Certificate No`=@16 ,`Person Pic`=@18,`Type`=@19 ,`ServiceNo`=@20 ,`Department Name`=@21 ,`Designation`=@22,`Salary Step`=@23,`Increment Date`=@24,`Salary Scale`=@25,`Health Insurance`=@26,`ETF no`=@27,`Salary Step Amount`=28,`Highest Qualification`=29 where `NIC` = @30;", conn.connConnection());
                    cmd.Parameters.AddWithValue("@18", personalImg);
                    //MessageBox.Show("test");

                }
                else if (personalImg == null && marriageImg != null)
                {
                    cmd = new MySqlCommand("update AcademicStaff set `Title` = @2,`Full Name` = @3,`Name with Initials` = @4,`DOB`=@5 ,`Gender`=@6,`Private Contact No`=@7 ,`Office Contact No`=@8 ,`Private Email`=@9,`Office Email`=@10,`NIC`=@11,`Passport No`=@12,`UPF No`=@13,`Appointment Date`=@14 ,`Retirement Date`=@15 ,`Marriage Certificate No`=@16 ,`Marriage Certificate Pic`=@17,`Type`=@19,`ServiceNo`=@20 ,`Department Name`=@21,`Designation`=@22,`Salary Step`=@23,`Increment Date`=@24,`Salary Scale`=@25,`Health Insurance`=@26,`ETF no`=@27,`Salary Step Amount`=28,`Highest Qualification`=29 where `NIC` = @30;", conn.connConnection());
                    cmd.Parameters.AddWithValue("@17", marriageImg);


                }
                else if (marriageImg == null && personalImg == null)
                {
                    
                    cmd = new MySqlCommand("update AcademicStaff set `Title` = @2,`Full Name` = @3,`Name with Initials` = @4,`DOB`=@5 ,`Gender`=@6,`Private Contact No`=@7 ,`Office Contact No`=@8 ,`Private Email`=@9,`Office Email`=@10,`NIC`=@11,`Passport No`=@12,`UPF No`=@13,`Appointment Date`=@14 ,`Retirement Date`=@15 ,`Marriage Certificate No`=@16 ,`Type`=@19,`ServiceNo`=@20 ,`Department Name`=@21,`Designation`=@22,`Salary Step`=@23,`Increment Date`=@24,`Salary Scale`=@25,`Health Insurance`=@26,`ETF no`=@27,`Salary Step Amount`=28,`Highest Qualification`=29 where `NIC` = @30;", conn.connConnection());



                }
                else
                {
                    cmd = new MySqlCommand("update AcademicStaff set `Title` = @2,`Full Name` = @3,`Name with Initials` = @4,`DOB`=@5 ,`Gender`=@6,`Private Contact No`=@7 ,`Office Contact No`=@8 ,`Private Email`=@9,`Office Email`=@10,`NIC`=@11,`Passport No`=@12,`UPF No`=@13,`Appointment Date`=@14 ,`Retirement Date`=@15 ,`Marriage Certificate No`=@16 ,`Marriage Certificate Pic`=@17,`Person Pic`=@18,`Type`=@19,`ServiceNo`=@20 ,`Department Name`=@21,`Designation`=@22,`Salary Step`=@23,`Increment Date`=@24,`Salary Scale`=@25,`Health Insurance`=@26,`ETF no`=@27,`Salary Step Amount`=28,`Highest Qualification`=29 where `NIC` = @30;", conn.connConnection());
                    cmd.Parameters.AddWithValue("@17", marriageImg);
                    cmd.Parameters.AddWithValue("@18", personalImg);



                }

                cmd.Parameters.AddWithValue("@2", title);
                cmd.Parameters.AddWithValue("@3", txtFullName);
                cmd.Parameters.AddWithValue("@4", txtInitials);
                cmd.Parameters.AddWithValue("@5", dateDob);
                cmd.Parameters.AddWithValue("@6", gender);
                cmd.Parameters.AddWithValue("@7", txtTelePrivate);
                cmd.Parameters.AddWithValue("@8", txtTeleOffice);
                cmd.Parameters.AddWithValue("@9", txtEmailPrivate);
                cmd.Parameters.AddWithValue("@10", txtEmailOffice);
                cmd.Parameters.AddWithValue("@11", txtNIC);
                cmd.Parameters.AddWithValue("@12", txtPassport);
                cmd.Parameters.AddWithValue("@13", txtUPF);
                cmd.Parameters.AddWithValue("@14", dateAppointment);
                cmd.Parameters.AddWithValue("@15", dateRetirement);
                cmd.Parameters.AddWithValue("@16", txtMarriageCertificate);


                cmd.Parameters.AddWithValue("@19", "Permanent");
                cmd.Parameters.AddWithValue("@20", txtServiceNo);
                cmd.Parameters.AddWithValue("@21", cmbBxDepartment);
                cmd.Parameters.AddWithValue("@22", cmbBxDesignation);
                cmd.Parameters.AddWithValue("@23", cmbBxSalaryStep);
                cmd.Parameters.AddWithValue("@24", dateIncrement);
                cmd.Parameters.AddWithValue("@25", salaryScale);
                cmd.Parameters.AddWithValue("@26", healthInsurance);
                cmd.Parameters.AddWithValue("@27", etfNo);
                cmd.Parameters.AddWithValue("@28", salaryStepAmount);
                cmd.Parameters.AddWithValue("@29", highestQualification);
                cmd.Parameters.AddWithValue("@30", ASID);

                cmd.ExecuteNonQuery();


               // cmd = new SqlCommand("SELECT ASID FROM AcademicStaff where [NIC No] = @1; ", conn.connConnection());
               // cmd.Parameters.AddWithValue("@1", txtNIC);

              //  SqlDataReader read = cmd.ExecuteReader();

               // while (read.Read())
               // {
                //    primaryKey = read[0].ToString();

               // }
              //  read.Close();


                conn.closeConnection();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void updateChildrenDetail( String ASID,DataGridView tblChildren)
        {
           // try
            {
                int childrenCount = tblChildren.Rows.Count;

                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("DELETE FROM [ChildrenDetail] WHERE [ASID] = @1)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.ExecuteNonQuery();

                for (int i = 0; i < childrenCount; i++)
                {
                    cmd = conn.connConnection().CreateCommand();
                    cmd = new MySqlCommand("insert into ChildrenDetail values(@1, @2, @3,@4)", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", ASID);
                    cmd.Parameters.AddWithValue("@2", tblChildren.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@3", tblChildren.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@4", tblChildren.Rows[i].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.closeConnection();
                cmd.Dispose();
            }
           // catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        public void updateQulifications(DataGridView tblEducation)
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
                    //cmd.Parameters.AddWithValue("@1", primaryKey);
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

        public void updateOtherPositions(DataGridView tblOtherPositions)
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
                   // cmd.Parameters.AddWithValue("@1", primaryKey);
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

        public void updateServiceRecords(DataGridView tblService)
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
                    //cmd.Parameters.AddWithValue("@1", primaryKey);
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

        public void updateAddress(String txtAddress1Mail, String txtCityMail, String txtMailZipCode, String txtAddress1Home, String txtCityHome, String txtHomeZipCode)
        {
            conn.connOpen();
            conn.connConnection();
            MySqlCommand cmd = conn.connConnection().CreateCommand();
            cmd = new MySqlCommand("insert into Address values (@1,@2,@3,@4,@5,@6,@7);", conn.connConnection());


            //cmd.Parameters.AddWithValue("@1", primaryKey);
            cmd.Parameters.AddWithValue("@2", txtAddress1Mail);
            cmd.Parameters.AddWithValue("@3", txtCityMail);
            cmd.Parameters.AddWithValue("@4", txtMailZipCode);
            cmd.Parameters.AddWithValue("@5", txtAddress1Home);
            cmd.Parameters.AddWithValue("@6", txtCityHome);
            cmd.Parameters.AddWithValue("@7", txtHomeZipCode);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
        }
         
         
         

    }
}
