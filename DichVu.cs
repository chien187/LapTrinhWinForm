using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DichVu : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLySanBong.mdf;Integrated Security=True";

        public DichVu()
        {
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ao = comboBox1.Text == "Áo";
            bool quan = comboBox1.Text == "Quần";
            // Nút áo
            button2.Visible = ao;
            button3.Visible = ao;
            button6.Visible = ao;
            button7.Visible = ao;
            // Nút quần
            button4.Visible = quan;
            button5.Visible = quan;
            button8.Visible = quan;
            button9.Visible = quan;
        }
        string tenDo = "";
        int donGia = 0;
        private void btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            Button btn = sender as Button;

            tenDo = btn.Text;

            donGia = Convert.ToInt32(btn.Tag);

            TinhTien();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        void TinhTien()
        {
            int soLuong = (int)numericUpDown1.Value;

            int soGio = (int)numericUpDown2.Value;

            int tongTien =
                donGia * soLuong * soGio;

            textBox3.Text =
                tongTien.ToString("N0") + " VNĐ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Thanh toán thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            int soLuong = (int)numericUpDown1.Value;

            int soGio = (int)numericUpDown2.Value;

            int thanhTien =
                donGia * soLuong * soGio;

            dataGridView1.Rows.Add(
                tenDo,
                soLuong,
                soGio,
                comboBox3.Text,
                thanhTien + " VNĐ"
            );
        }
        string tenSp = "";
        int dongia = 0;
        private void all_click(object sender, EventArgs e)
        {
            panel2.Visible = true;

            Button btn = sender as Button;

            tenSp = btn.Text;

            dongia = Convert.ToInt32(btn.Tag);
        
            Tinhtien();
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Tinhtien();
        }
        void Tinhtien()
        {
            int soLuong = (int)numericUpDown3.Value;
            int tongTien =
                dongia * soLuong ;
            textBox6.Text =
                tongTien.ToString("N0") + " VNĐ";
        }
        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Thanh toán thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private void button20_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;

            int soLuong = (int)numericUpDown3.Value;

            int thanhTien = dongia * soLuong;

            dataGridView2.Rows.Add(
                tenSp,
                soLuong,
                thanhTien.ToString("N0") + " VNĐ"
            );
        }

       

        
    }
}
