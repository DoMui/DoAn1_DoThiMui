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
    public class DAL_CTHoaDonXuat : DBConnec
    {
        DAL_SanPham dasp = new DAL_SanPham();

        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dskh ra ngoài màn hình
        public DataTable getCTHDX()
        {
            conn.Open();
            da = new SqlDataAdapter("Select * from ChitietHDX", conn);
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
        public int kiemtramatrung(int maCTHDX)
        {
            int i = 0;
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM ChitietHDX WHERE maCTHDX = @MaCTHDX";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaCTHDX", maCTHDX);
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

        public int themCTHDX(DTO_CTHoaDonXuat CTHDX)
        {
            if (CTHDX.soluong < 0)
            {
                // Trả về mã lỗi -2 cho số lượng âm
                return -2;
            }

            string sql = "Insert into ChitietHDX values(N'" + CTHDX.maCTHDX + "',N'" + CTHDX.maHDX + "',N'" + CTHDX.masp + "',N'" + CTHDX.soluong + "','" + CTHDX.gia + "','" + CTHDX.tongtien + "')";
            thucthisql(sql);

            // Trả về mã thành công 1
            return 1;

        }
        public int suaCTHDX(DTO_CTHoaDonXuat CTHDX)
        {
            if (CTHDX.soluong < 0)
            {
                // Trả về mã lỗi -2 cho số lượng âm
                return -2;
            }

            string sql = "Update ChitietHDX set maHDX = N'" + CTHDX.maHDX + "', masp = '" + CTHDX.masp + "',soluong = '" + CTHDX.soluong + "',gia = '" + CTHDX.gia + "',tongtien = '" + CTHDX.tongtien + "' where maCTHDX = '" + CTHDX.maCTHDX + "'";
            thucthisql(sql);
            //
            dasp.GiamSoLuongSanPham(CTHDX.masp, CTHDX.soluong);
            //
            // Trả về mã thành công 1
            return 1;
        }
        public bool xoaCTHDX(int maCTHDX)
        {
            {
                string sql = "Delete from ChitietHDX where maCTHDX = '" + maCTHDX + "'";

                thucthisql(sql);
                return true;
            }
        }
        public decimal TinhTongTien(string maHDX)
        {

            decimal Tongtien = 0;

            
            {
                conn.Open();

                string query = "SELECT SUM(tongtien) FROM ChitietHDX WHERE maHDX = @MaHDX";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MaHDX", maHDX);

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
