using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Nhom11_QuanLyNhaHang_BLL;
using System.Security.Cryptography;

namespace RESTAURANT_MANAGEMENT
{
    public partial class frmQuenMatKhau : Form
    {
        private TaiKhoan_BLL userBll = new TaiKhoan_BLL();
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string emailTo = txt_Email.Text; // Email người dùng nhập vào
            string userPassword = "newpassword123"; // Bạn có thể tạo mật khẩu ngẫu nhiên ở đây

            try
            {
                // Tạo đối tượng SmtpClient để kết nối tới Gmail SMTP server
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, // Cổng SMTP của Gmail
                    Credentials = new NetworkCredential("no.reply.updatepass@gmail.com", "llmm yipe cour exun"), // Cung cấp tài khoản Gmail của bạn
                    EnableSsl = true // Kích hoạt SSL
                };

                // Tạo đối tượng MailMessage
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("no.reply.updatepass@gmail.com"), // Địa chỉ email gửi
                    Subject = "Cập nhật mật khẩu", // Tiêu đề email
                    Body = $"Chào bạn,\n\nMật khẩu mới của bạn là: {userPassword}\n\nVui lòng thay đổi mật khẩu sau khi đăng nhập.", // Nội dung email
                    IsBodyHtml = false // Đặt là false nếu bạn không muốn gửi HTML
                };

                mail.To.Add(emailTo); // Thêm địa chỉ email người nhận

                // Gửi email
                smtpClient.Send(mail);
                userBll.DoiMatKhau(emailTo, HashPasswordMD5(userPassword));
                MessageBox.Show("Mật khẩu mới đã được gửi đến email của bạn!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message);
            }
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
