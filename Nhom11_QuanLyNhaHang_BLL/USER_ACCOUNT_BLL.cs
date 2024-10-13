using Nhom11_QuanLyNhaHang_DTO;
using Nhom11_QuanLyNhaHang_DAL;

namespace Nhom11_QuanLyNhaHang_BLL
{
    public class USER_ACCOUNT_BLL
    {
        private USER_ACCOUNT_DAL userDal = new USER_ACCOUNT_DAL();

        public bool DangNhap(string tendangnhap, string matkhau, out USER_ACCOUNT_DTO user)
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

    }
}
