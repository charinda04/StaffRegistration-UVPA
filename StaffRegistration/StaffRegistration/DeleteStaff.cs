using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffRegistration
{


    class DeleteStaff
    {
        Connection conn = new Connection();

        public void deleteAcademicStaff(String ASID)
        {
            try
            {
                conn.connOpen();
                conn.connConnection();
                MySqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = conn.connConnection().CreateCommand();

                cmd = new MySqlCommand("DELETE FROM AcademicStaff WHERE `NIC` = @1 ", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", ASID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
