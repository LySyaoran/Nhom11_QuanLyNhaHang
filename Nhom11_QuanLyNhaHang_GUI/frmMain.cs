﻿using System;
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
    public partial class frmMain : Form
    {
        public string TenDangNhap;
        public int UserID;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string TenDangNhap, int UserID)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.UserID = UserID;
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát tài khoản", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tSS_TenDangNhap.Text = TenDangNhap;
        }

        private void btn_DatBan_Click(object sender, EventArgs e)
        {
            // Xóa các điều khiển hiện có trong panel2 để tránh việc thêm đè
            pnl_FormCon.Controls.Clear();

            frmDatBan datban = new frmDatBan();
            datban.TopLevel = false;

            // Đặt Dock cho frmDatBan để nó vừa với Panel
            datban.Dock = DockStyle.Fill;

            // Thêm UserControl UcDatBan vào panel2
            pnl_FormCon.Controls.Add(datban);

            datban.Show();

        }
    }
}
