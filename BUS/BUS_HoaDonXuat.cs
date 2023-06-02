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
    public class BUS_HoaDonXuat
    {
        DAL_HoaDonXuat daHDX = new DAL_HoaDonXuat();
        public DataTable getHoaDonXuat()
        {
            return daHDX.getHoaDonXuat();
        }
        public int kiemtramatrung(int maHDX)
        {
            return daHDX.kiemtramatrung(maHDX);
        }
        public bool themHDX(DTO_HoaDonXuat HDX)
        {
            return daHDX.themHDX(HDX);
        }
        public bool suaHDX(DTO_HoaDonXuat HDX)
        {
            return daHDX.suaHDX(HDX);
        }
        public bool xoaHDX(int maHDX)
        {
            return daHDX.xoaHDX(maHDX);
        }



        //
        public DataTable TimKiemSanPhamTheoMa(string maHDX)
        {
            return daHDX.TimKiemSanPhamTheoMa(maHDX);
        }

        public DataTable TimKiemSanPhamTheoTen(string maNV)
        {
            return daHDX.TimKiemSanPhamTheoTen(maNV);
        }
        //
        public bool KiemTraTonTaiHoaDonXuat(int maHoaDonXuat)
        {
            return daHDX.KiemTraTonTaiHoaDonXuat(maHoaDonXuat);
        }
    }
}
