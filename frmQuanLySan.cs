using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydatsan
{
    public partial class frmQuanLySan : Form
    {
        string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDatSan;Integrated Security=True;TrustServerCertificate=True";
        private string maSanDuocChon = "";

        public frmQuanLySan()
        {
            InitializeComponent();
        }

        private void frmQuanLySan_Load(object sender, EventArgs e)
        {
            // 1. Ép nhận click chuột cho bảng
            dgvDanhSach.CellClick += new DataGridViewCellEventHandler(dgvDanhSach_CellClick);
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 2. ÉP NHẬN SỰ KIỆN TỰ ĐỘNG TÍNH TIỀN (Trị tận gốc bệnh đơ của giao diện)
            cboLoaiSan.TextChanged += new EventHandler(cboLoaiSan_TextChanged);
            cboSoPhutDa.TextChanged += new EventHandler(cboSoPhutDa_TextChanged);

            // 3. Tải dữ liệu lên
            LoadDuLieu();
        }

        // ==========================================
        // 1. HÀM TẢI DỮ LIỆU TỪ SQL LÊN BẢNG
        // ==========================================
        private void LoadDuLieu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    // ĐÃ BỔ SUNG CỘT: GioDa AS [Giờ Đá]
                    string query = "SELECT MaSan AS [Mã], LoaiSan AS [Loại Sân], TrangThai AS [Tình Trạng], " +
                                   "GioDa AS [Giờ Đá], SoPhutDa AS [Số Phút Đá], NgayDa AS [Ngày Đá], " +
                                   "CAST((SoPhutDa * (GiaSan / 60.0)) AS DECIMAL(18,0)) AS [Thành Tiền] " +
                                   "FROM SanBong";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvDanhSach.DataSource = dt;
                        dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        if (dgvDanhSach.Columns["Mã"] != null) dgvDanhSach.Columns["Mã"].Visible = false;
                        if (dgvDanhSach.Columns["Ngày Đá"] != null) dgvDanhSach.Columns["Ngày Đá"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        if (dgvDanhSach.Columns["Thành Tiền"] != null) dgvDanhSach.Columns["Thành Tiền"].DefaultCellStyle.Format = "#,##0 VNĐ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu từ SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 2. SỰ KIỆN CLICK VÀO HÀNG TRÊN BẢNG
        // ==========================================
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                DataGridViewRow row = dgvDanhSach.CurrentRow;

                maSanDuocChon = row.Cells["Mã"].Value?.ToString();
                cboLoaiSan.Text = row.Cells["Loại Sân"].Value?.ToString();
                cboTinhTrang.Text = row.Cells["Tình Trạng"].Value?.ToString();
                cboSoPhutDa.Text = row.Cells["Số Phút Đá"].Value?.ToString();

                // Đổ dữ liệu Giờ Đá lên ComboBox mới
                cboGioDa.Text = row.Cells["Giờ Đá"].Value?.ToString();

                if (row.Cells["Thành Tiền"].Value != DBNull.Value && row.Cells["Thành Tiền"].Value != null)
                {
                    decimal thanhTien = Convert.ToDecimal(row.Cells["Thành Tiền"].Value);
                    txtThanhTien.Text = thanhTien.ToString("#,##0 VNĐ");
                }
                else
                {
                    txtThanhTien.Text = "0 VNĐ";
                }

                if (DateTime.TryParse(row.Cells["Ngày Đá"].Value?.ToString(), out DateTime ngayDaDb))
                {
                    dtpNgayDa.Value = ngayDaDb;
                }
            }
        }

        // ==========================================
        // 3. CHỨC NĂNG NÚT "THÊM SÂN"
        // ==========================================
        private void btnThemSan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSan.Text))
            {
                MessageBox.Show("Vui lòng chọn Loại sân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboGioDa.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn Giờ đá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soPhut = 0;
            if (string.IsNullOrWhiteSpace(cboSoPhutDa.Text) || !int.TryParse(cboSoPhutDa.Text, out soPhut))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập số phút đá hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();

                    string maSanTuDong = "SAN_" + DateTime.Now.ToString("yyMMddHHmmss");

                    decimal giaSanTheoGio = 0;
                    string loaiSan = cboLoaiSan.Text;
                    if (loaiSan.Contains("5")) giaSanTheoGio = 200000;
                    else if (loaiSan.Contains("7")) giaSanTheoGio = 300000;
                    else if (loaiSan.Contains("11")) giaSanTheoGio = 500000;

                    // Đã thêm cột GioDa vào câu lệnh INSERT
                    string query = "INSERT INTO SanBong (MaSan, TenSan, LoaiSan, GiaSan, GioDa, SoPhutDa, TrangThai, NgayDa) " +
                                   "VALUES (@Ma, @Ten, @Loai, @Gia, @GioDa, @SoPhut, @TrangThai, @NgayDa)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ma", maSanTuDong);
                        cmd.Parameters.AddWithValue("@Ten", cboLoaiSan.Text.Trim());
                        cmd.Parameters.AddWithValue("@Loai", cboLoaiSan.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gia", giaSanTheoGio);
                        cmd.Parameters.AddWithValue("@GioDa", cboGioDa.Text.Trim()); // Truyền Giờ Đá
                        cmd.Parameters.AddWithValue("@SoPhut", soPhut);
                        cmd.Parameters.AddWithValue("@TrangThai", cboTinhTrang.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayDa", dtpNgayDa.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đã thêm thông tin sân mới vào CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDuLieu();
                LamMoiO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 4. CHỨC NĂNG NÚT "TRẢ SÂN" (XÓA)
        // ==========================================
        private void btnTraSan_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maSanDuocChon))
            {
                MessageBox.Show("Vui lòng click chọn một lượt sân từ danh sách bên dưới để thao tác trả sân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn trả sân và xóa lượt đá này khỏi danh sách không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(strCon))
                    {
                        conn.Open();
                        string query = "DELETE FROM SanBong WHERE MaSan = @Ma";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Ma", maSanDuocChon);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Đã trả sân và xóa lượt đá khỏi danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                    LamMoiO();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu sân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // 5. CHỨC NĂNG NÚT "ĐÓNG" VÀ LÀM MỚI
        // ==========================================
        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LamMoiO()
        {
            cboLoaiSan.Text = "";
            cboTinhTrang.Text = "";
            cboSoPhutDa.Text = "";
            cboGioDa.Text = ""; // Làm mới Giờ Đá
            txtThanhTien.Clear();
            dtpNgayDa.Value = DateTime.Now;
            maSanDuocChon = "";
        }

        // ==========================================
        // 6. LOGIC TỰ ĐỘNG TÍNH TIỀN TRÊN MÀN HÌNH
        // ==========================================
        private void TinhTienTuDong()
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSan.Text) || string.IsNullOrWhiteSpace(cboSoPhutDa.Text))
            {
                txtThanhTien.Text = "0 VNĐ";
                return;
            }

            int soPhut = 0;
            if (int.TryParse(cboSoPhutDa.Text, out soPhut))
            {
                decimal giaSanTheoGio = 0;
                string loaiSan = cboLoaiSan.Text;

                if (loaiSan.Contains("5")) giaSanTheoGio = 200000;
                else if (loaiSan.Contains("7")) giaSanTheoGio = 300000;
                else if (loaiSan.Contains("11")) giaSanTheoGio = 500000;

                decimal thanhTien = (giaSanTheoGio / 60) * soPhut;
                txtThanhTien.Text = thanhTien.ToString("#,##0 VNĐ");
            }
            else
            {
                txtThanhTien.Text = "0 VNĐ";
            }
        }

        private void cboLoaiSan_TextChanged(object sender, EventArgs e)
        {
            TinhTienTuDong();
        }

        private void cboSoPhutDa_TextChanged(object sender, EventArgs e)
        {
            TinhTienTuDong();
        }
    }
}