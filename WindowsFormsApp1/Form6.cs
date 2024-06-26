﻿using CrystalDecisions.Shared;
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
    public partial class Form6 : Form
    {
        CrystalReport3 crystalReport3;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            crystalReport3 = new CrystalReport3();
            foreach (ParameterDiscreteValue v in crystalReport3.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReport3.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = crystalReport3;
        }
    }
}
