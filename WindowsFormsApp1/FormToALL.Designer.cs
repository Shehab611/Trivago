﻿namespace WindowsFormsApp1
{
    partial class FormToALL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login_Page = new System.Windows.Forms.TabPage();
            this.Sign_up_page = new System.Windows.Forms.TabPage();
            this.admin_page = new System.Windows.Forms.TabPage();
            this.Hotel_page = new System.Windows.Forms.TabPage();
            this.Customer_page = new System.Windows.Forms.TabPage();
            this.Reports = new System.Windows.Forms.TabPage();
            this.btn_report1 = new System.Windows.Forms.Button();
            this.btn_report2 = new System.Windows.Forms.Button();
            this.btn_report3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Login_Page);
            this.tabControl1.Controls.Add(this.Sign_up_page);
            this.tabControl1.Controls.Add(this.admin_page);
            this.tabControl1.Controls.Add(this.Hotel_page);
            this.tabControl1.Controls.Add(this.Customer_page);
            this.tabControl1.Controls.Add(this.Reports);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1044, 579);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Login_Page
            // 
            this.Login_Page.Location = new System.Drawing.Point(4, 22);
            this.Login_Page.Name = "Login_Page";
            this.Login_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Login_Page.Size = new System.Drawing.Size(1036, 553);
            this.Login_Page.TabIndex = 1;
            this.Login_Page.Text = "Login Page";
            this.Login_Page.UseVisualStyleBackColor = true;
            // 
            // Sign_up_page
            // 
            this.Sign_up_page.Location = new System.Drawing.Point(4, 22);
            this.Sign_up_page.Name = "Sign_up_page";
            this.Sign_up_page.Size = new System.Drawing.Size(1036, 553);
            this.Sign_up_page.TabIndex = 2;
            this.Sign_up_page.Text = "Sign Up Page";
            this.Sign_up_page.UseVisualStyleBackColor = true;
            // 
            // admin_page
            // 
            this.admin_page.Location = new System.Drawing.Point(4, 22);
            this.admin_page.Name = "admin_page";
            this.admin_page.Padding = new System.Windows.Forms.Padding(3);
            this.admin_page.Size = new System.Drawing.Size(1036, 553);
            this.admin_page.TabIndex = 0;
            this.admin_page.Text = "Admin Page";
            this.admin_page.UseVisualStyleBackColor = true;
            // 
            // Hotel_page
            // 
            this.Hotel_page.Location = new System.Drawing.Point(4, 22);
            this.Hotel_page.Name = "Hotel_page";
            this.Hotel_page.Size = new System.Drawing.Size(1036, 553);
            this.Hotel_page.TabIndex = 3;
            this.Hotel_page.Text = "Hotel Page";
            this.Hotel_page.UseVisualStyleBackColor = true;
            // 
            // Customer_page
            // 
            this.Customer_page.Location = new System.Drawing.Point(4, 22);
            this.Customer_page.Name = "Customer_page";
            this.Customer_page.Size = new System.Drawing.Size(1036, 553);
            this.Customer_page.TabIndex = 4;
            this.Customer_page.Text = "Customer Page";
            this.Customer_page.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.btn_report3);
            this.Reports.Controls.Add(this.btn_report2);
            this.Reports.Controls.Add(this.btn_report1);
            this.Reports.Location = new System.Drawing.Point(4, 22);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(1036, 553);
            this.Reports.TabIndex = 5;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // btn_report1
            // 
            this.btn_report1.Location = new System.Drawing.Point(24, 168);
            this.btn_report1.Name = "btn_report1";
            this.btn_report1.Size = new System.Drawing.Size(183, 45);
            this.btn_report1.TabIndex = 0;
            this.btn_report1.Text = "Report 1";
            this.btn_report1.UseVisualStyleBackColor = true;
            this.btn_report1.Click += new System.EventHandler(this.btn_report1_Click);
            // 
            // btn_report2
            // 
            this.btn_report2.Location = new System.Drawing.Point(365, 168);
            this.btn_report2.Name = "btn_report2";
            this.btn_report2.Size = new System.Drawing.Size(183, 45);
            this.btn_report2.TabIndex = 1;
            this.btn_report2.Text = "Report 2";
            this.btn_report2.UseVisualStyleBackColor = true;
            this.btn_report2.Click += new System.EventHandler(this.btn_report2_Click);
            // 
            // btn_report3
            // 
            this.btn_report3.Location = new System.Drawing.Point(727, 168);
            this.btn_report3.Name = "btn_report3";
            this.btn_report3.Size = new System.Drawing.Size(183, 45);
            this.btn_report3.TabIndex = 2;
            this.btn_report3.Text = "Report 3";
            this.btn_report3.UseVisualStyleBackColor = true;
            this.btn_report3.Click += new System.EventHandler(this.btn_report3_Click);
            // 
            // FormToALL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 599);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormToALL";
            this.Text = "FormToALL";
            this.Load += new System.EventHandler(this.FormToALL_Load);
            this.tabControl1.ResumeLayout(false);
            this.Reports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage admin_page;
        private System.Windows.Forms.TabPage Login_Page;
        private System.Windows.Forms.TabPage Sign_up_page;
        private System.Windows.Forms.TabPage Hotel_page;
        private System.Windows.Forms.TabPage Customer_page;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.Button btn_report3;
        private System.Windows.Forms.Button btn_report2;
        private System.Windows.Forms.Button btn_report1;
    }
}