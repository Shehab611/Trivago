using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace WindowsFormsApp1
{
    public partial class Admin_Form : Form
    {
        readonly Database_control db = new Database_control();
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == AllUsersTab)
            {
                usersGrid.DataSource =  db.getAllUsers();
            }
            else if (tabControl1.SelectedTab == pendingOffersTab)
            {
                pendingOffersGrid.DataSource = db.getPendingOffers();      
            }

        }

        private void Admin_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form1 = (login_form)Tag;
           form1.Close();
        }
    }
}
