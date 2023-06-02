using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHoaDonNhap
    {
        public int maCTHDN { get; set; }
        public int maHDN { get; set; }
        public string masp { get; set; }
        public int soluong { get; set; }
        public decimal gia { get; set; }
        public decimal tongtien { get; set; }

        public DTO_CTHoaDonNhap (int maCT, int maHDN, string masp, int sl, decimal gia, decimal tt)
        {
            this.maCTHDN = maCT;
            this.maHDN = maHDN;
            this.masp = masp;
            this.soluong = sl;
            this.gia = gia;
            this.tongtien = tt;
        }
    }
}
