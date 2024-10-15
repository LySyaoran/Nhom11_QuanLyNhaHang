using Nhom11_QuanLyNhaHang_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_MANAGEMENT
{
    public partial class frmDatBan : Form
    {
        public frmDatBan()
        {
            InitializeComponent();
            hienThiBan();
        }

        //hàm hiển thị danh sách bàn 
        public void hienThiBan()
        {
            // Lấy danh sách bàn 
            Ban_BLL ban_BLL = new Ban_BLL();
            DataTable dt = ban_BLL.loadBan();

            // Xóa các bàn đã có (nếu có) trong FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            // Lặp qua từng bàn trong cơ sở dữ liệu
            foreach (DataRow row in dt.Rows)
            {
                // Tạo một Button cho mỗi bàn
                Button btnBan = new Button();

                btnBan.Width = 150;
                btnBan.Height = 100;

                btnBan.Text = "Bàn " + row["MaBan"].ToString();
                btnBan.BackColor = Color.Orange;
                btnBan.Tag = row["MaBan"];  // Lưu mã bàn trong Tag để sử dụng sau này

                // Thay đổi màu nếu trạng thái bàn là đã được đặt
                if (row["TrangThai"].ToString() != "Trống")
                {
                    btnBan.BackColor = Color.Gray;  
                }

                // Thêm sự kiện click cho button
                btnBan.Click += BtnBan_Click;

                // Thêm button vào FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(btnBan);
            }
        }

        // Thêm sự kiện khi người dùng chọn một bàn
        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string maBan = btn.Tag.ToString();

            MessageBox.Show("Bạn có chắc muốn đặt bàn: " + maBan,"Thông báo",MessageBoxButtons.YesNo);
        }
    }
}
