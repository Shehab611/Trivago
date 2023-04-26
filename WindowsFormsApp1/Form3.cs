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
    public partial class Hotel_Page : Form
    {
        readonly Database_control db = new Database_control();
        User_in_DataBase user;
        public Hotel_Page(User_in_DataBase user)
        {
            InitializeComponent();
            this.user = user;
        }

      
        private void Form3_Load(object sender, EventArgs e)
        {

        }

       
        private void Hotel_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form1 = (login_form)Tag;
            form1.Close();
        }

        private void Add_offeres_Click(object sender, EventArgs e)
        {

            if (Txt_price.Text.Length == 0)
            {
                MessageBox.Show("Price Can not be empty");
            }
            else if (Txt_describtion.Text.Length == 0) 
            {
                MessageBox.Show("Description Can not be empty");
            }
            else
            {
                db.AddOffer(Txt_describtion.Text, int.Parse(Txt_price.Text), user.User_id);
                MessageBox.Show("Offer Added Successfully");
            }
            
        }

        private void all_reviews_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Show_review(user.User_id);
        }
    }
}
