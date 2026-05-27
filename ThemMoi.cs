using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ThemMoi : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySanBong.mdf;Integrated Security=True";
        public string TenHang { get; private set; }
        public int SoLuong { get; private set; }
        public string DonVi { get; private set; }
        public decimal GiaBan { get; private set; }
        public ThemMoi()
        {
            InitializeComponent();
            cboDonVi.Items.Clear();
            cboDonVi.Items.Add("Cái");
            cboDonVi.Items.Add("Cốc");
            cboDonVi.Items.Add("Chai");
            cboDonVi.Items.Add("Gói");
            cboDonVi.Items.Add("Lon");
            cboDonVi.Items.Add("Quả");
            cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cboDonVi.Items.Count > 0)
            {
                cboDonVi.SelectedIndex = 0;
            }
        }

        private void FormThemMoi_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text) || txtTenHang.Text == "Nhập tên mặt hàng")
            {
                MessageBox.Show("Vui lòng nhập tên mặt hàng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng phải là một số nguyên lớn hơn hoặc bằng 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtGiaBan.Text, out decimal giaBan) || giaBan < 0)
            {
                MessageBox.Show("Giá bán phải là một số tiền hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TenHang = txtTenHang.Text.Trim();
            SoLuong = soLuong;
            DonVi = cboDonVi.SelectedItem.ToString();
            GiaBan = giaBan;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
