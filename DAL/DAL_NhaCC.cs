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
    public class DAL_NhaCC : DBConnec
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dsncc ra ngoài màn hình
        public DataTable getNhaCC()
        {
            conn.Open();
            da = new SqlDataAdapter("Select * from NhaCC", conn);
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
                string sql = "SELECT COUNT(*) FROM NhaCC WHERE maNCC = @MaNCC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNCC", ma);
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

        public bool themNCC(DTO_NhaCC NCC)
        {
            string sql = "Insert into NhaCC values(N'" + NCC.maNCC + "',N'" + NCC.tenNCC + "',N'" + NCC.sdtNCC + "',N'" + NCC.diachiNCC + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaNCC(DTO_NhaCC NCC)
        {
            string sql = "Update NhaCC set tenNCC = N'" + NCC.tenNCC + "', sdtNCC = '" + NCC.sdtNCC + "',diachiNCC=N'"+NCC.diachiNCC +"' where maNCC = '" + NCC.maNCC + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaNCC(int ma)
        {
            {
                string sql = "Delete from NhaCC where maNCC = '" + ma + "'";

                thucthisql(sql);
                return true;
            }
        }



        //
        public DataTable TimKiemSanPhamTheoMa(int ma)
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM NhaCC WHERE maNCC = @MaNCC", conn);
            da.SelectCommand.Parameters.AddWithValue("@MaNCC", ma);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable TimKiemSanPhamTheoTen(string ten)
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM NhaCC WHERE tenNCC LIKE '%' + @TenNCC + '%'", conn);
            da.SelectCommand.Parameters.AddWithValue("@TenNCC", ten);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }



        //
        public bool KiemTraTonTaiMaNhaCungCap(int maNhaCungCap)
        {
            conn.Open();
            string sql = "SELECT COUNT(*) FROM NhaCC WHERE maNCC = @MaNhaCungCap";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }

    }
}
