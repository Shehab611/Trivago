namespace WindowsFormsApp1
{
    partial class CustomerForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FilterBTN = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.minPriceLabel = new System.Windows.Forms.Label();
            this.ShwFavouriteBTN = new System.Windows.Forms.Button();
            this.AddFavouriteBTN = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.favIdText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.images_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(378, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 573);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 3;
            // 
            // FilterBTN
            // 
            this.FilterBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.FilterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBTN.Location = new System.Drawing.Point(53, 269);
            this.FilterBTN.Name = "FilterBTN";
            this.FilterBTN.Size = new System.Drawing.Size(125, 36);
            this.FilterBTN.TabIndex = 4;
            this.FilterBTN.Text = "Filter";
            this.FilterBTN.UseVisualStyleBackColor = false;
            this.FilterBTN.Click += new System.EventHandler(this.FilterBTN_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchLabel.Location = new System.Drawing.Point(12, 200);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(53, 17);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search";
            // 
            // minPriceLabel
            // 
            this.minPriceLabel.AutoSize = true;
            this.minPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPriceLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.minPriceLabel.Location = new System.Drawing.Point(61, 200);
            this.minPriceLabel.Name = "minPriceLabel";
            this.minPriceLabel.Size = new System.Drawing.Size(120, 17);
            this.minPriceLabel.TabIndex = 7;
            this.minPriceLabel.Text = "by maximum price";
            // 
            // ShwFavouriteBTN
            // 
            this.ShwFavouriteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ShwFavouriteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShwFavouriteBTN.Location = new System.Drawing.Point(1072, 173);
            this.ShwFavouriteBTN.Name = "ShwFavouriteBTN";
            this.ShwFavouriteBTN.Size = new System.Drawing.Size(125, 33);
            this.ShwFavouriteBTN.TabIndex = 8;
            this.ShwFavouriteBTN.Text = "Show Favourite";
            this.ShwFavouriteBTN.UseVisualStyleBackColor = false;
            this.ShwFavouriteBTN.Click += new System.EventHandler(this.ShwFavouriteBTN_Click);
            // 
            // AddFavouriteBTN
            // 
            this.AddFavouriteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.AddFavouriteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFavouriteBTN.Location = new System.Drawing.Point(922, 173);
            this.AddFavouriteBTN.Name = "AddFavouriteBTN";
            this.AddFavouriteBTN.Size = new System.Drawing.Size(125, 33);
            this.AddFavouriteBTN.TabIndex = 9;
            this.AddFavouriteBTN.Text = "Add Favourite ";
            this.AddFavouriteBTN.UseVisualStyleBackColor = false;
            this.AddFavouriteBTN.Click += new System.EventHandler(this.AddFavouriteBTN_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(1120, 214);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(53, 20);
            this.idText.TabIndex = 10;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.idLabel.Location = new System.Drawing.Point(1095, 214);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 17);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "Id";
            // 
            // favIdText
            // 
            this.favIdText.Location = new System.Drawing.Point(964, 214);
            this.favIdText.Name = "favIdText";
            this.favIdText.Size = new System.Drawing.Size(53, 20);
            this.favIdText.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(939, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1224, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.favIdText);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.AddFavouriteBTN);
            this.Controls.Add(this.ShwFavouriteBTN);
            this.Controls.Add(this.minPriceLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.FilterBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button FilterBTN;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label minPriceLabel;
        private System.Windows.Forms.Button ShwFavouriteBTN;
        private System.Windows.Forms.Button AddFavouriteBTN;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox favIdText;
        private System.Windows.Forms.Label label1;
    }
}