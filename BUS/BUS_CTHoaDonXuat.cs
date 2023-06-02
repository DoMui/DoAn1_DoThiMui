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
    public class BUS_CTHoaDonXuat
    {
        DAL_CTHoaDonXuat daCTHDX = new DAL_CTHoaDonXuat();
        DAL_SanPham dasp = new DAL_SanPham();
        public DataTable getCTHDX()
        {
            return daCTHDX.getCTHDX();
        }
        public int kiemtramatrung(int maCTHDX)
        {
            return daCTHDX.kiemtramatrung(maCTHDX);
        }
        public int themCTHDX(DTO_CTHoaDonXuat CTHDX)
        {
            //return daCTHDX.themCTHDX(CTHDX);
            int result = daCTHDX.themCTHDX(CTHDX);

            if (result == 1)
            {
                dasp.GiamSoLuongSanPham(CTHDX.masp, CTHDX.soluong);
            }

            return result;
        }
        public int suaCTHDX(DTO_CTHoaDonXuat CTHDX)
        {
            return daCTHDX.suaCTHDX(CTHDX);
        }
        public bool xoaCTHDX(int maCTHDX)
        {
            return daCTHDX.xoaCTHDX(maCTHDX);
        }
        public decimal TinhTongTien(string maHDX)
        {
            return daCTHDX.TinhTongTien(maHDX);
        }
    }
}
