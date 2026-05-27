using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DangNhap : Form
    {
        // Chuỗi kết nối SQL Server
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySanBong.mdf;Integrated Security=True";
        public DangNhap()
        {
            InitializeComponent();
            SetupUI(); // BẮT BUỘC PHẢI GỌI HÀM NÀY Ở ĐÂY ĐỂ GIAO DIỆN HOẠT ĐỘNG
        }

        // ==========================================
        // CÀI ĐẶT GIAO DIỆN (MÀU SẮC, TOOLTIP)
        // ==========================================
        private void SetupUI()
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtEmail, "Nhập email do nhà trường cấp (@tlu.edu.vn)");
            tooltip.SetToolTip(txtMatKhau, "Nhập mật khẩu sinh viên");

          
            // Mặc định ẩn mật khẩu
            txtMatKhau.PasswordChar = '*';
           

            // Đổi màu khi nhấp chuột
            txtEmail.GotFocus += TextBox_GotFocus;
            txtEmail.LostFocus += TextBox_LostFocus;
            txtMatKhau.GotFocus += TextBox_GotFocus;
            txtMatKhau.LostFocus += TextBox_LostFocus;
           
        }

        // HÀM KHI CLICK CHUỘT VÀO Ô NHẬP
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            // Ép kiểu về đúng Guna2TextBox
            var txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            // Kiểm tra chắc chắn txt không bị rỗng rồi mới đổi màu
            if (txt != null)
            {
                txt.FillColor = Color.LightCyan; // Guna UI dùng FillColor
            }
        }

        // HÀM KHI CHUYỂN CHUỘT SANG Ô KHÁC
        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            var txt = sender as Guna.UI2.WinForms.Guna2TextBox;

            if (txt != null)
            {
                txt.FillColor = Color.White;
            }
        }

        // ==========================================
        // PHẦN 1: ĐĂNG NHẬP SINH VIÊN
        // ==========================================
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND MatKhau = @MatKhau";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        int result = (int)cmd.ExecuteScalar();
                        if (result > 0)
                        {
                            MessageBox.Show("Đăng nhập Sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMatKhau.Clear();
                            txtEmail.Clear();
                            Form f1 = new TrangChu();
                            this.Hide();         // Ẩn trang chủ đi cho thoáng
                            f1.ShowDialog();    // Mở trang đặt sân lên
                            this.Show();         // Khi người dùng tắt trang đặt sân, Trang chủ tự mọc lại

                        }
                        else
                        {
                            MessageBox.Show("Email hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMatKhau.Clear();
                            txtEmail.SelectAll();
                            txtEmail.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi Hệ Thống");
                }
            }
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked)
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '*';
        }

        // ==========================================
        // PHẦN 2: CHUYỂN SANG FORM ĐĂNG KÝ
        // ==========================================
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form1 = new DangKy();
            form1.StartPosition = FormStartPosition.CenterScreen; // Ép Form Đăng ký căn giữa
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        // ==========================================
        // PHẦN 3: ĐĂNG NHẬP ADMIN (PANEL)
        // ==========================================
       

        // ==========================================
        // PHẦN 4: NÚT THOÁT
        // ==========================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void llbAdminLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new DangKyAdmin();
            
            this.Hide();           // 1. Tạm thời ẩn (tàng hình) Form Đăng nhập sinh viên đi
            f.ShowDialog(); // 2. Mở Form Đăng nhập Admin lên đè lên trên (Code sẽ đứng chờ ở đây)

            this.Show();           // 3. Khi bạn ấn nút "Thoát" ở Form Admin (gọi lệnh this.Close), dòng này sẽ chạy để hiện lại Form Sinh viên!
        }
    }
}