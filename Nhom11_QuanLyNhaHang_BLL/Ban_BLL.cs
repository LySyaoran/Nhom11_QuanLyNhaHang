using Nhom11_QuanLyNhaHang_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_QuanLyNhaHang_BLL
{
    public class Ban_BLL
    {
        //thực hiện nv load các bàn lên form đặt bàn
        public DataTable loadBan()
        {
            Ban_DAL ban_DAL = new Ban_DAL();
            return ban_DAL.layDanhSachBan();
        }

    }
}
