using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DangKyAdmin : Form
    {
        public DangKyAdmin()
        {
            InitializeComponent();
        }

        // HÀM LÚC MỚI MỞ FORM: Tự động ẩn mật khẩu
        private void DangKyAdmin_Load(object sender, EventArgs e)
        {
            txtAdminMatKhau.PasswordChar = '*';
        }

        // KHI ẤN NÚT ĐĂNG NHẬP ADMIN
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            // Đã cập nhật đúng tên control của bạn
            string taiKhoan = txtAdminTaiKhoan.Text.Trim();
            string matKhau = txtAdminMatKhau.Text.Trim();

            // 1. Kiểm tra bỏ trống
            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. KIỂM TRA TÀI KHOẢN CẤP SẴN (Fix cứng)
            if (taiKhoan == "admin" && matKhau == "1")
            {
                MessageBox.Show("Đăng nhập Admin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // FormTrangChuAdmin frm = new FormTrangChuAdmin();
                // frm.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu Quản trị viên!", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdminMatKhau.Clear();      // Xóa mật khẩu sai
                txtAdminTaiKhoan.SelectAll(); // Bôi đen tài khoản
                txtAdminTaiKhoan.Focus();
            }
        }

        // KHI TÍCH VÀO CHECKBOX "HIỂN THỊ MẬT KHẨU"
        

        // KHI ẤN NÚT THOÁT
       

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void chkHienThiMK2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK2.Checked)
                txtAdminMatKhau.PasswordChar = '\0'; // Hiện chữ thật
            else
                txtAdminMatKhau.PasswordChar = '*';  // Ẩn chữ
        }

        private void btnAdminThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}