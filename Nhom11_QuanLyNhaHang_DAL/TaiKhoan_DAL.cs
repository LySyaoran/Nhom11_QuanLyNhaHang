using Nhom11_QuanLyNhaHang_DTO;
using System.Data.SqlClient;

namespace Nhom11_QuanLyNhaHang_DAL
{
    public class TaiKhoan_DAL:DBConnect
    {
        public TaiKhoan_DTO GetUser(string tendangnhap, string matkhau)
        {
            TaiKhoan_DTO user = null;

            string query = "SELECT * FROM TaiKhoan WHERE TenDangNHap = @TENDANGNHAP AND MatKhau = @MATKHAU";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TENDANGNHAP", tendangnhap);
            cmd.Parameters.AddWithValue("@MATKHAU", matkhau);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user = new TaiKhoan_DTO()
                {
                    UserID = int.Parse(reader["UserID"].ToString()),
                    Tendangnhap = reader["TenDangNHap"].ToString(),
                    Matkhau = reader["MatKhau"].ToString(),
                    Hinhdaidien = reader["HinhDaiDien"].ToString()
                };
            }
            conn.Close();

            return user;
        }

        public bool Them_TaiKhoan(TaiKhoan_DTO user)
        {
            try
            {
                conn.Open();
                string query = "EXEC SP_DangKy_Form @TENDANGNHAP, @MATKHAU, @EMAIL, @VAITRO";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Thêm tham số cho lệnh SQL
                cmd.Parameters.AddWithValue("@TENDANGNHAP", user.Tendangnhap);
                cmd.Parameters.AddWithValue("@MATKHAU", user.Matkhau);
                cmd.Parameters.AddWithValue("@EMAIL", user.Email);
                cmd.Parameters.AddWithValue("@VAITRO", user.Vaitro);

                // Thực thi lệnh
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update_MatKhau(string Email, string MatKhau)
        {
            try
            {
                conn.Open();
                string query = "EXEC SP_UpdatePassword @EMAIL, @MATKHAU";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Thêm tham số cho lệnh SQL
                cmd.Parameters.AddWithValue("@EMAIL", Email);
                cmd.Parameters.AddWithValue("@MATKHAU", MatKhau);

                // Thực thi lệnh
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
