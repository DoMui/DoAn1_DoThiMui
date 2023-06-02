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
    public class BUS_CTHoaDonNhap
    {
        DAL_CTHoaDonNhap daCTHDN = new DAL_CTHoaDonNhap();
        DAL_SanPham dasp = new DAL_SanPham();
        public DataTable getCTHDN()
        {
            return daCTHDN.getCTHDN();
        }
        public int kiemtramatrung(int maCTHDN)
        {
            return daCTHDN.kiemtramatrung(maCTHDN);
        }
        public int themCTHDN(DTO_CTHoaDonNhap CTHDN)
        {
            //return daCTHDN.themCTHDN(CTHDN);
            int result = daCTHDN.themCTHDN(CTHDN);

            if (result == 1)
            {
                dasp.ThemSoLuongSanPham(CTHDN.masp, CTHDN.soluong);
            }

            return result;
        }
        public int suaCTHDN(DTO_CTHoaDonNhap CTHDN)
        {
            return daCTHDN.suaCTHDN(CTHDN);
        }
        public bool xoaCTHDN(int maCTHDN)
        {
            return daCTHDN.xoaCTHDN(maCTHDN);
        }
        //public bool KiemTraTonTaiHoaDonNhap(string maHoaDonNhap)
        //{
        //    return daCTHDN.KiemTraTonTaiHoaDonNhap(maHoaDonNhap);
        //}
        public decimal TinhTongTien(string maHDN)
        {
            return daCTHDN.TinhTongTien(maHDN);
        }
    }
}
