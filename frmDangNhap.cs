using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom11_QuanLyNhaHang_DTO;
using Nhom11_QuanLyNhaHang_DAL;
using Nhom11_QuanLyNhaHang_BLL;

namespace RESTAURANT_MANAGEMENT
{
    public partial class frmDangNhap : Form
    {
        private USER_ACCOUNT_BLL userBll = new USER_ACCOUNT_BLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txt_TenDN.Text;
            string matkhau = txt_MK.Text;

            if (string.IsNullOrEmpty(tendangnhap) || string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.");
                return;
            }

            USER_ACCOUNT_DTO user;
            bool isSuccess = userBll.DangNhap(tendangnhap, matkhau, out user);

            if (isSuccess)
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Chuyển sang form khác hoặc xử lý đăng nhập thành công
                // Ví dụ: Hiển thị thông tin người dùng
                this.Hide();
                frmMain mainForm = new frmMain();  // Chuyển đến form chính
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }
    }
}
