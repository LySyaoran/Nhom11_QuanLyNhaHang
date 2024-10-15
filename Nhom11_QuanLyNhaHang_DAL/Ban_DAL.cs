using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom11_QuanLyNhaHang_DAL
{
    public class Ban_DAL:DBConnect
    {
        //phương thức lấy danh sách các bàn
        public DataTable layDanhSachBan()
        {
            //khởi tạo biến dt kiểu DataTable
            DataTable dt = new DataTable();

            //tạo chuỗi kết nối đến csdl ==> đã tạo trong DBConnect

            //kiểm tra kết nối
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }    
            //viết câu lệnh truy vấn lấy dữ liệu từ bảng Bàn
            string cauLenh = "SELECT * FROM Ban";

            //Tạo đối tượng thực thi câu lệnh bằng sqlcommand
            SqlCommand sqlcmd = new SqlCommand(cauLenh,conn);

            //tạo đối tượng sqlDataAdapter để lấy dữ liệu đưa vào bảng dt
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(dt);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return  dt;
        }

    }
}
