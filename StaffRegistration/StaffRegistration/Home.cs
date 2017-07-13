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
    public partial class StaffRegistration : Form
    {
        SearchStaff staff = new SearchStaff();

        Connection cc = new Connection();


        public StaffRegistration()
        {
            InitializeComponent();

        }



        private void addStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }

        private void tStpBtnAdd_Click(object sender, EventArgs e)
        {
            Add addStaff = new Add();
            addStaff.ShowDialog();
        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            staff.fillSearchTable(tblSearch);
        }
    }
}
