using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class TKKH : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySanBong.mdf;Integrated Security=True";
        public string HoVaTen => txtHoVaTen.Text.Trim();
        public string SoDienThoai => txtSoDienThoai.Text.Trim();
        public string Email => txtEmail.Text.Trim();
        public TKKH()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(HoVaTen) || string.IsNullOrEmpty(SoDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SoDienThoai.Length != 10 || !long.TryParse(SoDienThoai, out _))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập đúng 10 số và không chứa chữ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(Email))
            {
                if (!Email.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Email không hợp lệ! Vui lòng nhập đúng định dạng đuôi @gmail.com.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
