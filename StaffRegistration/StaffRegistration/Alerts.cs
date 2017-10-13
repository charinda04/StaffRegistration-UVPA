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
    class Alerts
    {
        
         
        Connection conn = new Connection();

        public void tblAlertsIncrement(DataGridView tblAlerts)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                String sql = "SELECT `NIC`,`Title`,`Name with Initials`,`Increment Date`,`Private Contact No`,`Office Contact No` ,`Private Email`,`Office Email`,`Appointment Date`,`Retirement Date`,`ServiceNo`,`AcademicStaff`.`Department Name`,`Faculty Name`,`Designation` from `AcademicStaff`,`Department` where `Increment Date` < DATE_ADD(CURDATE(), INTERVAL 1 MONTH) and `Increment Date` > CURDATE() and `AcademicStaff`.`Department Name` = `Department`.`Department Name`";
                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand( sql, conn.connConnection());
                //cmd.Parameters.AddWithValue("@1", txtSearchName);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblAlerts.DataSource = table;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void checkNoofAlerts(Label indicator, DataGridView tblAlerts)
        {
            indicator.Text = tblAlerts.Rows.Count.ToString();
        }
         
    }
}
