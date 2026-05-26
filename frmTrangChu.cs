using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmTrangChu : Form
    {
        // Chuỗi kết nối động dùng chung cho toàn dự án
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySanBong.mdf;Integrated Security=True";

        // Biến lưu trữ Form đang được mở hiện tại (để biết đường mà tắt nó đi)
        private Form activeForm = null;

        public frmTrangChu()
        {
            InitializeComponent();
        }

        // HÀM MỞ FORM CON NHÚNG VÀO PANEL (Đã dọn dẹp code thừa)
        private void OpenChildForm(Form childForm)
        {
            // 1. Nếu đang có một Form khác mở thì đóng nó lại trước
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // 2. Cập nhật trạng thái form hiện tại
            activeForm = childForm;

            // 3. Ép Form con bỏ viền và hành xử như một Control lấp đầy Panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 4. Ném Form con vào Panel bên phải và cho nó hiển thị
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // KHI ẤN NÚT TRANG CHỦ (Button 1)
        private void button1_Click(object sender, EventArgs e)
        {
            // Tắt chức năng đang mở đi để trả về giao diện màn hình chính trống trải
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null; // Reset lại trạng thái rỗng
            }
        }

        // =========================================================
        // KHU VỰC CHỜ GHÉP CODE (BẠN MỞ COMMENT KHI ĐÃ CÓ CÁC FORM)
        // =========================================================

        // private void button2_Click(object sender, EventArgs e)
        // {
        //     // Lưu ý: Cần chắc chắn bạn của bạn đặt tên Form là frmDatSan (chữ r) hay ftmDatSan (chữ t) nhé
        //     OpenChildForm(new frmDatSan());
        // }

        // private void button4_Click(object sender, EventArgs e)
        // {
        //     OpenChildForm(new Quanlysan());
        // }
    }
}