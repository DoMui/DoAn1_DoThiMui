using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien danv = new DAL_NhanVien();
        public DataTable getNhanVien()
        {
            return danv.getNhanVien();
        }
        public int kiemtramatrung(int ma)
        {
            return danv.kiemtramatrung(ma);
        }
        public bool themNV(DTO_NhanVien NV)
        {
            return danv.themNV(NV);
        }
        public bool suaNV(DTO_NhanVien NV)
        {
            return danv.suaNV(NV);
        }
        public bool xoaNV(int ma)
        {
            return danv.xoaNV(ma);
        }



        //
        public DataTable TimKiemSanPhamTheoMa(int ma)
        {
            return danv.TimKiemSanPhamTheoMa(ma);
        }

        public DataTable TimKiemSanPhamTheoTen(string ten)
        {
            return danv.TimKiemSanPhamTheoTen(ten);
        }



       //
       public bool KiemTraTonTaiMaNhanVien(int maNhanVien)
        {
            return danv.KiemTraTonTaiMaNhanVien(maNhanVien);
        }
    }
}
