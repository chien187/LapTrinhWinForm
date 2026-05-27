using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class QLKHO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnNhapLo = new Button();
            btnTao = new Button();
            dgvHangHoa = new DataGridView();
            TenHang = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(313, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý kho";
            // 
            // btnNhapLo
            // 
            btnNhapLo.BackColor = Color.Orange;
            btnNhapLo.FlatAppearance.BorderSize = 0;
            btnNhapLo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNhapLo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNhapLo.FlatStyle = FlatStyle.Flat;
            btnNhapLo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhapLo.ForeColor = Color.White;
            btnNhapLo.Location = new Point(12, 99);
            btnNhapLo.Name = "btnNhapLo";
            btnNhapLo.Size = new Size(146, 29);
            btnNhapLo.TabIndex = 1;
            btnNhapLo.Text = "Nhập lô";
            btnNhapLo.UseVisualStyleBackColor = false;
            btnNhapLo.Click += btnNhapLo_Click;
            // 
            // btnTao
            // 
            btnTao.BackColor = Color.Orange;
            btnTao.FlatAppearance.BorderSize = 0;
            btnTao.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTao.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTao.FlatStyle = FlatStyle.Flat;
            btnTao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTao.ForeColor = Color.White;
            btnTao.Location = new Point(12, 48);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(174, 29);
            btnTao.TabIndex = 2;
            btnTao.Text = "+ Tạo mặt hàng mới";
            btnTao.UseVisualStyleBackColor = false;
            btnTao.Click += btnTao_Click;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.BackgroundColor = Color.SeaGreen;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Columns.AddRange(new DataGridViewColumn[] { TenHang, SoLuong, DonVi, GiaBan });
            dgvHangHoa.Dock = DockStyle.Bottom;
            dgvHangHoa.Location = new Point(0, 134);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.Size = new Size(800, 316);
            dgvHangHoa.TabIndex = 3;
            // 
            // TenHang
            // 
            TenHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenHang.HeaderText = "Mặt hàng";
            TenHang.Name = "TenHang";
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoLuong.HeaderText = "SL còn";
            SoLuong.Name = "SoLuong";
            // 
            // DonVi
            // 
            DonVi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DonVi.HeaderText = "Đơn vị";
            DonVi.Name = "DonVi";
            // 
            // GiaBan
            // 
            GiaBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GiaBan.HeaderText = "Giá bán";
            GiaBan.Name = "GiaBan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHangHoa);
            Controls.Add(btnTao);
            Controls.Add(btnNhapLo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNhapLo;
        private Button btnTao;
        private DataGridView dgvHangHoa;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn GiaBan;
    }
}
