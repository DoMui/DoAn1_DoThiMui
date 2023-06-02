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
    public partial class GUI_ThongKe : Form
    {
        BUS_ThongKe bustk = new BUS_ThongKe();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }
        enum SearchType
        {
            ByDate,
            ByDateRange,
            SanPhamHot,
        }
        private SearchType searchType;
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            switch (searchType)
            {
                case SearchType.ByDate:
                    DateTime ngay = dtpNgayTao.Value.Date;
                    DataTable dataTable1 = bustk.timKiemHDTGNgay(ngay);
                    dgvThongKe.DataSource = dataTable1;
                    break;
                case SearchType.ByDateRange:
                    DateTime startDate = dtpTimKiemBD.Value.Date;
                    DateTime endDate = dtpTimKiemKT.Value.Date;
                    DataTable dataTable = bustk.timKiemHDTG(startDate, endDate);
                    dgvThongKe.DataSource = dataTable;
                    break;
                case SearchType.SanPhamHot:
                    DataTable dataTable2 = bustk.SanPhamBanChay();
                    dgvThongKe.DataSource = dataTable2;
                    break;
            }
            
        }

        private void rdoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNgay.Checked)
            {
                searchType = SearchType.ByDate;
                DateTime ngay = dtpNgayTao.Value.Date;
            }
        }

        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThang.Checked)
            {
                searchType = SearchType.ByDateRange;
                DateTime startDate = dtpTimKiemBD.Value.Date;
                DateTime endDate = dtpTimKiemKT.Value.Date;
            }
        }

        private void rdoSPBC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSPBC.Checked)
            {
                searchType = SearchType.SanPhamHot;
                DataTable dataTable = bustk.SanPhamBanChay();
                // dgvThongKe.DataSource=dataTable;
            }
        }

        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = bustk.LayDSHDBan();
            dgvThongKe.Columns["maHDX"].HeaderText = "Mã hóa đơn xuất";
            dgvThongKe.Columns["tenNV"].HeaderText = "Tên nhân viên";
            dgvThongKe.Columns["tenKH"].HeaderText = "Tên khách hàng";
            dgvThongKe.Columns["ngayban"].HeaderText = "Ngày bán";
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgvThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int hang = e.RowIndex;
            //txtMHDX.Text = dgvThongKe[0, hang].Value.ToString();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            //string maHDX = txtMHDX.Text;
            //decimal tongTien = bustk.TinhTongTien(maHDX);
            //txtTT.Text = tongTien.ToString();
        }
    }
}
