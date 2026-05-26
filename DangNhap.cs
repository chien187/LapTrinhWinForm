using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // BẮT BUỘC PHẢI CÓ DÒNG NÀY ĐỂ KẾT NỐI SQL

namespace WindowsFormsApp2
{
    public partial class DangNhap : Form
    {
        // CHUỖI KẾT NỐI DB (Biến toàn cục)
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySanBong.mdf;Integrated Security=True";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mặc định ẩn mật khẩu khi mới mở form lên
            txtMatKhau.PasswordChar = '*';
            txtNhapLaiMatKhau.PasswordChar = '*';
        }

        // CHỈ DÙNG ĐÚNG 1 HÀM CHO NÚT ĐĂNG KÝ
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string sdt = txtSdt.Text.Trim();
            string email = txtEmail.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string nhapLaiMK = txtNhapLaiMatKhau.Text.Trim();

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(hoTen) ||
                string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(nhapLaiMK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra định dạng Email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không đúng định dạng (VD: abc@gmail.com).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // 3. Kiểm tra Mật khẩu khớp
            if (matKhau != nhapLaiMK)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhau.Focus();
                return;
            }

            // 4. LƯU VÀO CSDL THỰC TẾ
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Mở cổng kết nối

                    // Lệnh thêm dữ liệu vào bảng Users (Nhớ đảm bảo trong DB bạn có bảng này nhé)
                    string query = "INSERT INTO Users (SoDienThoai, Email, HoTen, MatKhau) VALUES (@Sdt, @Email, @Hoten, @Mk)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Sdt", sdt);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Hoten", hoTen);
                        cmd.Parameters.AddWithValue("@Mk", matKhau);

                        cmd.ExecuteNonQuery(); // Lệnh này mới là lệnh nhét chữ vào Database
                    }

                    // 5. BÁO THÀNH CÔNG VÀ CHUYỂN FORM
                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
                   
                   this.Close();
                }
                catch (SqlException sqlEx)
                {
                    // Lỗi 2627 là mã lỗi của SQL khi bị trùng Email (Do cột Email đặt là UNIQUE)
                    if (sqlEx.Number == 2627)
                    {
                        MessageBox.Show("Email này đã tồn tại trong hệ thống. Vui lòng dùng email khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cơ sở dữ liệu: " + sqlEx.Message, "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi");
                }
            }
            
        }

        // KHI ẤN VÀO LINK "ĐÃ CÓ TÀI KHOẢN? ĐĂNG NHẬP"
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Đóng form Đăng ký để về form Đăng nhập
        }

        // CHECKBOX HIỆN MẬT KHẨU
        private void chkHienThiMK_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtNhapLaiMatKhau.PasswordChar = '*';
            }
        }
    }
}