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
    public class DAL_HoaDonNhap : DBConnec
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dskh ra ngoài màn hình
        public DataTable getHoaDonNhap()
        {
            conn.Open();
            da = new SqlDataAdapter("Select * from Hoadonnhap", conn);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int kiemtramatrung(int maHDN)
        {
            int i = 0;
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Hoadonnhap WHERE maHDN = @MaHDN";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHDN", maHDN);
                i = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                // Xử lý lỗi kết nối
            }
            finally
            {
                conn.Close();
            }
            return i;
        }

        public bool themHDN(DTO_HoaDonNhap HDN)
        {
            string ngay = string.Format("{0}/{1}/{2}", HDN.ngaynhap.Year, HDN.ngaynhap.Month, HDN.ngaynhap.Day);
            string sql = "Insert into Hoadonnhap values(N'" + HDN.maHDN + "',N'" + HDN.maNV + "',N'" + HDN.maNCC + "',N'" + ngay + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaHDN(DTO_HoaDonNhap HDN)
        {
            string ngay = string.Format("{0}/{1}/{2}", HDN.ngaynhap.Year, HDN.ngaynhap.Month, HDN.ngaynhap.Day);
            string sql = "Update Hoadonnhap set maNV = N'" + HDN.maNV + "', maNCC = '" + HDN.maNCC + "',ngaynhap = '"+ngay+"' where maHDN = '" + HDN.maHDN + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaHDN(int maHDN)
        {
            {
                string sql = "Delete from Hoadonnhap where maHDN = '" + maHDN + "'";

                thucthisql(sql);
                return true;
            }
        }



        //
        public DataTable TimKiemSanPhamTheoMa(string maHDN)
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM Hoadonnhap WHERE maHDN = @MaHDN", conn);
            da.SelectCommand.Parameters.AddWithValue("@MaHDN", maHDN);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable TimKiemSanPhamTheoTen(string maNV)
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM Hoadonnhap WHERE maNV LIKE '%' + @MaNV + '%'", conn);
            da.SelectCommand.Parameters.AddWithValue("@MaNV", maNV);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //
        public bool KiemTraTonTaiHoaDonNhap(int maHoaDonNhap)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Hoadonnhap WHERE maHDN = @MaHoaDonNhap", conn);
            cmd.Parameters.AddWithValue("@MaHoaDonNhap", maHoaDonNhap);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            return count > 0;
        }
        //
        public int ThemHoaDonNhap(DTO_HoaDonNhap HDN)
        {
            string query = $"INSERT INTO Hoadonnhap(maHDN, maNV,maNCC, ngaynhap) VALUES({HDN.maHDN}, {HDN.maNV}, {HDN.maNCC}, '{HDN.ngaynhap.ToString("yyyy-MM-dd")}')";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                // Lấy mã hóa đơn nhập vừa thêm và trả về
                query = "SELECT IDENT_CURRENT('HoaDonNhap')";
                cmd.CommandText = query;
                int maHDN = Convert.ToInt32(cmd.ExecuteScalar());

                return maHDN;
            }
            catch (Exception)
            {
                // Xử lý ngoại lệ (Exception)
                // ...
            }
            finally
            {
                conn.Close();
            }

            return -1; // Trả về -1 nếu có lỗi
        }
    }
}
