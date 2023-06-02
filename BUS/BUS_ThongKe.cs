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
    public class BUS_ThongKe
    {
        DAL_ThongKe daltk = new DAL_ThongKe();
        public DataTable LayDSHDBan()
        {
            return daltk.LayDSHDBan();
        }
        public DataTable timKiemHDTGNgay(DateTime ngay)
        {
            return daltk.timKiemHDTGNgay(ngay);
        }
        public DataTable timKiemHDTG(DateTime startDate, DateTime endDate)
        {
            return daltk.timKiemHDTG(startDate, endDate);
        }
        public DataTable SanPhamBanChay()
        {
            return daltk.SanPhamBanChay();
        }
        
    }
}
