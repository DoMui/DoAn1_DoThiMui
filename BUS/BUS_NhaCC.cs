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
    public class BUS_NhaCC
    {
        DAL_NhaCC dancc = new DAL_NhaCC();
        public DataTable getNhaCC()
        {
            return dancc.getNhaCC();
        }
        public int kiemtramatrung(int ma)
        {
            return dancc.kiemtramatrung(ma);
        }
        public bool themNCC(DTO_NhaCC NCC)
        {
            return dancc.themNCC(NCC);
        }
        public bool suaNCC(DTO_NhaCC NCC)
        {
            return dancc.suaNCC(NCC);
        }
        public bool xoaNCC(int ma)
        {
            return dancc.xoaNCC(ma);
        }



        //
        public DataTable TimKiemSanPhamTheoMa(int ma)
        {
            return dancc.TimKiemSanPhamTheoMa(ma);
        }

        public DataTable TimKiemSanPhamTheoTen(string ten)
        {
            return dancc.TimKiemSanPhamTheoTen(ten);
        }



        // 
        public bool KiemTraTonTaiMaNhaCungCap(int maNhaCungCap)
        {
            return dancc.KiemTraTonTaiMaNhaCungCap(maNhaCungCap);
        }
    }
}
