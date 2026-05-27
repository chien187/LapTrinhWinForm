using System;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp2
{
    public partial class DSKH : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySanBong.mdf;Integrated Security=True";
        DataTable dtKhachHang = new DataTable();
        public DSKH()
        {
            InitializeComponent();
            dgvKhachHang.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dtKhachHang.Columns.Add("STT", typeof(int));
            dtKhachHang.Columns.Add("TenKhachHang", typeof(string));
            dtKhachHang.Columns.Add("SoDienThoai", typeof(string));
            dtKhachHang.Columns.Add("Email", typeof(string));
            dgvKhachHang.DataSource = dtKhachHang;
            lblTongSo.Text = "Tổng số khách hàng: " + dt.Rows.Count.ToString();
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            using (TKKH fNhap = new TKKH())
            {
                if (fNhap.ShowDialog() == DialogResult.OK)
                {
                    string hoTenMoi = fNhap.HoVaTen;
                    string sdtMoi = fNhap.SoDienThoai;
                    string emailMoi = fNhap.Email;
                    int sttTiepTheo = dtKhachHang.Rows.Count + 1;
                    dtKhachHang.Rows.Add(sttTiepTheo, hoTenMoi, sdtMoi, emailMoi);
                    MessageBox.Show("Thêm khách hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKhachHang.DataSource = null;
                    dgvKhachHang.DataSource = dtKhachHang;
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                dtKhachHang.DefaultView.RowFilter = "";
                dgvKhachHang.DataSource = dtKhachHang;
            }
            else
            {
                try
                {
                    dtKhachHang.DefaultView.RowFilter = string.Format("TenKhachHang LIKE '%{0}%' OR SoDienThoai LIKE '%{0}%'", tuKhoa);
                    dgvKhachHang.DataSource = dtKhachHang.DefaultView;
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnIconTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

