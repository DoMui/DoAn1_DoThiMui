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
    public class DAL_SanPham : DBConnec
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dssp ra ngoài màn hình
        public DataTable getSanPham()
        {
            conn.Open();
            da = new SqlDataAdapter("Select * from Sanpham", conn);
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
        public int kiemtramatrung(int ma)
        {
            int i = 0;
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Sanpham WHERE masp = @MaSP";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSP", ma);
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

        //public bool themSP(DTO_SanPham SP)
        //{
        //    string sql = "Insert into Sanpham values(N'" + SP.masp + "',N'" + SP.tensp + "',N'" + SP.gia + "','" + SP.soluong + "',N'" + SP.xuatxu + "')";

        //    thucthisql(sql);
        //    return true;
        //}
        //public bool suaSP(DTO_SanPham SP)
        //{

        //    string sql = "Update Sanpham set tensp = N'"+SP.tensp+"', gia = '"+SP.gia+"',soluong = '"+SP.soluong+"', xuatxu = N'"+SP.xuatxu+"' where masp = '"+SP.masp+"'";

        //    thucthisql(sql);
        //    return true;
        //}

        //
        public int themSP(DTO_SanPham SP)
        {
            if (SP.gia < 0)
            {
                // Trả về mã lỗi -1 cho giá âm
                return -1;
            }

            if (SP.soluong < 0)
            {
                // Trả về mã lỗi -2 cho số lượng âm
                return -2;
            }

            string sql = "Insert into Sanpham values(N'" + SP.masp + "',N'" + SP.tensp + "',N'" + SP.gia + "','" + SP.soluong + "',N'" + SP.xuatxu + "')";
            thucthisql(sql);

            // Trả về mã thành công 1
            return 1;
        }

        public int suaSP(DTO_SanPham SP)
        {
            if (SP.gia < 0)
            {
                // Trả về mã lỗi -1 cho giá âm
                return -1;
            }

            if (SP.soluong < 0)
            {
                // Trả về mã lỗi -2 cho số lượng âm
                return -2;
            }

            string sql = "Update Sanpham set tensp = N'" + SP.tensp + "', gia = '" + SP.gia + "',soluong = '" + SP.soluong + "', xuatxu = N'" + SP.xuatxu + "' where masp = '" + SP.masp + "'";
            thucthisql(sql);

            // Trả về mã thành công 1
            return 1;
        }
        //

        public bool xoaSP(int ma)
        {
            {
                string sql = "Delete from Sanpham where masp = '"+ma+"'";

                thucthisql(sql);
                return true;
            }
        }



        //
        public DataTable TimKiemSanPhamTheoMa(int ma)
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM Sanpham WHERE masp = @MaSP", conn);
            da.SelectCommand.Parameters.AddWithValue("@MaSP", ma);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable TimKiemSanPhamTheoTen(string ten)
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM Sanpham WHERE tensp LIKE '%' + @TenSP + '%'", conn);
            da.SelectCommand.Parameters.AddWithValue("@TenSP", ten);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //
        public bool KiemTraTonTaiSanPham(string maSP)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Sanpham WHERE masp = @masp", conn);
            cmd.Parameters.AddWithValue("@masp", maSP);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            return count > 0;
        }
        //
        public decimal LayGiaSanPham(string masp)
        {
            string query = "SELECT gia FROM Sanpham WHERE masp = @masp";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@masp", masp);
            conn.Open();
            decimal gia = Convert.ToDecimal(cmd.ExecuteScalar());
            conn.Close();
            return gia;
        }
        //
        public void ThemSoLuongSanPham(string masp, int soluong)
        {
            string sql = "Update Sanpham Set soluong = soluong + " + soluong + " Where masp = N'" + masp + "'";
            thucthisql(sql);
        }
        public void GiamSoLuongSanPham(string masp, int soluong)
        {
            string sql = "Update Sanpham Set soluong = soluong - " + soluong + " Where masp = N'" + masp + "'";
            thucthisql(sql);
        }
    }
}
