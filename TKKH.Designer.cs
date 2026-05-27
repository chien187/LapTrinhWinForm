using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class TKKH
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHoVaTen = new TextBox();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            //label1.Image = Properties.Resources.istockphoto_491522867_170667a;
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            //label2.Image = Properties.Resources.istockphoto_491522867_170667a;
            label2.Location = new Point(46, 90);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 224, 192);
            //label3.Image = Properties.Resources.istockphoto_491522867_170667a;
            label3.Location = new Point(46, 152);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(220, 27);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(100, 23);
            txtHoVaTen.TabIndex = 3;
            txtHoVaTen.TextChanged += txtHoVaTen_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(220, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(220, 87);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(100, 23);
            txtSoDienThoai.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(0, 192, 0);
            //btnLuu.BackgroundImage = Properties.Resources.istockphoto_491522867_170667a;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(40, 219);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(102, 35);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.Black;
            //btnHuy.Image = Properties.Resources.istockphoto_491522867_170667a;
            btnHuy.Location = new Point(220, 219);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 35);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            //BackgroundImage = Properties.Resources.istockphoto_491522867_170667a;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtEmail);
            Controls.Add(txtHoVaTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHoVaTen;
        private TextBox txtEmail;
        private TextBox txtSoDienThoai;
        private Button btnLuu;
        private Button btnHuy;
    }
}