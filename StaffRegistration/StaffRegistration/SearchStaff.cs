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
                tblSearch.Columns[0].Visible = false;
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

        public void searchByName(String txtSearchName, DataGridView tblSearch)
        {

            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM AcademicStaff where [Full Name] like '%'+@1+'%'; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtSearchName);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                tblSearch.Columns[0].Visible = false;
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

        public void searchByNIC(String txtSearchNIC, DataGridView tblSearch)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM AcademicStaff where [NIC No] like '%'+@1+'%'; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtSearchNIC);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                tblSearch.Columns[0].Visible = false;
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

        public void searchByUPF(String txtSearchUPF, DataGridView tblSearch)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM AcademicStaff where [UPF No] like '%'+@1+'%'; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtSearchUPF);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                tblSearch.Columns[0].Visible = false;
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

        public void searchByPassport(String txtPassportNo, DataGridView tblSearch)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM AcademicStaff where [Passport No] like '%'+@1+'%'; ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtPassportNo);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                tblSearch.Columns[0].Visible = false;
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
