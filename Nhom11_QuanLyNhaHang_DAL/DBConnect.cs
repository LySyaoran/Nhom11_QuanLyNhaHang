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
        public SqlConnection conn = new SqlConnection("Data Source = LAPTOP-B3Q5NGMB\\SQLEXPRESS, Initial Catalog = QLSINHVIEN, User ID = sa, Password = lienquanthai11");
    }
}
