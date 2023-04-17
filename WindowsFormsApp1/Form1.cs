
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
    public partial class login_form : Form
    {
        Database_control database_Control = new Database_control();
        public login_form()
        {
            InitializeComponent();



        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool loginCheck = database_Control.CheckOnLogin(txt_email.Text, txt_password.Text);
            int userRole = 0;
            if (loginCheck)
            {
                userRole = database_Control.GetRole(txt_email.Text);

                switch (userRole)
                {
                    case 0:
                        {

                            //navigate to Customer Form
                            break;
                        }
                    case 1:
                        {
                            //navigate to Admin Form
                            break;
                        }
                    case 2:
                        {
                            //navigate to Hotel Form
                            break;
                        }

                }

            }
            else
            {
                MessageBox.Show("Invalid Credential!!\nPlease Enter a vaild one", "Opps!!!");
                
            }

        }

        private void picBox_visabilty_Click(object sender, EventArgs e)
        {

            txt_password.UseSystemPasswordChar = !txt_password.UseSystemPasswordChar;
          

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

            signup_form form2 = new signup_form();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }
    }
}
