using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTHoaDonXuat
    {
        public int maCTHDX { get; set; }
        public int maHDX { get; set; }
        public string masp { get; set; }
        public int soluong { get; set; }
        public decimal gia { get; set; }
        public decimal tongtien { get; set; }

        public DTO_CTHoaDonXuat(int maCT, int maHDX, string masp, int sl, decimal gia, decimal tt)
        {
            this.maCTHDX = maCT;
            this.maHDX = maHDX;
            this.masp = masp;
            this.soluong = sl;
            this.gia = gia;
            this.tongtien = tt;
        }
    }
}
