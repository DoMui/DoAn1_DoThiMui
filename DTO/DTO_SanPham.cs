using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        public int masp { get; set; }
        public string tensp { get; set; }
        public float gia { get; set; }
        public float soluong { get; set; }
        public string xuatxu { get; set; }

        public DTO_SanPham(int ma, string ten, float gia, float sl, string xx)
        {
            this.masp = ma;
            this.tensp = ten;
            this.gia = gia;
            this.soluong = sl;
            this.xuatxu = xx;
        }
    }
    
}
