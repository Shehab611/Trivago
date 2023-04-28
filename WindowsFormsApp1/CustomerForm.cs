using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace WindowsFormsApp1
{
    public partial class CustomerForm : Form
    {
        Database_control db = new Database_control();
        User_in_DataBase user;
        public CustomerForm(User_in_DataBase user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = (login_form)Tag;
            form1.Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getAllOffers();
        }
        
        private void ShwFavouriteBTN_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = db.getFavOffers(user.User_id);
        }

        private void AddFavouriteBTN_Click(object sender, EventArgs e)
        {
           
            int favId = int.Parse(favIdText.Text.ToString());
            db.addFavourite(favId, user.User_id);
        }

        private void FilterBTN_Click(object sender, EventArgs e)
        {
            int maxPrice = int.Parse(textBox1.Text.ToString());
            dataGridView1.DataSource = db.filterByMaxPrice(maxPrice);
        }

        private void btn_show_all_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.getAllOffers();
        }
    }

}
