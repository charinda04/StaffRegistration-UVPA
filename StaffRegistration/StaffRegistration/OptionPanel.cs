using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffRegistration
{
    class OptionPanel
    {
        Connection conn = new Connection();

        public void loadSalaryCode(DataGridView tblOldCode)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `salarycode` ", conn.connConnection());

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                tblOldCode.DataSource = table;
                tblOldCode.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadSalaryScale(DataGridView tblOldScale, String salaryCode)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT `Salary Scale`,`Step Amount`,`Salary Steps` FROM `salaryscale` WHERE `Salary Code` = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryCode);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                dataAdapter = new MySqlDataAdapter(cmd);

                table = new DataTable();
                dataAdapter.Fill(table);

                tblOldScale.DataSource = table;
                tblOldScale.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadSalaryStep(DataGridView tblOldStep, String salaryScale)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT [Salary Step] FROM [SalaryStep] WHERE [Salary Scale] = @1; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryScale);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                dataAdapter = new MySqlDataAdapter(cmd);

                table = new DataTable();
                dataAdapter.Fill(table);

                tblOldStep.DataSource = table;
                tblOldStep.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDesignation(DataGridView tblDesignation)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `designations`;", conn.connConnection());


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblDesignation.DataSource = table;
                tblDesignation.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.closeConnection();

                tblDesignation.Columns[1].Visible = false;

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadFaculty(DataGridView tblFaculty)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `faculty` ", conn.connConnection());


                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblFaculty.DataSource = table;
                tblFaculty.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.closeConnection();

                tblFaculty.Columns[1].Visible = false;

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDepartment(DataGridView tblDepartment, String faculty)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT `Department Name` FROM `department` WHERE `Faculty Name` = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", faculty);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblDepartment.DataSource = table;
                tblDepartment.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertFaculty(String txtNewFaculty)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("INSERT INTO `faculty`(`Faculty Name`) VALUES (@1)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewFaculty);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New faculty successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This faculty name already exsits. Please enter a different faculty name");
                //MessageBox.Show(ex.Message);
            }
        }

        public void insertDepartment(String txtNewDepartment, String Faculty)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("INSERT INTO `department` VALUES (@1,@2)", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewDepartment);
                cmd.Parameters.AddWithValue("@2", Faculty);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Department successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This Department name already exsits. Please enter a different Department name");
                MessageBox.Show(ex.Message);
            }
        }

        public void insertDesignation(String txtNewDesignation)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("INSERT INTO `designations` (`Designation`) VALUES (@1);", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewDesignation);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New Designation successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This Designation name already exsits. Please enter a different Designation name");
                MessageBox.Show(ex.Message);
            }
        }

        public void insertSalaryCode(String txtNewCode)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("INSERT INTO `salarycode` VALUES (@1);", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewCode);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New SalaryCode successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This SalaryCode already exsits. Please enter a different SalaryCode");
                MessageBox.Show(ex.Message);
            }
        }

        public void insertSalaryScale(String txtNewScale, String salaryCode, String salarySteps, String stepAmount)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("INSERT INTO `salaryscale` VALUES (@1,@2,@3,@4);", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewScale);
                cmd.Parameters.AddWithValue("@2", salaryCode);
                cmd.Parameters.AddWithValue("@3", stepAmount);
                cmd.Parameters.AddWithValue("@4", salarySteps);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New SalaryScale successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This SalaryScale already exsits. Please enter a different SalaryScale");
                MessageBox.Show(ex.Message);
            }
        }

        public void insertSalaryStep(String txtNewStep, String salaryScale)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("INSERT INTO [SalaryStep] VALUES (@1,@2);", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtNewStep);
                cmd.Parameters.AddWithValue("@2", salaryScale);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New SalaryStep successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This SalaryStep already exsits. Please enter a different SalaryStep");
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteFaculty(String txtFaculty)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("DELETE FROM `faculty` WHERE `Faculty Name` = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtFaculty);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("faculty successfully added");

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("This faculty name already exsits. Please enter a different faculty name");
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteDepartment(String txtDepartment)
        {
            try
            {

                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("DELETE FROM `department` WHERE `Department Name` = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtDepartment);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteDesignation(String txtDesignation)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("DELETE FROM `designations` WHERE `Designation` = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtDesignation);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteSalaryCode(String salaryCode)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("DELETE FROM `salarycode` WHERE `Salary Code` = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryCode);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteSalaryScale(String salaryScale)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("DELETE FROM `salaryscale` WHERE `Salary Scale` = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryScale);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteSalaryStep(String salaryStep)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("DELETE FROM [SalaryStep] WHERE [Salary Step] = @1;", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", salaryStep);
                cmd.ExecuteNonQuery();

                conn.closeConnection();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
