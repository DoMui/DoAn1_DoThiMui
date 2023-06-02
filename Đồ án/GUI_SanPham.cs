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
    public partial class GUI_SanPham : Form
    {
        BUS_SanPham bussp = new BUS_SanPham();
        public GUI_SanPham()
        {
            InitializeComponent();
            
        }

        private void GUI_SanPham_Load(object sender, EventArgs e)
        {
            dgvQLSP.DataSource = bussp.getSanPham();
            dgvQLSP.Columns["masp"].HeaderText = "Mã sản phẩm";
            dgvQLSP.Columns["tensp"].HeaderText = "Tên sản phẩm";
            dgvQLSP.Columns["gia"].HeaderText = "Giá";
            dgvQLSP.Columns["soluong"].HeaderText = "Số lượng";
            dgvQLSP.Columns["xuatxu"].HeaderText = "Xuất xứ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaSP.Text);
            string ten = txtTenSP.Text;
            float gia = float.Parse(txtGiaBan.Text);
            float sl = float.Parse(txtSoLuong.Text);
            string xx = txtXuatXu.Text;

            DTO_SanPham SP = new DTO_SanPham(ma, ten, gia, sl, xx);
            //if(bussp.kiemtramatrung(ma)==1)
            //{
            //    MessageBox.Show("Mã trùng");
            //}    
            //else
            //{
            //    if (bussp.themSP(SP) == true)
            //    {
            //        MessageBox.Show("Thêm thành công!");
            //        dgvQLSP.DataSource = bussp.getSanPham();
            //    }
            //}
            if (bussp.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                int result = bussp.themSP(SP);
                if (result == -1)
                {
                    MessageBox.Show("Giá không được nhỏ hơn 0");
                }
                else if (result == -2)
                {
                    MessageBox.Show("Số lượng không được nhỏ hơn 0");
                }
                else if (result == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvQLSP.DataSource = bussp.getSanPham();
                }
            }
        }

        private void dgvQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaSP.Text=dgvQLSP[0,hang].Value.ToString();
            txtTenSP.Text=dgvQLSP[1,hang].Value.ToString();
            txtGiaBan.Text=dgvQLSP[2,hang].Value.ToString();
            txtSoLuong.Text=dgvQLSP[3,hang].Value.ToString();
            txtXuatXu.Text=dgvQLSP[4,hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaSP.Text);
            string ten = txtTenSP.Text;
            float gia = float.Parse(txtGiaBan.Text);
            float sl = float.Parse(txtSoLuong.Text);
            string xx = txtXuatXu.Text;

            DTO_SanPham SP = new DTO_SanPham(ma, ten, gia, sl, xx);

            //if (bussp.suaSP(SP) == true)
            //{
            //    MessageBox.Show("Sửa thành công!");
            //    dgvQLSP.DataSource = bussp.getSanPham();
            //}

            int result = bussp.suaSP(SP);
            if (result == -1)
            {
                MessageBox.Show("Giá không được nhỏ hơn 0");
            }
            else if (result == -2)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0");
            }
            else if (result == 1)
            {
                MessageBox.Show("Sửa thành công!");
                dgvQLSP.DataSource = bussp.getSanPham();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaSP.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (bussp.xoaSP(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvQLSP.DataSource = bussp.getSanPham();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKSP.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdoMaSP.Checked)
                {
                    int ma = int.Parse(tuKhoa);
                    dt = bussp.TimKiemSanPhamTheoMa(ma);
                }
                else
                {
                    dt = bussp.TimKiemSanPhamTheoTen(tuKhoa);
                }

                dgvQLSP.DataSource = dt;
            }
        }
        
    }
}
