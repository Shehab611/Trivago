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
    public partial class WhichOne : Form
    {
        public WhichOne()
        {
          
            InitializeComponent();
           
        }

        private void btn_defult_Click(object sender, EventArgs e)
        {
            Form frm2 = new login_form();
            frm2.ShowDialog();
        }

        private void btn_form_to_all_Click(object sender, EventArgs e)
        {
            Form frm2 = new FormToALL();
            frm2.ShowDialog();
            
        }
    }
}
