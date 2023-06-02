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
    public class BUS_SanPham
    {
        DAL_SanPham dasp = new DAL_SanPham();
        public DataTable getSanPham()
        {
            return dasp.getSanPham();
        }
        public int kiemtramatrung(int ma)
        {
            return dasp.kiemtramatrung(ma);
        }
        public int themSP(DTO_SanPham SP)
        {
            return dasp.themSP(SP);
            
        }
        public int suaSP(DTO_SanPham SP)
        {
            return dasp.suaSP(SP);
            
        }
        public bool xoaSP(int ma)
        {
            return dasp.xoaSP(ma);
        }



        //
        public DataTable TimKiemSanPhamTheoMa(int ma)
        {
            return dasp.TimKiemSanPhamTheoMa(ma);
        }

        public DataTable TimKiemSanPhamTheoTen(string ten)
        {
            return dasp.TimKiemSanPhamTheoTen(ten);
        }
        //
        public bool KiemTraTonTaiSanPham(string maSP)
        {
            return dasp.KiemTraTonTaiSanPham(maSP);
        }
        //
        public decimal LayGiaSanPham(string masp)
        {
            return dasp.LayGiaSanPham(masp);
        }

    }
}
