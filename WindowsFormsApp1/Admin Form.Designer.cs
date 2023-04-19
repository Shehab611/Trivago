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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Al = new System.Windows.Forms.TabControl();
            this.pendingOffersTab = new System.Windows.Forms.TabPage();
            this.pendingOffersGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.actionButtons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.AllUsersTab = new System.Windows.Forms.TabPage();
            this.Al.SuspendLayout();
            this.pendingOffersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendingOffersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.AllUsersTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Al
            // 
            this.Al.Controls.Add(this.AllUsersTab);
            this.Al.Controls.Add(this.pendingOffersTab);
            this.Al.Controls.Add(this.tabPage1);
            this.Al.Location = new System.Drawing.Point(1, 0);
            this.Al.Name = "Al";
            this.Al.SelectedIndex = 0;
            this.Al.Size = new System.Drawing.Size(804, 457);
            this.Al.TabIndex = 0;
            this.Al.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // pendingOffersTab
            // 
            this.pendingOffersTab.Controls.Add(this.pendingOffersGrid);
            this.pendingOffersTab.Location = new System.Drawing.Point(4, 22);
            this.pendingOffersTab.Name = "pendingOffersTab";
            this.pendingOffersTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pendingOffersTab.Size = new System.Drawing.Size(796, 431);
            this.pendingOffersTab.TabIndex = 1;
            this.pendingOffersTab.Text = "Pending Offers";
            this.pendingOffersTab.UseVisualStyleBackColor = true;
            // 
            // pendingOffersGrid
            // 
            this.pendingOffersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingOffersGrid.Location = new System.Drawing.Point(7, 6);
            this.pendingOffersGrid.Name = "pendingOffersGrid";
            this.pendingOffersGrid.RowHeadersWidth = 51;
            this.pendingOffersGrid.Size = new System.Drawing.Size(776, 410);
            this.pendingOffersGrid.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(796, 431);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Users Activity";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // actionButtons
            // 
            this.actionButtons.DataPropertyName = "Action";
            this.actionButtons.HeaderText = "Action";
            this.actionButtons.MinimumWidth = 6;
            this.actionButtons.Name = "actionButtons";
            this.actionButtons.Width = 125;
            // 
            // usersGrid
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.usersGrid.Location = new System.Drawing.Point(0, 0);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.RowHeadersWidth = 51;
            this.usersGrid.Size = new System.Drawing.Size(791, 263);
            this.usersGrid.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 1;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(31, 283);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(0, 13);
            this.userIdLabel.TabIndex = 2;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(280, 277);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(373, 278);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // AllUsersTab
            // 
            this.AllUsersTab.Controls.Add(this.deleteBtn);
            this.AllUsersTab.Controls.Add(this.updateBtn);
            this.AllUsersTab.Controls.Add(this.userIdLabel);
            this.AllUsersTab.Controls.Add(this.textBox1);
            this.AllUsersTab.Controls.Add(this.usersGrid);
            this.AllUsersTab.Location = new System.Drawing.Point(4, 22);
            this.AllUsersTab.Name = "AllUsersTab";
            this.AllUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllUsersTab.Size = new System.Drawing.Size(796, 431);
            this.AllUsersTab.TabIndex = 0;
            this.AllUsersTab.Text = "All Users";
            this.AllUsersTab.UseVisualStyleBackColor = true;
            this.AllUsersTab.Click += new System.EventHandler(this.AllUsersTab_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Al);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Form_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.Al.ResumeLayout(false);
            this.pendingOffersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pendingOffersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.AllUsersTab.ResumeLayout(false);
            this.AllUsersTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Al;
        private System.Windows.Forms.TabPage pendingOffersTab;
        private System.Windows.Forms.DataGridView pendingOffersGrid;
        private System.Windows.Forms.TabPage tabPage1;
        private DataGridViewTextBoxColumn actionButtons;
        private TabPage AllUsersTab;
        private Button deleteBtn;
        private Button updateBtn;
        private Label userIdLabel;
        private TextBox textBox1;
        private DataGridView usersGrid;
    }
}