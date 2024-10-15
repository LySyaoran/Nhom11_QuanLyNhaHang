namespace Nhom11_QuanLyNhaHang_DTO
{
    public class TaiKhoan_DTO
    {
        private int userID;
        private string tendangnhap;
        private string matkhau;
        private string email;
        private string hinhdaidien;
        private string vaitro;

        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Email { get => email; set => email = value; }
        public string Hinhdaidien { get => hinhdaidien; set => hinhdaidien = value; }
        public string Vaitro { get => vaitro; set => vaitro = value; }
        public int UserID { get => userID; set => userID = value; }

        public TaiKhoan_DTO()
        {
            Tendangnhap = string.Empty;
            Matkhau = string.Empty;
            Email = string.Empty;
            Hinhdaidien = string.Empty;
            Vaitro = "KhachHang";
        }
        public TaiKhoan_DTO(string tendangnhap, string matkhau, string email, string vaitro)
        {
            Tendangnhap = tendangnhap;
            Matkhau = matkhau;
            Email = email;
            Hinhdaidien = string.Empty;
            Vaitro = vaitro;
        }
    }
}
