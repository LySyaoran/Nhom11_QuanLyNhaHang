namespace RESTAURANT_MANAGEMENT
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_Menu = new Panel();
            btn_DatBan = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pnl_TitleBar = new Panel();
            tSS_TenDangNhap = new Label();
            pnl_FormCon = new Panel();
            pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_TitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Menu
            // 
            pnl_Menu.BackColor = Color.OrangeRed;
            pnl_Menu.Controls.Add(btn_DatBan);
            pnl_Menu.Controls.Add(button5);
            pnl_Menu.Controls.Add(button4);
            pnl_Menu.Controls.Add(button3);
            pnl_Menu.Controls.Add(button2);
            pnl_Menu.Controls.Add(pictureBox1);
            pnl_Menu.Dock = DockStyle.Left;
            pnl_Menu.Location = new Point(0, 0);
            pnl_Menu.Name = "pnl_Menu";
            pnl_Menu.Size = new Size(250, 703);
            pnl_Menu.TabIndex = 2;
            // 
            // btn_DatBan
            // 
            btn_DatBan.BackColor = Color.SandyBrown;
            btn_DatBan.FlatAppearance.BorderColor = Color.Black;
            btn_DatBan.FlatAppearance.BorderSize = 0;
            btn_DatBan.FlatStyle = FlatStyle.Flat;
            btn_DatBan.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btn_DatBan.ForeColor = SystemColors.ButtonHighlight;
            btn_DatBan.Image = Properties.Resources.booktable;
            btn_DatBan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DatBan.Location = new Point(0, 176);
            btn_DatBan.Name = "btn_DatBan";
            btn_DatBan.Size = new Size(250, 62);
            btn_DatBan.TabIndex = 1;
            btn_DatBan.Text = "Đặt bàn";
            btn_DatBan.TextAlign = ContentAlignment.MiddleRight;
            btn_DatBan.UseVisualStyleBackColor = false;
            btn_DatBan.Click += btn_DatBan_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SandyBrown;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = Properties.Resources.hoadon;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 544);
            button5.Name = "button5";
            button5.Size = new Size(250, 62);
            button5.TabIndex = 5;
            button5.Text = "Hóa đơn";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.SandyBrown;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.customer;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 452);
            button4.Name = "button4";
            button4.Size = new Size(250, 62);
            button4.TabIndex = 4;
            button4.Text = "Khách Hàng";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SandyBrown;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = Properties.Resources.staff;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 360);
            button3.Name = "button3";
            button3.Size = new Size(250, 62);
            button3.TabIndex = 3;
            button3.Text = "Nhân Viên";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.datmon1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 268);
            button2.Name = "button2";
            button2.Size = new Size(250, 62);
            button2.TabIndex = 2;
            button2.Text = "Đặt món";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_restaurant;
            pictureBox1.Location = new Point(62, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnl_TitleBar
            // 
            pnl_TitleBar.BackColor = SystemColors.ControlLightLight;
            pnl_TitleBar.Controls.Add(tSS_TenDangNhap);
            pnl_TitleBar.Dock = DockStyle.Top;
            pnl_TitleBar.Location = new Point(250, 0);
            pnl_TitleBar.Name = "pnl_TitleBar";
            pnl_TitleBar.Size = new Size(882, 75);
            pnl_TitleBar.TabIndex = 3;
            // 
            // tSS_TenDangNhap
            // 
            tSS_TenDangNhap.AutoSize = true;
            tSS_TenDangNhap.Location = new Point(69, 27);
            tSS_TenDangNhap.Name = "tSS_TenDangNhap";
            tSS_TenDangNhap.Size = new Size(56, 22);
            tSS_TenDangNhap.TabIndex = 0;
            tSS_TenDangNhap.Text = "label1";
            // 
            // pnl_FormCon
            // 
            pnl_FormCon.BackColor = SystemColors.ControlLight;
            pnl_FormCon.Dock = DockStyle.Fill;
            pnl_FormCon.Location = new Point(250, 75);
            pnl_FormCon.Name = "pnl_FormCon";
            pnl_FormCon.Size = new Size(882, 628);
            pnl_FormCon.TabIndex = 4;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 703);
            Controls.Add(pnl_FormCon);
            Controls.Add(pnl_TitleBar);
            Controls.Add(pnl_Menu);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            Text = "Trang Chủ";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_TitleBar.ResumeLayout(false);
            pnl_TitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_Menu;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btn_DatBan;
        private Panel pnl_TitleBar;
        private Panel pnl_FormCon;
        private Label tSS_TenDangNhap;
    }
}