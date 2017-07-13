using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StaffRegistration
{
    class Connection
    {
        MySqlConnection conn = new MySqlConnection();

        public Connection()
        {
            conn.ConnectionString = @"datasource=localhost;port=3306;username=root;password=;database=academicstaff";

            try
            {
                conn.Open();
                Console.WriteLine("State: {0}", conn.State);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void connOpen()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        public MySqlConnection connConnection()
        {
            return conn;
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }




    }
}
