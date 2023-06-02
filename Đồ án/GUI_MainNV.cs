using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án
{
    public partial class GUI_MainNV : Form
    {
        public GUI_MainNV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                this.Hide();
                GUI_DangNhap frm = new GUI_DangNhap();
                frm.ShowDialog();
            }
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            GUI_SanPham f = new GUI_SanPham();
            f.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            GUI_QuanLyKhachHang f = new GUI_QuanLyKhachHang();
            f.Show();
        }

        private void btnHDX_Click(object sender, EventArgs e)
        {
            GUI_HoaDonXuat f = new GUI_HoaDonXuat();
            f.Show();
        }
    }
}
