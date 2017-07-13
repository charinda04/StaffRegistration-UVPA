using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRegistration
{
    class Alerts
    {
        /*
         
        Connection conn = new Connection();

        public void tblAlerts(DataGridView tblAlerts)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                String sql = "SELECT [ASID][Title],[Name with Initials],[Increment Date],[Private Contact No],[Office Contact No] ,[Private Email],[Office Email],[NIC No],[Appointment Date],[Retirement Date],[ServiceNo],[AcademicStaff].[Department Name],[Faculty Name],[Designation] from [AcademicStaff],[Department] where [Increment Date] < cast(dateadd(m, 1, getdate())AS DATE) and [Increment Date] > CAST(GETDATE() AS DATE) and [AcademicStaff].[Department Name] = [Department].[Department Name]";
                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand( sql, conn.connConnection());
                //cmd.Parameters.AddWithValue("@1", txtSearchName);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

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

         */
    }
}
