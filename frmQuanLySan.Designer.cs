namespace quanlydatsan
{
    partial class frmQuanLySan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySan));
            this.dtpNgayDa = new System.Windows.Forms.DateTimePicker();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTraSan = new System.Windows.Forms.Button();
            this.btnThemSan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLoaiSan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cboSoPhutDa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGioDa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayDa
            // 
            this.dtpNgayDa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayDa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDa.Location = new System.Drawing.Point(177, 109);
            this.dtpNgayDa.Name = "dtpNgayDa";
            this.dtpNgayDa.Size = new System.Drawing.Size(378, 22);
            this.dtpNgayDa.TabIndex = 60;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(2, 432);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(903, 244);
            this.dgvDanhSach.TabIndex = 59;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.BackColor = System.Drawing.Color.LightGreen;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(667, 331);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(146, 49);
            this.btnDong.TabIndex = 58;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // btnTraSan
            // 
            this.btnTraSan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTraSan.BackColor = System.Drawing.Color.LightGreen;
            this.btnTraSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSan.Location = new System.Drawing.Point(362, 331);
            this.btnTraSan.Name = "btnTraSan";
            this.btnTraSan.Size = new System.Drawing.Size(160, 49);
            this.btnTraSan.TabIndex = 57;
            this.btnTraSan.Text = "Trả Sân";
            this.btnTraSan.UseVisualStyleBackColor = false;
            this.btnTraSan.Click += new System.EventHandler(this.btnTraSan_Click_1);
            // 
            // btnThemSan
            // 
            this.btnThemSan.BackColor = System.Drawing.Color.LightGreen;
            this.btnThemSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSan.Location = new System.Drawing.Point(64, 331);
            this.btnThemSan.Name = "btnThemSan";
            this.btnThemSan.Size = new System.Drawing.Size(143, 49);
            this.btnThemSan.TabIndex = 56;
            this.btnThemSan.Text = "Thêm Sân";
            this.btnThemSan.UseVisualStyleBackColor = false;
            this.btnThemSan.Click += new System.EventHandler(this.btnThemSan_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Loại Sân: ";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Có Người ",
            "Còn Trống"});
            this.cboTinhTrang.Location = new System.Drawing.Point(174, 59);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(378, 24);
            this.cboTinhTrang.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ngày Đá :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Số Phút Đá : ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tình trạng ";
            // 
            // cboLoaiSan
            // 
            this.cboLoaiSan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiSan.FormattingEnabled = true;
            this.cboLoaiSan.Items.AddRange(new object[] {
            "Sân 5",
            "Sân 7 ",
            "Sân 11"});
            this.cboLoaiSan.Location = new System.Drawing.Point(174, 19);
            this.cboLoaiSan.Name = "cboLoaiSan";
            this.cboLoaiSan.Size = new System.Drawing.Size(378, 24);
            this.cboLoaiSan.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Thành Tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.Location = new System.Drawing.Point(177, 260);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(378, 22);
            this.txtThanhTien.TabIndex = 62;
            // 
            // cboSoPhutDa
            // 
            this.cboSoPhutDa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSoPhutDa.FormattingEnabled = true;
            this.cboSoPhutDa.Items.AddRange(new object[] {
            "60",
            "90",
            "120"});
            this.cboSoPhutDa.Location = new System.Drawing.Point(174, 207);
            this.cboSoPhutDa.Name = "cboSoPhutDa";
            this.cboSoPhutDa.Size = new System.Drawing.Size(378, 24);
            this.cboSoPhutDa.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Giờ Đá ";
            // 
            // cboGioDa
            // 
            this.cboGioDa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGioDa.FormattingEnabled = true;
            this.cboGioDa.Items.AddRange(new object[] {
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00"});
            this.cboGioDa.Location = new System.Drawing.Point(174, 157);
            this.cboGioDa.Name = "cboGioDa";
            this.cboGioDa.Size = new System.Drawing.Size(378, 24);
            this.cboGioDa.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 280);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuanLySan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(907, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboGioDa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboSoPhutDa);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayDa);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTraSan);
            this.Controls.Add(this.btnThemSan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboLoaiSan);
            this.Name = "frmQuanLySan";
            this.Text = "frmQuanLySan";
            this.Load += new System.EventHandler(this.frmQuanLySan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayDa;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTraSan;
        private System.Windows.Forms.Button btnThemSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoaiSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ComboBox cboSoPhutDa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGioDa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}