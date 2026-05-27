using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class ThemMoi : Form
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
            label4 = new Label();
            txtTenHang = new TextBox();
            txtGiaBan = new TextBox();
            txtSoLuong = new TextBox();
            cboDonVi = new ComboBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 112);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 184);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn vị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 256);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Giá bán";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(50, 62);
            txtTenHang.Name = "txtTenHang";
            //txtTenHang.PlaceholderText = "Nhập tên mặt hàng";
            txtTenHang.Size = new Size(336, 23);
            txtTenHang.TabIndex = 4;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(50, 279);
            txtGiaBan.Name = "txtGiaBan";
            //txtGiaBan.PlaceholderText = "Nhập giá bán";
            txtGiaBan.Size = new Size(336, 23);
            txtGiaBan.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(50, 135);
            txtSoLuong.Name = "txtSoLuong";
            //txtSoLuong.PlaceholderText = "Nhập số lượng";
            txtSoLuong.Size = new Size(336, 23);
            txtSoLuong.TabIndex = 6;
            // 
            // cboDonVi
            // 
            cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonVi.FormattingEnabled = true;
            cboDonVi.Items.AddRange(new object[] { "Chai", "", "Cái", "", "Gói", "", "Cốc", "", "Lon", "", "Quả" });
            cboDonVi.Location = new Point(50, 207);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(336, 23);
            cboDonVi.TabIndex = 7;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Orange;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(50, 341);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(336, 34);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Orange;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(422, 341);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(339, 34);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormThemMoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(cboDonVi);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGiaBan);
            Controls.Add(txtTenHang);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormThemMoi";
            Text = "FormThemMoi";
            Load += FormThemMoi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenHang;
        private TextBox txtGiaBan;
        private TextBox txtSoLuong;
        private ComboBox cboDonVi;
        private Button btnLuu;
        private Button btnHuy;
    }
}