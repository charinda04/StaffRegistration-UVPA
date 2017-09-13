using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace StaffRegistration
{
    class SearchStaff
    {

        
         
         Connection conn = new Connection();


        public void fillSearchTable(DataGridView tblSearch)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `academicstaff`;", conn.connConnection());
                // cmd.Parameters.AddWithValue("@1", txtSearchName);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                //tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchByName(String txtSearchName, DataGridView tblSearch, String faculty, String department)
        {

            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                if (faculty != "" && department != "")
                {
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff`,`department` where academicstaff.`Department Name` = @1 AND department.`Faculty Name` = @2 And academicstaff.`Department Name` = department.`Department Name` AND  `Full Name` like '%" + txtSearchName + "%'; ", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", department);
                    cmd.Parameters.AddWithValue("@2", faculty);
                }
                else if (faculty != "")
                {
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff`,`department` where department.`Faculty Name` =@1 And academicstaff.`Department Name` = department.`Department Name` AND  `Full Name` like '%" + txtSearchName + "%'; ", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", faculty);
                }
                else
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff` where `Full Name` like '%" + txtSearchName + "%'; ", conn.connConnection());
                //cmd.Parameters.AddWithValue("@1", txtSearchName);
                //MessageBox.Show();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                //tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void searchByNIC(String txtSearchNIC, DataGridView tblSearch, String faculty, String department)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                if (faculty != "" && department != "")
                {
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff`,`department` where academicstaff.`Department Name` = @1 AND department.`Faculty Name` = @2 And academicstaff.`Department Name` = department.`Department Name` AND`NIC` like '%" + txtSearchNIC + "%';  ", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", department);
                    cmd.Parameters.AddWithValue("@2", faculty);
                }
                else if (faculty != "")
                {
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff`,`department` where department.`Faculty Name` = @1 And academicstaff.`Department Name` = department.`Department Name` AND`NIC` like '%" + txtSearchNIC + "%';  ", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", faculty);
                }
                else
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff` WHERE `NIC` like '%" + txtSearchNIC + "%'; ", conn.connConnection());
               // cmd.Parameters.AddWithValue("@1", txtSearchNIC);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
               // tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchByUPF(String txtSearchUPF, DataGridView tblSearch, String faculty, String department)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                if (faculty != "" && department != "")
                {
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff`,`department` where academicstaff.`Department Name` = @1 AND department.`Faculty Name` = @2 And academicstaff.`Department Name` = department.`Department Name` AND `UPF No` like '%" + txtSearchUPF + "%'; ", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", department);
                    cmd.Parameters.AddWithValue("@2", faculty);
                }
                else if (faculty != "")
                {
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff`,`department` where department.`Faculty Name` = @1 And academicstaff.`Department Name` = department.`Department Name` AND `UPF No` like '%" + txtSearchUPF + "%'; ", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", faculty);
                }
                else
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff` where `UPF No` like '%" + txtSearchUPF + "%'; ", conn.connConnection());
                //cmd.Parameters.AddWithValue("@1", txtSearchUPF);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
               // tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchByPassport(String txtPassportNo, DataGridView tblSearch, String faculty, String department)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                if (faculty != "" && department != "")
                {
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff`,`department` where academicstaff.`Department Name` = @1 AND department.`Faculty Name` = @2 And academicstaff.`Department Name` = department.`Department Name` AND `Passport No` like '%" + txtPassportNo + "%'; ", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", department);
                    cmd.Parameters.AddWithValue("@2", faculty);
                }
                else if (faculty != "")
                {
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff`,`department` where department.`Faculty Name` = @1 And academicstaff.`Department Name` = department.`Department Name` AND `Passport No` like '%" + txtPassportNo + "%'; ", conn.connConnection());
                    cmd.Parameters.AddWithValue("@1", faculty);
                }
                else
                    cmd = new MySqlCommand("SELECT * FROM `academicstaff` where `Passport No` like '%" + txtPassportNo + "%'; ", conn.connConnection());
                //cmd.Parameters.AddWithValue("@1", txtPassportNo);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                //tblSearch.Columns[0].Visible = false;
                tblSearch.Columns[15].Visible = false;
                tblSearch.Columns[16].Visible = false;
                tblSearch.Columns[17].Visible = false;
                tblSearch.Columns[18].Visible = false;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void filterByDepartment() { }

        public void filterByFaculty() { }

        public void filterByAppointmentDate() { }
         
         
         

    }
}
