using Nhom11_QuanLyNhaHang_BLL;
using Nhom11_QuanLyNhaHang_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Cryptography;

namespace RESTAURANT_MANAGEMENT
{
    public partial class frmDangKy : Form
    {
        private TaiKhoan_BLL userBll = new TaiKhoan_BLL();
        public frmDangKy()
        {
            InitializeComponent();
        }


        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nhập liệu
                if (string.IsNullOrEmpty(txt_TenDN.Text) || string.IsNullOrEmpty(txt_MK.Text) || string.IsNullOrEmpty(txt_XacNhanMK.Text) || string.IsNullOrEmpty(txt_Email.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.");
                    return;
                }

                if (txt_MK.Text != txt_XacNhanMK.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp, vui lòng xác nhận lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tách chuỗi tên đăng nhập theo dấu '_'
                string[] parts = txt_TenDN.Text.Split('_');
                string vaitro = "KhachHang"; // Mặc định là khách hàng nếu không có ký tự '_'
                string tendangnhap = txt_TenDN.Text; // Mặc định là toàn bộ tên đăng nhập nếu không có '_'

                // Kiểm tra nếu tên đăng nhập có chứa dấu '_'
                if (parts.Length > 1)
                {
                    string phandau = parts[0]; // Lấy phần trước dấu '_'
                    tendangnhap = parts[1]; // Lấy phần sau dấu '_'

                    // Xác định vai trò dựa trên phần đầu
                    if (phandau == "NV")
                    {
                        vaitro = "NhanVien";
                    }
                    else if (phandau == "Admin")
                    {
                        vaitro = "Admin";
                    }
                }

                // Tạo đối tượng TaiKhoan_DTO từ thông tin người dùng nhập
                TaiKhoan_DTO user = new TaiKhoan_DTO(tendangnhap, HashPasswordMD5(txt_MK.Text), txt_Email.Text, vaitro);

                // Gọi lớp BLL để thực hiện đăng ký
                bool isSuccess = userBll.DangKy(user);

                if (isSuccess)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ckb_HienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HienMK.Checked == true)
            {
                // Hiển thị mật khẩu
                txt_MK.PasswordChar = '\0';
                txt_XacNhanMK.PasswordChar = '\0';
            }
            else
            {
                txt_MK.PasswordChar = '*';
                txt_XacNhanMK.PasswordChar = '*';
            }
        }

        private void llbl_DangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        public string HashPasswordMD5(string password)
        {
            // Tạo đối tượng MD5
            using (MD5 md5 = MD5.Create())
            {
                // Chuyển password thành mảng byte
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);

                // Tính toán hash
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển đổi mảng byte thành chuỗi hex
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2")); // X2 để in ra hex với chữ cái in hoa
                }
                return sb.ToString();
            }
        }
    }
}
