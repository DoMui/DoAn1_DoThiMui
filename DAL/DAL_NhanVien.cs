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
    public class DAL_NhanVien : DBConnec
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dsnv ra ngoài màn hình
        public DataTable getNhanVien()
        {
            conn.Open();
            da = new SqlDataAdapter("Select * from Nhanvien", conn);
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
                string sql = "SELECT COUNT(*) FROM Nhanvien WHERE maNV = @MaNV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", ma);
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

        public bool themNV(DTO_NhanVien NV)
        {
            string ngay = string.Format("{0}/{1}/{2}", NV.ngaysinh.Year, NV.ngaysinh.Month, NV.ngaysinh.Day);
            string sql = "Insert into Nhanvien values('" + NV.maNV + "',N'" + NV.tenNV + "','" + NV.sdtNV + "',N'" + NV.matkhau + "',N'" + NV.chucvu + "','" + ngay + "',N'" + NV.gioitinh + "')";

            thucthisql(sql);
            return true;
        }
        public bool suaNV(DTO_NhanVien NV)
        {
            string ngay = string.Format("{0}/{1}/{2}", NV.ngaysinh.Year, NV.ngaysinh.Month, NV.ngaysinh.Day);
            string sql = "Update Nhanvien set tenNV = N'" + NV.tenNV + "', sdtNV = N'" + NV.sdtNV + "',matkhau = N'" + NV.matkhau + "', chucvu = N'" + NV.chucvu + "',ngaysinh = '" + ngay + "',gioitinh = N'" + NV.gioitinh + "' where maNV = '" + NV.maNV + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaNV(int ma)
        {
            {
                string sql = "Delete from Nhanvien where maNV = '" + ma + "'";

                thucthisql(sql);
                return true;
            }
        }



        //
        public DataTable TimKiemSanPhamTheoMa(int ma)
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM Nhanvien WHERE maNV = @MaNV", conn);
            da.SelectCommand.Parameters.AddWithValue("@MaNV", ma);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable TimKiemSanPhamTheoTen(string ten)
        {
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM Nhanvien WHERE tenNV LIKE '%' + @TenNV + '%'", conn);
            da.SelectCommand.Parameters.AddWithValue("@TenNV", ten);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }



        //
        public bool KiemTraTonTaiMaNhanVien(int maNhanVien)
        {
            conn.Open();
            string sql = "SELECT COUNT(*) FROM Nhanvien WHERE maNV = @MaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }
    }
}
