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
    public partial class GUI_QuanLyNhanVien : Form
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        public GUI_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void GUI_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvQLNV.DataSource = busnv.getNhanVien();
            dgvQLNV.Columns["maNV"].HeaderText = "Mã nhân viên";
            dgvQLNV.Columns["tenNV"].HeaderText = "Tên nhân viên";
            dgvQLNV.Columns["sdtNV"].HeaderText = "Số điện thoại";
            dgvQLNV.Columns["matkhau"].HeaderText = "Mật khẩu";
            dgvQLNV.Columns["chucvu"].HeaderText = "Chức vụ";
            dgvQLNV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvQLNV.Columns["gioitinh"].HeaderText = "Giới tính";
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtManv.Text);
            string ten = txtTenNV.Text;
            string sdt = txtSDTNV.Text;
            string mk = txtMKNV.Text;
            string cv = cboCV.SelectedItem.ToString();
            DateTime ngs = DateTime.Parse(dtNSNV.Value.ToShortDateString());
            
            string gt = cboGT.SelectedItem != null ? cboGT.SelectedItem.ToString() : string.Empty;

            DTO_NhanVien NV = new DTO_NhanVien(ma, ten, sdt, mk, cv, ngs, gt);
            if (busnv.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (busnv.themNV(NV) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvQLNV.DataSource = busnv.getNhanVien();
                }
            }
        }

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtManv.Text = dgvQLNV[0, hang].Value.ToString();
            txtTenNV.Text = dgvQLNV[1, hang].Value.ToString();
            txtSDTNV.Text = dgvQLNV[2, hang].Value.ToString();
            txtMKNV.Text = dgvQLNV[3, hang].Value.ToString();
            cboCV.SelectedItem = dgvQLNV[4, hang].Value.ToString();
            dtNSNV.Text = dgvQLNV[5, hang].Value.ToString();
            cboGT.SelectedItem = dgvQLNV[6, hang].Value.ToString();
        }

        private void btnSuanv_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtManv.Text);
            string ten = txtTenNV.Text;
            string sdt = txtSDTNV.Text;
            string mk = txtMKNV.Text;
            string cv = cboCV.SelectedItem.ToString();
            DateTime ngs = DateTime.Parse(dtNSNV.Value.ToShortDateString());
            string gt = cboGT.SelectedItem != null ? cboGT.SelectedItem.ToString() : string.Empty;


            DTO_NhanVien NV = new DTO_NhanVien(ma, ten, sdt, mk, cv, ngs, gt);

            if (busnv.suaNV(NV) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvQLNV.DataSource = busnv.getNhanVien();
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtManv.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busnv.xoaNV(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvQLNV.DataSource = busnv.getNhanVien();
                }
            }
        }

        private void btnTKNV_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKNV.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdoMaNV.Checked)
                {
                    int ma = int.Parse(tuKhoa);
                    dt = busnv.TimKiemSanPhamTheoMa(ma);
                }
                else
                {
                    dt = busnv.TimKiemSanPhamTheoTen(tuKhoa);
                }

                dgvQLNV.DataSource = dt;
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
