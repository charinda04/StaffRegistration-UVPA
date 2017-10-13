using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffRegistration
{
    public partial class Login : Form
    {
        Connection conn = new Connection();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
                btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `user` WHERE `User Name` = @1", conn.connConnection());
                cmd.Parameters.AddWithValue("@1", txtUserName.Text);


                conn.connOpen();
                conn.connConnection();


                MySqlDataReader reader1;


                reader1 = cmd.ExecuteReader();
                
                if (reader1.Read())
                {
                   // MessageBox.Show("test");
                    if (txtPassword.Text.Equals(reader1["Password"].ToString()))
                    {
                        StaffRegistration sr = new StaffRegistration();
                        
                        sr.ShowDialog();
                        this.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }


                   


                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }





                reader1.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
                btnLogin.Enabled = true;
        }
    }
}
