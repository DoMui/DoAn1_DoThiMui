using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public int maNV { get; set; }
        public string tenNV { get; set; }
        public string sdtNV { get; set; }
        public string matkhau { get; set; }
        public string chucvu { get; set; }
        public DateTime ngaysinh { get; set; }
        public string gioitinh { get; set; }

        public DTO_NhanVien(int ma, string ten, string sdt, string mk, string cv, DateTime ngs, string gt)
        {
            this.maNV = ma;
            this.tenNV = ten;
            this.sdtNV = sdt;
            this.matkhau = mk;
            this.chucvu = cv;
            this.ngaysinh = ngs;
            this.gioitinh = gt;
        }
    }
}
