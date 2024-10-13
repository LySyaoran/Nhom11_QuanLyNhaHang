using Nhom11_QuanLyNhaHang_DTO;
using System.Data.SqlClient;

namespace Nhom11_QuanLyNhaHang_DAL
{
    public class USER_ACCOUNT_DAL
    {
        public string connectionString = "Server=LAPTOP-B3Q5NGMB\\SQLEXPRESS;Database=QLSINHVIEN;User Id=sa;Password=lienquanthai11;";
        public USER_ACCOUNT_DTO GetUser(string tendangnhap, string matkhau)
        {
            USER_ACCOUNT_DTO user = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM USER_ACCOUNT WHERE TENDANGNHAP = @TENDANGNHAP AND MATKHAU = @MATKHAU";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENDANGNHAP", tendangnhap);
                cmd.Parameters.AddWithValue("@MATKHAU", matkhau);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new USER_ACCOUNT_DTO()
                    {
                        Tendangnhap = reader["TENDANGNHAP"].ToString(),
                        Matkhau = reader["MATKHAU"].ToString(),
                        Hinhdaidien = reader["HINHDAIDIEN"].ToString()  // Nếu cần
                    };
                }
                conn.Close();
            }
            return user;
        }
    }
}
