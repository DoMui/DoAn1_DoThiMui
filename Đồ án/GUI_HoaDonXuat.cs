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
    public partial class GUI_HoaDonXuat : Form
    {
        private BUS_HoaDonXuat busHDX = new BUS_HoaDonXuat();
        private BUS_NhanVien busnv = new BUS_NhanVien();
        private BUS_KhachHang busKH = new BUS_KhachHang();
        public GUI_HoaDonXuat()
        {
            InitializeComponent();
        }

        private void GUI_HoaDonXuat_Load(object sender, EventArgs e)
        {
            dgvHDB.DataSource = busHDX.getHoaDonXuat();
            dgvHDB.Columns["maHDX"].HeaderText = "Mã hóa đơn xuất";
            dgvHDB.Columns["maNV"].HeaderText = "Mã nhân viên";
            dgvHDB.Columns["maKH"].HeaderText = "Mã khách hàng";
            dgvHDB.Columns["ngayban"].HeaderText = "Ngày bán";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int maHDX = int.Parse(txtMaHDB.Text);
            int maNV = int.Parse(txtMaNV.Text);
            int maKH = int.Parse(txtMaKH.Text);
            DateTime ngayban = dateNgayBan.Value;


            if (!busnv.KiemTraTonTaiMaNhanVien(maNV))
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            // Kiểm tra sự tồn tại của mã KH trong cơ sở dữ liệu
            if (!busKH.KiemTraTonTaiMaKhachHang(maKH))
            {
                MessageBox.Show("Mã khách hàng không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            DTO_HoaDonXuat HDX = new DTO_HoaDonXuat(maHDX, maNV, maKH, ngayban);
            if (busHDX.kiemtramatrung(maHDX) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (busHDX.themHDX(HDX) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvHDB.DataSource = busHDX.getHoaDonXuat();
                    GUI_CTHoaDonXuat f = new GUI_CTHoaDonXuat();
                    f.maHDX = maHDX;
                    f.Show();
                }
            }
        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaHDB.Text = dgvHDB[0, hang].Value.ToString();
            txtMaNV.Text = dgvHDB[1, hang].Value.ToString();
            txtMaKH.Text = dgvHDB[2, hang].Value.ToString();
            dateNgayBan.Text = dgvHDB[3, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maHDX = int.Parse(txtMaHDB.Text);
            int maNV = int.Parse(txtMaNV.Text);
            int maKH = int.Parse(txtMaKH.Text);
            DateTime ngayban = dateNgayBan.Value;


            bool isMaNhanVienValid = busnv.KiemTraTonTaiMaNhanVien(maNV);
            bool isMaKhachHangValid = busKH.KiemTraTonTaiMaKhachHang(maKH);

            if (!isMaNhanVienValid)
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            if (!isMaKhachHangValid)
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại trong cơ sở dữ liệu!");
                return;
            }


            DTO_HoaDonXuat HDX = new DTO_HoaDonXuat(maHDX, maNV, maKH, ngayban);

            if (busHDX.suaHDX(HDX) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvHDB.DataSource = busHDX.getHoaDonXuat();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maHDX = int.Parse(txtMaHDB.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busHDX.xoaHDX(maHDX) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvHDB.DataSource = busHDX.getHoaDonXuat();
                }
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

        private void btnTKHDB_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKHDB.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdoTKMHDB.Checked)
                {
                    int ma = int.Parse(tuKhoa);
                    dt = busHDX.TimKiemSanPhamTheoMa(tuKhoa);
                }
                else
                {
                    dt = busHDX.TimKiemSanPhamTheoTen(tuKhoa);
                }

                dgvHDB.DataSource = dt;
            }
        }

        private void btnChitietHDB_Click(object sender, EventArgs e)
        {
            GUI_CTHoaDonXuat f = new GUI_CTHoaDonXuat();
            f.Show();
        }
        public int maHDX { get; set; }
    }
}
