using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCC
    {
        public int maNCC { get; set; }
        public string tenNCC { get; set; }
        public string sdtNCC { get; set; }
        public string diachiNCC { get; set; }

        public DTO_NhaCC(int ma, string ten, string sdt, string dc)
        {
            this.maNCC = ma;
            this.tenNCC = ten;
            this.sdtNCC = sdt;
            this.diachiNCC = dc;
        }
    }
}
