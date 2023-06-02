using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDonXuat
    {
        public int maHDX { get; set; }
        public int maNV { get; set; }
        public int maKH { get; set; }
        public DateTime ngayban { get; set; }

        public DTO_HoaDonXuat(int maHDX, int maNV, int maKH, DateTime nb)
        {
            this.maHDX = maHDX;
            this.maNV = maNV;
            this.maKH = maKH;
            this.ngayban = nb;
        }
    }
}
