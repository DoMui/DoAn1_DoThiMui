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
    public partial class GUI_CTHoaDonXuat : Form
    {
        BUS_CTHoaDonXuat busCTHDX = new BUS_CTHoaDonXuat();
        private BUS_HoaDonXuat busHDX = new BUS_HoaDonXuat();
        private BUS_SanPham bussp = new BUS_SanPham();
        public GUI_CTHoaDonXuat()
        {
            InitializeComponent();
            txtMaHDB.Text = maHDX.ToString();
        }

        private void GUI_CTHoaDonXuat_Load(object sender, EventArgs e)
        {
            dgvCTHDB.DataSource = busCTHDX.getCTHDX();
            txtMaHDB.Text = maHDX.ToString();
            dgvCTHDB.Columns["maCTHDX"].HeaderText = "Mã chi tiết hóa đơn xuất";
            dgvCTHDB.Columns["maHDX"].HeaderText = "Mã hóa đơn xuất";
            dgvCTHDB.Columns["masp"].HeaderText = "Mã sản phẩm";
            dgvCTHDB.Columns["soluong"].HeaderText = "Số lượng";
            dgvCTHDB.Columns["gia"].HeaderText = "Giá";
            dgvCTHDB.Columns["tongtien"].HeaderText = "Tổng tiền";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            int maCTHDX = int.Parse(txtMaCTHDB.Text);
            int maHDX = int.Parse(txtMaHDB.Text);
            string masp = txtSP.Text;
            int sl = int.Parse(txtSL.Text);
            

            // Kiểm tra sự tồn tại của mã hóa đơn nhập và mã sản phẩm trong cơ sở dữ liệu
            if (!busHDX.KiemTraTonTaiHoaDonXuat(maHDX))
            {
                MessageBox.Show("Mã hóa đơn xuất không tồn tại!");
                return;
            }

            decimal gia = bussp.LayGiaSanPham(masp);

            if (!bussp.KiemTraTonTaiSanPham(masp))
            {
                MessageBox.Show("Mã sản phẩm không tồn tại!");
                return;
            }

            // Tính tổng tiền
            decimal tongTien = sl * gia;

            // Tạo đối tượng DTO_ChiTietHoaDonNhap
            DTO_CTHoaDonXuat CTHDX = new DTO_CTHoaDonXuat(maCTHDX, maHDX, masp, sl, gia, tongTien);

            
            if (busCTHDX.kiemtramatrung(maCTHDX) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                int result = busCTHDX.themCTHDX(CTHDX);
                if (result == -2)
                {
                    MessageBox.Show("Số lượng không được nhỏ hơn 0");
                }
                else if (result == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvCTHDB.DataSource = busCTHDX.getCTHDX();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maCTHDX = int.Parse(txtMaCTHDB.Text);
            int maHDX = int.Parse(txtMaHDB.Text);
            string masp = txtSP.Text;
            int sl = int.Parse(txtSL.Text);
            //decimal gia = decimal.Parse(txtGia.Text);

            decimal gia = bussp.LayGiaSanPham(masp);

            bool isMaHDNValid = busHDX.KiemTraTonTaiHoaDonXuat(maHDX);
            bool isMaSPValid = bussp.KiemTraTonTaiSanPham(masp);

            if (!isMaHDNValid)
            {
                MessageBox.Show("Mã hóa đơn xuất không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            if (!isMaSPValid)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại trong cơ sở dữ liệu!");
                return;
            }


            // Tính tổng tiền
            decimal tongTien = sl * gia;

            // Tạo đối tượng DTO_ChiTietHoaDonNhap
            DTO_CTHoaDonXuat CTHDX = new DTO_CTHoaDonXuat(maCTHDX, maHDX, masp, sl, gia, tongTien);

            // Thực hiện thêm chi tiết hóa đơn nhập vào cơ sở dữ liệu
            
            int result = busCTHDX.suaCTHDX(CTHDX);
            if (result == -2)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0");
            }
            else if (result == 1)
            {
                MessageBox.Show("Sửa thành công!");
                dgvCTHDB.DataSource = busCTHDX.getCTHDX();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maCTHDX = int.Parse(txtMaCTHDB.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busCTHDX.xoaCTHDX(maCTHDX) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvCTHDB.DataSource = busCTHDX.getCTHDX();
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

        private void dgvCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaCTHDB.Text = dgvCTHDB[0, hang].Value.ToString();
            txtMaHDB.Text = dgvCTHDB[1, hang].Value.ToString();
            txtSP.Text = dgvCTHDB[2, hang].Value.ToString();
            txtSL.Text = dgvCTHDB[3, hang].Value.ToString();
        }
        public int maHDX { get; set; }

        private void btnTT_Click(object sender, EventArgs e)
        {
            string maHDX = txtMaHDB.Text;
            decimal tongTien = busCTHDX.TinhTongTien(maHDX);
            txtTT.Text = tongTien.ToString();
        }
    }
}
