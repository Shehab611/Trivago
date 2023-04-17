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
    public partial class signup_form : Form
    {
        Database_control database_Control = new Database_control();
        public signup_form()
        {
            InitializeComponent();
        }

        private void btn_go_page_3_Click(object sender, EventArgs e)
        {
            pnl_login_info.Width = pnl_main.Width;
            line2.BackColor = Color.FromArgb(59, 249, 81);
        }

        private void btn_go_page_2_Click(object sender, EventArgs e)
        {
            pnl_address.Width = pnl_main.Width;
            pnl_personal_info.Width = pnl_login_info.Width = 0;
            line1.BackColor = Color.FromArgb(59, 249, 81);
            line2.BackColor = Color.FromArgb(167, 167, 167);
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            bool isEmailExist=database_Control.CheckIfEmailExist(txt_email_signup.Text);
            bool isPhoneExist=database_Control.CheckIfPhoneExist(txt_phone.Text);
            if (isEmailExist) {
                MessageBox.Show("Email is used before!!\nPlease Enter another one", "Opps!!!");
            }
            if (isPhoneExist) {

                MessageBox.Show("Phone Number is used before!!\nPlease Enter another one", "Opps!!!");
            }


           
             var form1 = (login)Tag;
            form1.Show();
            Close();
        }

        private void btn_prsonal_info_Click(object sender, EventArgs e)
        {
            pnl_address.Width = pnl_login_info.Width = 0;
            line1.BackColor = line2.BackColor = Color.FromArgb(167, 167, 167);
           
        }

        private void btn_address_Click(object sender, EventArgs e)
        {
            pnl_address.Width = pnl_main.Width;
            pnl_personal_info.Width = pnl_login_info.Width = 0;
           line1.BackColor = Color.FromArgb(59, 249, 81);
            line2.BackColor = Color.FromArgb(167, 167, 167);
        }

        private void btn_login_info_Click(object sender, EventArgs e)
        {
            pnl_login_info.Width = pnl_main.Width;
            line2.BackColor=Color.FromArgb(59, 249, 81);
        }

        private void picBox_visabilty_pass_Click(object sender, EventArgs e)
        {
            txt_pass_signup.UseSystemPasswordChar = !txt_pass_signup.UseSystemPasswordChar;
        }

        private void picBox_visabilty_pass_conf_Click(object sender, EventArgs e)
        {
            txt_pass_conf_signup.UseSystemPasswordChar = !txt_pass_conf_signup.UseSystemPasswordChar;
        }
    }
    
}
