namespace Nhom11_QuanLyNhaHang_DTO
{
    public class USER_ACCOUNT_DTO
    {
        private string tendangnhap;
        private string matkhau;
        private string email;
        private string hinhdaidien;

        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Email { get => email; set => email = value; }
        public string Hinhdaidien { get => hinhdaidien; set => hinhdaidien = value; }

        public USER_ACCOUNT_DTO()
        {
            Tendangnhap = string.Empty;
            Matkhau = string.Empty;
            Email = string.Empty;
            Hinhdaidien = string.Empty;
        }
        public USER_ACCOUNT_DTO(string tendangnhap, string matkhau, string email)
        {
            Tendangnhap = tendangnhap;
            Matkhau = matkhau;
            Email = email;
            Hinhdaidien = string.Empty;
        }
    }
}
