﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class login_form : Form
    {
        private readonly Database_control database_Control = new Database_control();
        
   
        public login_form()
        {
            InitializeComponent();

         
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool loginCheck = database_Control.CheckOnLogin(txt_email.Text, txt_password.Text);
            if (loginCheck)
            {
                int userRole = database_Control.GetRole(txt_email.Text);
                User_in_DataBase user = database_Control.GetUserData(txt_email.Text);
                database_Control.AddUserActivity(user.User_id);
                switch (userRole)
                {
                    case 0:
                        {

                            //navigate to Customer Form
                            CustomerForm form2 = new CustomerForm
                            {
                                Tag = this
                            };

                            form2.Show();
                            Hide();
                            break;
                        }
                    case 1:
                        {
                            //navigate to Admin Form

                            Admin_Form form2 = new Admin_Form
                            {
                                Tag = this
                               
                            };

                            form2.Show();
                            Hide();
                            break;
                        }
                    case 2:
                        {
                            Hotel_Page form2 = new Hotel_Page(user)
                            {
                                Tag = this
                            };

                            form2.Show();
                            Hide();
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
            signup_form form2 = new signup_form
            {
                Tag = this
            };
            form2.Show(this);
            Hide();
        }


        private void panel_login_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
