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
    public partial class ftmDatSan : Form
    {
        string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyDatSan;Integrated Security=True;TrustServerCertificate=True";

        public ftmDatSan()
        {
            InitializeComponent();
        }

        private void frmDatSan_Load(object sender, EventArgs e)
        {
            if (cboLoaiSan.Items.Count > 0) cboLoaiSan.SelectedIndex = 0;
            if (cboGioDa.Items.Count > 0) cboGioDa.SelectedIndex = 0;
            if (cboSoPhutDa.Items.Count > 0) cboSoPhutDa.SelectedIndex = 0;
        }

        private void TinhTien()
        {
            if (cboLoaiSan.SelectedItem == null || cboSoPhutDa.SelectedItem == null)
            {
                txtThanhTien.Text = "0 VNĐ";
                return;
            }

            string loaiSan = cboLoaiSan.SelectedItem.ToString();
            double soPhut = double.Parse(cboSoPhutDa.SelectedItem.ToString());

            double donGia = 150000;
            if (loaiSan.Contains("7")) donGia = 250000;
            else if (loaiSan.Contains("11")) donGia = 500000;

            double thanhTien = (soPhut / 60.0) * donGia;
            txtThanhTien.Text = thanhTien.ToString("N0") + " VNĐ";
        }

        private void cboLoaiSan_SelectedIndexChanged(object sender, EventArgs e) { TinhTien(); }
        private void cboSoPhutDa_SelectedIndexChanged(object sender, EventArgs e) { TinhTien(); }

        // ============================================
        // NÚT ĐẶT SÂN (NÚT XÁC NHẬN LƯU)
        // ============================================
        private void btnDatSan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra trống
            if (cboLoaiSan.SelectedItem == null || cboGioDa.SelectedItem == null || cboSoPhutDa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng lựa chọn đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy dữ liệu
            string loaiSan = cboLoaiSan.SelectedItem.ToString();
            DateTime ngayDa = dtpNgayDa.Value.Date;
            string gioDa = cboGioDa.SelectedItem.ToString();
            int soPhut = int.Parse(cboSoPhutDa.SelectedItem.ToString());

            double donGia = 150000;
            if (loaiSan.Contains("7")) donGia = 250000;
            else if (loaiSan.Contains("11")) donGia = 500000;

            double thanhTien = (soPhut / 60.0) * donGia;

            // 3. Tiến hành lưu xuống SQL
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();

                    // Kiểm tra trùng lịch đặt
                    string queryCheck = "SELECT COUNT(*) FROM DatSan WHERE LoaiSan = @LoaiSan AND NgayDa = @NgayDa AND GioDa = @GioDa";
                    using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@LoaiSan", loaiSan);
                        cmdCheck.Parameters.AddWithValue("@NgayDa", ngayDa);
                        cmdCheck.Parameters.AddWithValue("@GioDa", gioDa);

                        if ((int)cmdCheck.ExecuteScalar() > 0)
                        {
                            MessageBox.Show($"Loại [ {loaiSan} ] vào lúc [ {gioDa} ] ngày [ {ngayDa.ToString("dd/MM/yyyy")} ] đã hết chỗ!", "Trùng lịch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Chèn vào lịch sử bảng DatSan
                    string queryInsert = "INSERT INTO DatSan (LoaiSan, NgayDa, GioDa, SoPhutDa, ThanhTien) VALUES (@LoaiSan, @NgayDa, @GioDa, @SoPhutDa, @ThanhTien)";
                    using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@LoaiSan", loaiSan);
                        cmdInsert.Parameters.AddWithValue("@NgayDa", ngayDa);
                        cmdInsert.Parameters.AddWithValue("@GioDa", gioDa);
                        cmdInsert.Parameters.AddWithValue("@SoPhutDa", soPhut);
                        cmdInsert.Parameters.AddWithValue("@ThanhTien", thanhTien);
                        cmdInsert.ExecuteNonQuery();
                    }

                    // Cập nhật thông tin chi tiết sang bảng hiển thị SanBong
                    string queryUpdate = "UPDATE TOP (1) SanBong SET TrangThai = N'Có người', NgayDa = @NgayDa, GioDa = @GioDa, SoPhutDa = @SoPhutDa, GiaSan = @GiaSan WHERE LoaiSan = @LoaiSan AND (TrangThai = N'Trống' OR TrangThai = N'Còn Trống' OR TrangThai IS NULL)";
                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@LoaiSan", loaiSan);
                        cmdUpdate.Parameters.AddWithValue("@NgayDa", ngayDa);
                        cmdUpdate.Parameters.AddWithValue("@GioDa", gioDa);
                        cmdUpdate.Parameters.AddWithValue("@SoPhutDa", soPhut);
                        cmdUpdate.Parameters.AddWithValue("@GiaSan", donGia);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"[ ĐẶT SÂN THÀNH CÔNG! ]\n\n• Loại sân: {loaiSan}\n• Ngày đá: {ngayDa.ToString("dd/MM/yyyy")}\n• Giờ đá: {gioDa}\n---------------------------\n• TỔNG TIỀN: {thanhTien.ToString("N0")} VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ĐÓNG FORM ĐẶT SÂN LẠI ĐỂ QUAY VỀ MÀN HÌNH QUẢN LÝ
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}