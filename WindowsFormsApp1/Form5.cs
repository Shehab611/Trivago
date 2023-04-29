using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        CrystalReport2 crystalReport2;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            crystalReport2 = new CrystalReport2();
            crystalReportViewer1.ReportSource = crystalReport2;
        }

        
    }
}
