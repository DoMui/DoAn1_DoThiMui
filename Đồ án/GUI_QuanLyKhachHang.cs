using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace Đồ_án
{
    public partial class GUI_QuanLyKhachHang : Form
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        public GUI_QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void GUI_QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = buskh.getKhachHang();
            dgvKH.Columns["maKH"].HeaderText = "Mã khách hàng";
            dgvKH.Columns["tenKH"].HeaderText = "Tên khách hàng";
            dgvKH.Columns["sdtKH"].HeaderText = "Số điện thoại";
            dgvKH.Columns["diachiKH"].HeaderText = "Địa chỉ";
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaKH.Text);
            string ten = txtTenKH.Text;
            string sdt = txtSDTKH.Text;
            string dc = txtDiaChi.Text;
            

            DTO_KhachHang KH = new DTO_KhachHang(ma, ten, sdt, dc);
            if (buskh.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (buskh.themKH(KH) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvKH.DataSource = buskh.getKhachHang();
                }
            }

            
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaKH.Text = dgvKH[0, hang].Value.ToString();
            txtTenKH.Text = dgvKH[1, hang].Value.ToString();
            txtSDTKH.Text = dgvKH[2, hang].Value.ToString();
            txtDiaChi.Text = dgvKH[3, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaKH.Text);
            string ten = txtTenKH.Text;
            string sdt = txtSDTKH.Text;
            string dc = txtDiaChi.Text;

            DTO_KhachHang KH = new DTO_KhachHang(ma, ten, sdt, dc);

            if (buskh.suaKH(KH) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvKH.DataSource = buskh.getKhachHang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaKH.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (buskh.xoaKH(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvKH.DataSource = buskh.getKhachHang();
                }
            }
        }

        private void btnTKKH_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKKH.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdoMaKH.Checked)
                {
                    int ma = int.Parse(tuKhoa);
                    dt = buskh.TimKiemSanPhamTheoMa(ma);
                }
                else
                {
                    dt = buskh.TimKiemSanPhamTheoTen(tuKhoa);
                }

                dgvKH.DataSource = dt;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
