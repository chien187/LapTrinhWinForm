using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class DSKH
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
            panelHeader = new Panel();
            btnThemKhach = new Button();
            txtTimKiem = new TextBox();
            lblTitle = new Label();
            dgvKhachHang = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            TenKhachHang = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            lblTongSo = new ToolStripStatusLabel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.LightGreen;
            //panelHeader.BackgroundImage = Properties.Resources.istockphoto_491522867_170667a;
            panelHeader.Controls.Add(btnThemKhach);
            panelHeader.Controls.Add(txtTimKiem);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 100);
            panelHeader.TabIndex = 0;
            // 
            // btnThemKhach
            // 
            btnThemKhach.BackColor = Color.FromArgb(255, 255, 128);
            btnThemKhach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemKhach.ForeColor = SystemColors.ActiveCaptionText;
            btnThemKhach.Location = new Point(620, 64);
            btnThemKhach.Name = "btnThemKhach";
            btnThemKhach.Size = new Size(148, 23);
            btnThemKhach.TabIndex = 3;
            btnThemKhach.Text = "+ Thêm khách hàng";
            btnThemKhach.UseVisualStyleBackColor = false;
            btnThemKhach.Click += btnThemKhach_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(25, 32);
            txtTimKiem.Name = "txtTimKiem";
            //txtTimKiem.PlaceholderText = "Tìm kiếm tên, sđt, email";
            txtTimKiem.Size = new Size(210, 29);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(298, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.BackgroundColor = Color.DarkGreen;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { STT, TenKhachHang, SoDienThoai, Email });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 100);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(800, 350);
            dgvKhachHang.TabIndex = 1;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            STT.DataPropertyName = "STT";
            STT.HeaderText = "STT";
            STT.Name = "STT";
            // 
            // TenKhachHang
            // 
            TenKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKhachHang.DataPropertyName = "TenKhachHang";
            TenKhachHang.HeaderText = "Tên khách hàng";
            TenKhachHang.Name = "TenKhachHang";
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.Name = "SoDienThoai";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTongSo });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTongSo
            // 
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(127, 17);
            lblTongSo.Text = "Tổng số khách hàng: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(dgvKhachHang);
            Controls.Add(panelHeader);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnThemKhach;
        private TextBox txtTimKiem;
        private DataGridView dgvKhachHang;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTongSo;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenKhachHang;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn Email;
    }
}
