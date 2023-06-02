using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ThongKe:DBConnec
    {
        //DAL_ThongKe dalTK = new DAL_ThongKe();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable LayDSHDBan()
        {
            conn.Open();
            //da = new SqlDataAdapter("SELECT HDX.maHDX,nv.maNV, HDX.tenNV, HDX.ngayban, Kh.tenKH, Kh.sdtKH, SUM(ct.tongtien) as Tongtien from Hoadonxuat HDX inner join Nhanvien nv on HDX.maNV=nv.maNV inner join Khachhang Kh on Kh.maKH=HDX.maKH inner join CTHoadonxuat ct on ct.maHDX=HDX.maHDX GROUP BY HDX.maHDX,nv.maNV, nv.tenNV, HDX.ngayban, Kh.tenKH, Kh.sdtKH, ct.tongtien", conn);
            da = new SqlDataAdapter("SELECT HDX.maHDX,tenNV,tenKH,ngayban,SUM(ct.tongtien) as [Tổng tiền] from Hoadonxuat HDX inner join Khachhang KH on KH.maKH=HDX.maKH inner join Nhanvien NV on NV.maNV=HDX.maNV inner join ChitietHDX ct on ct.maHDX=HDX.maHDX GROUP BY HDX.maHDX, tenNV, tenKH, ngayban, tongtien", conn);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable timKiemHDTGNgay(DateTime ngay)
        {
            conn.Open();
            // string sqlSearch = "Select * from HoaDonNhap where ngayTao BETWEEN @StartDate AND @EndDate";
            string sql = "SELECT HDX.maHDX,tenNV,tenKH,ngayban,SUM(ct.tongtien) as [Thành tiền] from Hoadonxuat HDX inner join Khachhang KH on KH.maKH=HDX.maKH inner join Nhanvien NV on NV.maNV=HDX.maNV inner join ChitietHDX ct on ct.maHDX=HDX.maHDX where  CONVERT(date, HDX.ngayban)=@Ngay GROUP BY HDX.maHDX, tenNV, tenKH, ngayban, tongtien";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ngay", ngay);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }
        public DataTable timKiemHDTG(DateTime startDate, DateTime endDate)
        {
            conn.Open();
            // string sqlSearch = "Select * from HoaDonNhap where ngayTao BETWEEN @StartDate AND @EndDate";
            string sql = "SELECT HDX.maHDX,tenNV,tenKH,ngayban,SUM(ct.tongtien) as [Thành tiền] from Hoadonxuat HDX inner join Khachhang KH on KH.maKH=HDX.maKH inner join Nhanvien NV on NV.maNV=HDX.maNV inner join ChitietHDX ct on ct.maHDX=HDX.maHDX WHERE HDX.ngayban BETWEEN @StartDate AND @EndDate GROUP BY HDX.maHDX, tenNV, tenKH, ngayban, tongtien";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        ////In hóa đơn
        public DataTable SanPhamBanChay()
        {
            conn.Open();
            string sqlSearch = "SELECT TOP 1 WITH TIES sp.masp as [Mã sản phẩm],sp.tensp as [Tên sản phẩm],SUM(ct.soluong) as [Số lượng bán] From  Sanpham sp INNER JOIN ChitietHDX ct ON sp.masp=ct.masp INNER JOIN Hoadonxuat hdb ON ct.maHDX=hdb.maHDX GROUP BY sp.masp,sp.tensp ORDER BY SUM(ct.soluong) DESC";
            cmd = new SqlCommand(sqlSearch, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
       
    }
}
