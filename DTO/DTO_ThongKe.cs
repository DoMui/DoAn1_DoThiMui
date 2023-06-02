using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThongKe
    {
        public string maHDX { get; set; }
        public string maNV { get; set; }
        public string maKH { get; set; }
        public DateTime ngayban { get; set; }

        DTO_ThongKe(string maHDX, string maNV, string maKH, DateTime ngayban)
        {
            this.maHDX = maHDX;
            this.maNV = maNV;
            this.maKH = maKH;
            this.ngayban = ngayban;
        }
    }
}
