﻿using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Admin_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AllUsersTab = new System.Windows.Forms.TabPage();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.pendingOffersTab = new System.Windows.Forms.TabPage();
            this.pendingOffersGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.actionButtons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.AllUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.pendingOffersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendingOffersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AllUsersTab);
            this.tabControl1.Controls.Add(this.pendingOffersTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 562);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseWaitCursor = true;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AllUsersTab
            // 
            this.AllUsersTab.Controls.Add(this.deleteBtn);
            this.AllUsersTab.Controls.Add(this.updateBtn);
            this.AllUsersTab.Controls.Add(this.userIdLabel);
            this.AllUsersTab.Controls.Add(this.textBox1);
            this.AllUsersTab.Controls.Add(this.usersGrid);
            this.AllUsersTab.Location = new System.Drawing.Point(4, 25);
            this.AllUsersTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllUsersTab.Name = "AllUsersTab";
            this.AllUsersTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllUsersTab.Size = new System.Drawing.Size(1064, 533);
            this.AllUsersTab.TabIndex = 0;
            this.AllUsersTab.Text = "All Users";
            this.AllUsersTab.UseVisualStyleBackColor = true;
            this.AllUsersTab.UseWaitCursor = true;
            this.AllUsersTab.Click += new System.EventHandler(this.AllUsersTab_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(497, 342);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.UseWaitCursor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(373, 341);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 28);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.UseWaitCursor = true;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(41, 348);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(47, 16);
            this.userIdLabel.TabIndex = 2;
            this.userIdLabel.Text = "user id";
            this.userIdLabel.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 345);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseWaitCursor = true;
            // 
            // usersGrid
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Location = new System.Drawing.Point(0, 0);
            this.usersGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.RowHeadersWidth = 51;
            this.usersGrid.Size = new System.Drawing.Size(1055, 324);
            this.usersGrid.TabIndex = 0;
            this.usersGrid.UseWaitCursor = true;
            // 
            // pendingOffersTab
            // 
            this.pendingOffersTab.Controls.Add(this.pendingOffersGrid);
            this.pendingOffersTab.Location = new System.Drawing.Point(4, 25);
            this.pendingOffersTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pendingOffersTab.Name = "pendingOffersTab";
            this.pendingOffersTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pendingOffersTab.Size = new System.Drawing.Size(1064, 533);
            this.pendingOffersTab.TabIndex = 1;
            this.pendingOffersTab.Text = "Pending Offers";
            this.pendingOffersTab.UseVisualStyleBackColor = true;
            this.pendingOffersTab.UseWaitCursor = true;
            // 
            // pendingOffersGrid
            // 
            this.pendingOffersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingOffersGrid.Location = new System.Drawing.Point(9, 7);
            this.pendingOffersGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pendingOffersGrid.Name = "pendingOffersGrid";
            this.pendingOffersGrid.RowHeadersWidth = 51;
            this.pendingOffersGrid.Size = new System.Drawing.Size(1035, 505);
            this.pendingOffersGrid.TabIndex = 1;
            this.pendingOffersGrid.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1064, 533);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Users Activity";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // actionButtons
            // 
            this.actionButtons.DataPropertyName = "Action";
            this.actionButtons.HeaderText = "Action";
            this.actionButtons.MinimumWidth = 6;
            this.actionButtons.Name = "actionButtons";
            this.actionButtons.Width = 125;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Form_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.AllUsersTab.ResumeLayout(false);
            this.AllUsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.pendingOffersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pendingOffersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AllUsersTab;
        private System.Windows.Forms.TabPage pendingOffersTab;
        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView pendingOffersGrid;
        private System.Windows.Forms.TabPage tabPage1;
        private DataGridViewTextBoxColumn actionButtons;
    }
}