using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Nhom11_QuanLyNhaHang_DAL
{
    public class DBConnect
    {
        //protected SqlConnection conn = new SqlConnection("Server = LAPTOP-B3Q5NGMB\\SQLEXPRESS; Database=QL_NHAHANG;User Id = sa; Password= lienquanthai11;");
        protected SqlConnection conn = new SqlConnection("Server = MSI\\SQLEXPRESS; Database=QL_NHAHANG;User Id = sa; Password= sa;");
    }
}
