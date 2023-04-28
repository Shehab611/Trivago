using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    partial class WhichOne
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
            this.btn_defult = new System.Windows.Forms.Button();
            this.btn_form_to_all = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_defult
            // 
            this.btn_defult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defult.Location = new System.Drawing.Point(148, 173);
            this.btn_defult.Name = "btn_defult";
            this.btn_defult.Size = new System.Drawing.Size(247, 67);
            this.btn_defult.TabIndex = 0;
            this.btn_defult.Text = "Application Defult Flow";
            this.btn_defult.UseVisualStyleBackColor = true;
            this.btn_defult.Click += new System.EventHandler(this.btn_defult_Click);
            // 
            // btn_form_to_all
            // 
            this.btn_form_to_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_form_to_all.Location = new System.Drawing.Point(582, 173);
            this.btn_form_to_all.Name = "btn_form_to_all";
            this.btn_form_to_all.Size = new System.Drawing.Size(247, 67);
            this.btn_form_to_all.TabIndex = 1;
            this.btn_form_to_all.Text = "All Forms";
            this.btn_form_to_all.UseVisualStyleBackColor = true;
            this.btn_form_to_all.Click += new System.EventHandler(this.btn_form_to_all_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 116);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Login Data:\r\nEmail:shehab@gmail.com\r\nPassword:123456";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 116);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hotel Login Data:\r\nEmail:ehab@gmail.com\r\nPassword:123456";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(678, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 116);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin Login Data:\r\nEmail:omar@gmail.com\r\nPassword:123456";
            // 
            // WhichOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_form_to_all);
            this.Controls.Add(this.btn_defult);
            this.Name = "WhichOne";
            this.Text = "WhichOne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_defult;
        private System.Windows.Forms.Button btn_form_to_all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}