using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public int maKH { get; set; }
        public string tenKH { get; set; }
        public string sdtKH { get; set; }
        public string diachiKH { get; set; }

        public DTO_KhachHang(int ma, string ten, string sdt, string dc)
        {
            this.maKH = ma;
            this.tenKH = ten;
            this.sdtKH = sdt;
            this.diachiKH = dc;
        }
    }
}
