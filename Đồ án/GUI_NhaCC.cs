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
    public partial class GUI_NhaCC : Form
    {
        BUS_NhaCC busncc = new BUS_NhaCC();
        public GUI_NhaCC()
        {
            InitializeComponent();
        }

        private void lblTKNCC_Click(object sender, EventArgs e)
        {

        }

        private void GUI_NhaCC_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busncc.getNhaCC();
            dgvNCC.Columns["maNCC"].HeaderText = "Mã nhà cung cấp";
            dgvNCC.Columns["tenNCC"].HeaderText = "Tên nhà cung cấp";
            dgvNCC.Columns["sdtNCC"].HeaderText = "Số điện thoại";
            dgvNCC.Columns["diachiNCC"].HeaderText = "Địa chỉ";
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaNCC.Text);
            string ten = txtTenNCC.Text;
            string sdt = txtSDTNCC.Text;
            string dc = txtDCNCC.Text;


            DTO_NhaCC NCC = new DTO_NhaCC(ma, ten, sdt, dc);
            if (busncc.kiemtramatrung(ma) == 1)
            {
                MessageBox.Show("Mã trùng");
            }
            else
            {
                if (busncc.themNCC(NCC) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvNCC.DataSource = busncc.getNhaCC();
                }
            }

            
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaNCC.Text = dgvNCC[0, hang].Value.ToString();
            txtTenNCC.Text = dgvNCC[1, hang].Value.ToString();
            txtSDTNCC.Text = dgvNCC[2, hang].Value.ToString();
            txtDCNCC.Text = dgvNCC[3, hang].Value.ToString();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaNCC.Text);
            string ten = txtTenNCC.Text;
            string sdt = txtSDTNCC.Text;
            string dc = txtDCNCC.Text;

            DTO_NhaCC NCC = new DTO_NhaCC(ma, ten, sdt, dc);

            if (busncc.suaNCC(NCC) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvNCC.DataSource = busncc.getNhaCC();
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaNCC.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                if (busncc.xoaNCC(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvNCC.DataSource = busncc.getNhaCC();
                }
            }
        }

        private void btnTKNCC_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKNCC.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                DataTable dt;
                if (rdoMaNCC.Checked)
                {
                    int ma = int.Parse(tuKhoa);
                    dt = busncc.TimKiemSanPhamTheoMa(ma);
                }
                else
                {
                    dt = busncc.TimKiemSanPhamTheoTen(tuKhoa);
                }

                dgvNCC.DataSource = dt;
            }
        }

        private void btnThoatNCC_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
