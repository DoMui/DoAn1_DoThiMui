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
    public class BUS_KhachHang
    {
        DAL_KhachHang dakh = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dakh.getKhachHang();
        }
        public int kiemtramatrung(int ma)
        {
            return dakh.kiemtramatrung(ma);
        }
        public bool themKH(DTO_KhachHang KH)
        {
            return dakh.themKH(KH);
        }
        public bool suaKH(DTO_KhachHang KH)
        {
            return dakh.suaKH(KH);
        }
        public bool xoaKH(int ma)
        {
            return dakh.xoaKH(ma);
        }



        //
        public DataTable TimKiemSanPhamTheoMa(int ma)
        {
            return dakh.TimKiemSanPhamTheoMa(ma);
        }

        public DataTable TimKiemSanPhamTheoTen(string ten)
        {
            return dakh.TimKiemSanPhamTheoTen(ten);
        }


        //
        public bool KiemTraTonTaiMaKhachHang(int maKH)
        {
            return dakh.KiemTraTonTaiMaKhachHang(maKH);
        }
    }
}
