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
    public partial class Reports : Form
    {

        CustomReport report = new CustomReport();
        public Reports()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            
            report.populateTreeView(ref trVwFaculty, ref trVwDesignation, ref trVwDepartment);
            trVwPersonal.ExpandAll();
            trVwFamily.ExpandAll();
            trVwEducational.ExpandAll();
            trVwOther.ExpandAll();
            trVwAddress.ExpandAll();
            trVwService.ExpandAll();
            trVwFaculty.ExpandAll();
            trVwDepartment.ExpandAll();
            trVwDesignation.ExpandAll();
        }

        private void trVwAddress_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void trVwPersonal_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // The code only executes if the user caused the checked state to change.
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    report.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }
    }
}
