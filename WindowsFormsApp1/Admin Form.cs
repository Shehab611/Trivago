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
            usersGrid.DataSource = db.GetAllUsers();
            pendingOffersGrid.DataSource = db.GetPendingOffers();
            All_users_activity_grid.DataSource = db.GetAllUsersActivty();
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void Admin_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form1 = (login_form)Tag;
           form1.Close();
        }

        private void AllUsersTab_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            db.UpdateUserData();
        }

        private void btn_search_user_Click(object sender, EventArgs e)
        {

            if (txt_phone.Text.Length == 0) {

                MessageBox.Show("You Must Enter phone Number!!");
            }
            else
            {
              specific_user_activty.DataSource = db.GetAllOneUserActivty(txt_phone.Text);
            }

           
        }
    }
}
