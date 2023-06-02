using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnec
    {
       protected SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-3JSDS55G\SQLEXPRESS01;Initial Catalog=ĐoAn;Integrated Security=True");
        
    }
}
