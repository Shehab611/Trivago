using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormToALL : Form
    {
        User_in_DataBase Hotel_User;
        User_in_DataBase Customer_User;
        public FormToALL()
        
        {
            InitializeComponent();
            Customer_User = new User_in_DataBase("shehab@gmail.com", "123456", "shehab", "ehab",0,"011", "30110260102596");
            Customer_User.User_id = 1;
           
            Hotel_User = new User_in_DataBase("ehab@gmail.com", "123456", "ehab", "hesham", 2, "011383", "30110460102592");
            Hotel_User.User_id = 9;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Login_Page) {

                login_form frm = new login_form();
                frm.TopLevel = false;
                frm.Visible = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                tabControl1.TabPages[0].Controls.Add(frm);

            }
            else if (tabControl1.SelectedTab ==Sign_up_page ) {
                signup_form frm = new signup_form();
                frm.TopLevel = false;
                frm.Visible = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                tabControl1.TabPages[1].Controls.Add(frm);

            }
            else if (tabControl1.SelectedTab == admin_page) {
                Admin_Form frm = new Admin_Form();
                frm.TopLevel = false;
                frm.Visible = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                tabControl1.TabPages[2].Controls.Add(frm);
            }
            else if (tabControl1.SelectedTab ==Hotel_page ) {
                Hotel_Form frm = new Hotel_Form(Hotel_User);
                frm.TopLevel = false;
                frm.Visible = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                tabControl1.TabPages[3].Controls.Add(frm);
            }
            else if (tabControl1.SelectedTab == Customer_page) {
                CustomerForm frm = new CustomerForm(Customer_User);
                frm.TopLevel = false;
                frm.Visible = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                tabControl1.TabPages[4].Controls.Add(frm);
            }
        }

        private void FormToALL_Load(object sender, EventArgs e)
        {
            login_form frm = new login_form();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabControl1.TabPages[0].Controls.Add(frm);
        }

        private void btn_report1_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form4();
            frm2.ShowDialog();
        }

        private void btn_report2_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form5();
            frm2.ShowDialog();
        }

        private void btn_report3_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form6();
            frm2.ShowDialog();
        }
    }
}
