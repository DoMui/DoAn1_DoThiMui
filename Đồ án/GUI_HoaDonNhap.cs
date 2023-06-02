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
    public partial class GUI_HoaDonNhap : Form
    {
        private BUS_HoaDonNhap busHDN = new BUS_HoaDonNhap();
        private BUS_NhanVien busnv = new BUS_NhanVien();
        private BUS_NhaCC busNCC = new BUS_NhaCC();
        public GUI_HoaDonNhap()
        {
            InitializeComponent();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int maHDN = int.Parse(txtMaHDN.Text);
            int maNV = int.Parse(txtMaNV.Text);
            int maNCC = int.Parse(txtMaNCC.Text);
            DateTime ngayNhap = dtNgayNhap.Value;


            if (!busnv.KiemTraTonTaiMaNhanVien(maNV))
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            // Kiểm tra sự tồn tại của mã nhà cung cấp trong cơ sở dữ liệu
            if (!busNCC.KiemTraTonTaiMaNhaCungCap(maNCC))
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            DTO_HoaDonNhap HDN = new DTO_HoaDonNhap(maHDN, maNV, maNCC, ngayNhap);
            if (busHDN.kiemtramatrung(maHDN) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (busHDN.themHDN(HDN) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvHDN.DataSource = busHDN.getHoaDonNhap();
                    //
                    GUI_CTHoaDonNhap f = new GUI_CTHoaDonNhap();
                    f.maHDN = maHDN;
                    f.Show();
                    //
                }
            }
        }

        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaHDN.Text = dgvHDN[0, hang].Value.ToString();
            txtMaNV.Text = dgvHDN[1, hang].Value.ToString();
            txtMaNCC.Text = dgvHDN[2, hang].Value.ToString();
            dtNgayNhap.Text = dgvHDN[3, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maHDN = int.Parse(txtMaHDN.Text);
            int maNV = int.Parse(txtMaNV.Text);
            int maNCC = int.Parse(txtMaNCC.Text);
            DateTime ngayNhap = dtNgayNhap.Value;


            bool isMaNhanVienValid = busnv.KiemTraTonTaiMaNhanVien(maNV);
            bool isMaNhaCungCapValid = busNCC.KiemTraTonTaiMaNhaCungCap(maNCC);

            if (!isMaNhanVienValid)
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            if (!isMaNhaCungCapValid)
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại trong cơ sở dữ liệu!");
                return;
            }


            DTO_HoaDonNhap HDN = new DTO_HoaDonNhap(maHDN, maNV, maNCC, ngayNhap);

            if (busHDN.suaHDN(HDN) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvHDN.DataSource = busHDN.getHoaDonNhap();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maHDN = int.Parse(txtMaHDN.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busHDN.xoaHDN(maHDN) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvHDN.DataSource = busHDN.getHoaDonNhap();
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

        private void GUI_HoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvHDN.DataSource = busHDN.getHoaDonNhap();
            dgvHDN.Columns["maHDN"].HeaderText = "Mã hóa đơn nhập";
            dgvHDN.Columns["maNV"].HeaderText = "Mã nhân viên";
            dgvHDN.Columns["maNCC"].HeaderText = "Mã nhà cung cấp";
            dgvHDN.Columns["ngaynhap"].HeaderText = "Ngày nhập";
        }

        private void btnTKHDN_Click(object sender, EventArgs e)
        {

            string tuKhoa = txtTKHDN.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdoTKMHDN.Checked)
                {
                    int ma = int.Parse(tuKhoa);
                    dt = busHDN.TimKiemSanPhamTheoMa(tuKhoa);
                }
                else
                {
                    dt = busHDN.TimKiemSanPhamTheoTen(tuKhoa);
                }

                dgvHDN.DataSource = dt;
            }
        }

        private void btnChitietHDN_Click(object sender, EventArgs e)
        {
            GUI_CTHoaDonNhap f = new GUI_CTHoaDonNhap();
            f.Show();
        }
        public int maHDN { get; set; }
    }
}
