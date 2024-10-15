using Nhom11_QuanLyNhaHang_DTO;
using Nhom11_QuanLyNhaHang_DAL;

namespace Nhom11_QuanLyNhaHang_BLL
{
    public class TaiKhoan_BLL
    {
        private TaiKhoan_DAL userDal = new TaiKhoan_DAL();

        public bool DangNhap(string tendangnhap, string matkhau, out TaiKhoan_DTO user)
        {
            user = userDal.GetUser(tendangnhap, matkhau);
            if (user != null)
            {
                // Đăng nhập thành công
                return true;
            }
            // Đăng nhập thất bại
            return false;
        }

        public bool DangKy(TaiKhoan_DTO user)
        {
            return userDal.Them_TaiKhoan(user);
        }
        public bool DoiMatKhau(string Email, string MatKhau)
        {
            return userDal.Update_MatKhau(Email, MatKhau);
        }
    }
}
