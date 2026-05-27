using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace WinFormsApp2
{
    public partial class QLKHO : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySanBong.mdf;Integrated Security=True";
        public class HangHoa
        {
            public string TenHang { get; set; }
            public int SoLuong { get; set; }
            public string DonVi { get; set; }
            public decimal GiaBan { get; set; }
        }
        BindingList<HangHoa> danhSachHangHoa = new BindingList<HangHoa>();
        public QLKHO()
        {
            InitializeComponent();
            dgvHangHoa.AutoGenerateColumns = false;
            dgvHangHoa.Columns["TenHang"].DataPropertyName = "TenHang";
            dgvHangHoa.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dgvHangHoa.Columns["DonVi"].DataPropertyName = "DonVi";
            dgvHangHoa.Columns["GiaBan"].DataPropertyName = "GiaBan";
            dgvHangHoa.DataSource = danhSachHangHoa;
            danhSachHangHoa.Add(new HangHoa { TenHang = "Bánh mỳ VELA", SoLuong = 0, DonVi = "Cái", GiaBan = 10000 });
            danhSachHangHoa.Add(new HangHoa { TenHang = "Bánh bao hoàng kim", SoLuong = 12, DonVi = "Cái", GiaBan = 20000 });
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            ThemMoi frm = new ThemMoi();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                danhSachHangHoa.Add(new HangHoa
                {
                    TenHang = frm.TenHang,
                    SoLuong = frm.SoLuong,
                    DonVi = frm.DonVi,
                    GiaBan = frm.GiaBan
                });
                MessageBox.Show("Thêm mặt hàng mới thành công!");
            }
        }

        private void btnNhapLo_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng từ danh sách để nhập lô!");
                return;
            }
            HangHoa hangDuocChon = (HangHoa)dgvHangHoa.CurrentRow.DataBoundItem;
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Nhập số lượng hàng thêm vào cho lô '{hangDuocChon.TenHang}':",
                "Nhập lô hàng hóa",
                "0"
            );
            if (int.TryParse(input, out int soLuongNhapThem) && soLuongNhapThem > 0)
            {
                hangDuocChon.SoLuong += soLuongNhapThem;
                dgvHangHoa.Refresh();
                MessageBox.Show($"Đã cập nhật! Số lượng mới của {hangDuocChon.TenHang} là: {hangDuocChon.SoLuong}");
            }
            else if (!string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Số lượng nhập không hợp lệ!");
            }
        }
    }
}