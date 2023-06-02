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
    public class BUS_HoaDonNhap
    {
        DAL_HoaDonNhap daHDN = new DAL_HoaDonNhap();
        public DataTable getHoaDonNhap()
        {
            return daHDN.getHoaDonNhap();
        }
        public int kiemtramatrung(int maHDN)
        {
            return daHDN.kiemtramatrung(maHDN);
        }
        public bool themHDN(DTO_HoaDonNhap HDN)
        {
            return daHDN.themHDN(HDN);
        }
        public bool suaHDN(DTO_HoaDonNhap HDN)
        {
            return daHDN.suaHDN(HDN);
        }
        public bool xoaHDN(int maHDN)
        {
            return daHDN.xoaHDN(maHDN);
        }



        //
        public DataTable TimKiemSanPhamTheoMa(string maHDN)
        {
            return daHDN.TimKiemSanPhamTheoMa(maHDN);
        }

        public DataTable TimKiemSanPhamTheoTen(string maNV)
        {
            return daHDN.TimKiemSanPhamTheoTen(maNV);
        }
        //
        public bool KiemTraTonTaiHoaDonNhap(int maHoaDonNhap)
        {
            return daHDN.KiemTraTonTaiHoaDonNhap(maHoaDonNhap);
        }
        //
        public int ThemHoaDonNhap(DTO_HoaDonNhap HDN)
        {
            return daHDN.ThemHoaDonNhap(HDN);
        }
    }
}
