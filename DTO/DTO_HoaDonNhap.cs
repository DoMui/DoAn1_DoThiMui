using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonNhap
    {
        public int maHDN { get; set; }
        public int maNV { get; set; }
        public int maNCC { get; set; }
        public DateTime ngaynhap { get; set; }

        public DTO_HoaDonNhap(int maHDN, int maNV, int maNCC, DateTime nn)
        {
            this.maHDN = maHDN;
            this.maNV = maNV;
            this.maNCC = maNCC;
            this.ngaynhap = nn;
        }
    }
}
