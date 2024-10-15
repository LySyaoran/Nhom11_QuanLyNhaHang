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
using Microsoft.VisualBasic.ApplicationServices;

namespace RESTAURANT_MANAGEMENT
{
    public partial class frmDangNhap : Form
    {
        private TaiKhoan_BLL userBll = new TaiKhoan_BLL();
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

            TaiKhoan_DTO user;
            bool isSuccess = userBll.DangNhap(tendangnhap, matkhau, out user);

            if (isSuccess)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                frmMain mainForm = new frmMain(user.Tendangnhap, user.UserID);  // Chuyển đến form chính
                mainForm.ShowDialog();
                mainForm = null;
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ckb_HienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HienMK.Checked == true)
            {
                // Hiển thị mật khẩu
                txt_MK.PasswordChar = '\0';
            }
            else
            {
                txt_MK.PasswordChar = '*';
            }
        }

        private void llbl_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDangKy dangkyForm = new frmDangKy();  // Chuyển đến form chính
            dangkyForm.ShowDialog();
            dangkyForm = null;
            this.Show();
        }
    }
}
