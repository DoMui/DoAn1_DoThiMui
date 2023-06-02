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
    public class DAL_CTHoaDonNhap : DBConnec
    {
        DAL_SanPham dasp = new DAL_SanPham();

        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dskh ra ngoài màn hình
        public DataTable getCTHDN()
        {
            conn.Open();
            da = new SqlDataAdapter("Select * from ChitietHDN", conn);
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
        public int kiemtramatrung(int maCTHDN)
        {
            int i = 0;
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM ChitietHDN WHERE maCTHDN = @MaCTHDN";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaCTHDN", maCTHDN);
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

        public int themCTHDN(DTO_CTHoaDonNhap CTHDN)
        {

            //string sql = "Insert into ChitietHDN values(N'" + CTHDN.maCTHDN + "',N'" + CTHDN.maHDN + "',N'" + CTHDN.masp + "',N'" + CTHDN.soluong + "','" + CTHDN.gia + "','" + CTHDN.tongtien + "')";

            //thucthisql(sql);
            //return true;

            if (CTHDN.soluong < 0)
            {
                // Trả về mã lỗi -2 cho số lượng âm
                return -2;
            }

            string sql = "Insert into ChitietHDN values(N'" + CTHDN.maCTHDN + "',N'" + CTHDN.maHDN + "',N'" + CTHDN.masp + "',N'" + CTHDN.soluong + "','" + CTHDN.gia + "','" + CTHDN.tongtien + "')";
            thucthisql(sql);

            // Trả về mã thành công 1
            return 1;
        }
        public int suaCTHDN(DTO_CTHoaDonNhap CTHDN)
        {

            //string sql = "Update ChitietHDN set maHDN = N'" + CTHDN.maHDN + "', masp = '" + CTHDN.masp + "',soluong = '" + CTHDN.soluong + "',gia = '"+CTHDN.gia+"',tongtien = '"+CTHDN.tongtien+"' where maCTHDN = '" + CTHDN.maCTHDN + "'";

            //thucthisql(sql);
            //return true;

            if (CTHDN.soluong < 0)
            {
                // Trả về mã lỗi -2 cho số lượng âm
                return -2;
            }

            string sql = "Update ChitietHDN set maHDN = N'" + CTHDN.maHDN + "', masp = '" + CTHDN.masp + "',soluong = '" + CTHDN.soluong + "',gia = '" + CTHDN.gia + "',tongtien = '" + CTHDN.tongtien + "' where maCTHDN = '" + CTHDN.maCTHDN + "'";
            thucthisql(sql);
            //
            dasp.ThemSoLuongSanPham(CTHDN.masp, CTHDN.soluong);
            //
            // Trả về mã thành công 1
            
            return 1;
        }
        public bool xoaCTHDN(int maCTHDN)
        {
            {
                string sql = "Delete from ChitietHDN where maCTHDN = '" + maCTHDN + "'";

                thucthisql(sql);
                return true;
            }
        }
        //

        public decimal TinhTongTien(string maHDN)
        {

            decimal Tongtien = 0;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT SUM(tongtien) FROM ChitietHDN WHERE maHDN = @MaHDN";
                
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MaHDN", maHDN);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        Tongtien = Convert.ToDecimal(result);
                    }
                }
            }
            conn.Close();
            return Tongtien;
            
        }
    }
}
