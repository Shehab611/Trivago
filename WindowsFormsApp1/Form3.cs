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
        public Hotel_Page()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

        }

        private void Hotel_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form1 = (login_form)Tag;
            form1.Close();
        }
    }
}
