using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AllUsersTab = new System.Windows.Forms.TabPage();
            this.updateBtn = new System.Windows.Forms.Button();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.pendingOffersTab = new System.Windows.Forms.TabPage();
            this.pendingOffersGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.actionButtons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.All_users_activity_grid = new System.Windows.Forms.DataGridView();
            this.specific_user_activty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search_user = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.AllUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.pendingOffersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendingOffersGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.All_users_activity_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specific_user_activty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AllUsersTab);
            this.tabControl1.Controls.Add(this.pendingOffersTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 457);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AllUsersTab
            // 
            this.AllUsersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.AllUsersTab.Controls.Add(this.updateBtn);
            this.AllUsersTab.Controls.Add(this.usersGrid);
            this.AllUsersTab.Location = new System.Drawing.Point(4, 22);
            this.AllUsersTab.Name = "AllUsersTab";
            this.AllUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllUsersTab.Size = new System.Drawing.Size(796, 431);
            this.AllUsersTab.TabIndex = 0;
            this.AllUsersTab.Text = "All Users";
            this.AllUsersTab.Click += new System.EventHandler(this.AllUsersTab_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.updateBtn.Location = new System.Drawing.Point(274, 299);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(192, 35);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update User Data";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // usersGrid
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Location = new System.Drawing.Point(0, 0);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.RowHeadersWidth = 51;
            this.usersGrid.Size = new System.Drawing.Size(800, 263);
            this.usersGrid.TabIndex = 0;
            // 
            // pendingOffersTab
            // 
            this.pendingOffersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pendingOffersTab.Controls.Add(this.pendingOffersGrid);
            this.pendingOffersTab.Location = new System.Drawing.Point(4, 22);
            this.pendingOffersTab.Name = "pendingOffersTab";
            this.pendingOffersTab.Padding = new System.Windows.Forms.Padding(3);
            this.pendingOffersTab.Size = new System.Drawing.Size(796, 431);
            this.pendingOffersTab.TabIndex = 1;
            this.pendingOffersTab.Text = "Pending Offers";
            // 
            // pendingOffersGrid
            // 
            this.pendingOffersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingOffersGrid.Location = new System.Drawing.Point(0, 0);
            this.pendingOffersGrid.Name = "pendingOffersGrid";
            this.pendingOffersGrid.RowHeadersWidth = 51;
            this.pendingOffersGrid.Size = new System.Drawing.Size(800, 324);
            this.pendingOffersGrid.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tabPage1.Controls.Add(this.txt_phone);
            this.tabPage1.Controls.Add(this.btn_search_user);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.specific_user_activty);
            this.tabPage1.Controls.Add(this.All_users_activity_grid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 431);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Users Activity";
            // 
            // actionButtons
            // 
            this.actionButtons.DataPropertyName = "Action";
            this.actionButtons.HeaderText = "Action";
            this.actionButtons.MinimumWidth = 6;
            this.actionButtons.Name = "actionButtons";
            this.actionButtons.Width = 125;
            // 
            // All_users_activity_grid
            // 
            this.All_users_activity_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.All_users_activity_grid.Location = new System.Drawing.Point(-4, 0);
            this.All_users_activity_grid.Name = "All_users_activity_grid";
            this.All_users_activity_grid.RowHeadersWidth = 51;
            this.All_users_activity_grid.Size = new System.Drawing.Size(353, 428);
            this.All_users_activity_grid.TabIndex = 2;
            // 
            // specific_user_activty
            // 
            this.specific_user_activty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specific_user_activty.Location = new System.Drawing.Point(349, 201);
            this.specific_user_activty.Name = "specific_user_activty";
            this.specific_user_activty.RowHeadersWidth = 51;
            this.specific_user_activty.Size = new System.Drawing.Size(444, 230);
            this.specific_user_activty.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(356, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Phone Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search_user
            // 
            this.btn_search_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btn_search_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_search_user.Location = new System.Drawing.Point(475, 160);
            this.btn_search_user.Name = "btn_search_user";
            this.btn_search_user.Size = new System.Drawing.Size(201, 35);
            this.btn_search_user.TabIndex = 7;
            this.btn_search_user.Text = "Search on User";
            this.btn_search_user.UseVisualStyleBackColor = false;
            this.btn_search_user.Click += new System.EventHandler(this.btn_search_user_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txt_phone.Location = new System.Drawing.Point(462, 40);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(328, 31);
            this.txt_phone.TabIndex = 8;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Form_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.AllUsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.pendingOffersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pendingOffersGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.All_users_activity_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specific_user_activty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AllUsersTab;
        private System.Windows.Forms.TabPage pendingOffersTab;
        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView pendingOffersGrid;
        private System.Windows.Forms.TabPage tabPage1;
        private DataGridViewTextBoxColumn actionButtons;
        private Button btn_search_user;
        private Label label1;
        private DataGridView specific_user_activty;
        private DataGridView All_users_activity_grid;
        private TextBox txt_phone;
    }
}