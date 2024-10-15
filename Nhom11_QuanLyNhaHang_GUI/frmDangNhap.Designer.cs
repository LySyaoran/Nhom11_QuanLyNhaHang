namespace RESTAURANT_MANAGEMENT
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txt_TenDN = new TextBox();
            txt_MK = new TextBox();
            ckb_HienMK = new CheckBox();
            llbl_QuenMK = new LinkLabel();
            llbl_DangKy = new LinkLabel();
            btn_DangNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 38);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_user_96;
            pictureBox2.Location = new Point(74, 324);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_password_90;
            pictureBox3.Location = new Point(74, 402);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txt_TenDN
            // 
            txt_TenDN.BorderStyle = BorderStyle.FixedSingle;
            txt_TenDN.Font = new Font("Tahoma", 10.8F);
            txt_TenDN.Location = new Point(211, 334);
            txt_TenDN.Margin = new Padding(4);
            txt_TenDN.Name = "txt_TenDN";
            txt_TenDN.Size = new Size(431, 34);
            txt_TenDN.TabIndex = 3;
            txt_TenDN.Text = "Tên đăng nhập";
            // 
            // txt_MK
            // 
            txt_MK.BorderStyle = BorderStyle.FixedSingle;
            txt_MK.Font = new Font("Tahoma", 10.8F);
            txt_MK.Location = new Point(211, 412);
            txt_MK.Margin = new Padding(4);
            txt_MK.Name = "txt_MK";
            txt_MK.PasswordChar = '*';
            txt_MK.Size = new Size(431, 34);
            txt_MK.TabIndex = 4;
            txt_MK.Text = "Mật khẩu";
            // 
            // ckb_HienMK
            // 
            ckb_HienMK.AutoSize = true;
            ckb_HienMK.Font = new Font("Tahoma", 9F);
            ckb_HienMK.Location = new Point(484, 454);
            ckb_HienMK.Margin = new Padding(4);
            ckb_HienMK.Name = "ckb_HienMK";
            ckb_HienMK.Size = new Size(151, 26);
            ckb_HienMK.TabIndex = 5;
            ckb_HienMK.Text = "Hiện mật khẩu";
            ckb_HienMK.UseVisualStyleBackColor = true;
            ckb_HienMK.CheckedChanged += ckb_HienMK_CheckedChanged;
            // 
            // llbl_QuenMK
            // 
            llbl_QuenMK.AutoSize = true;
            llbl_QuenMK.Font = new Font("Tahoma", 9F);
            llbl_QuenMK.Location = new Point(211, 505);
            llbl_QuenMK.Margin = new Padding(4, 0, 4, 0);
            llbl_QuenMK.Name = "llbl_QuenMK";
            llbl_QuenMK.Size = new Size(141, 22);
            llbl_QuenMK.TabIndex = 6;
            llbl_QuenMK.TabStop = true;
            llbl_QuenMK.Text = "Quên mật khẩu?";
            llbl_QuenMK.LinkClicked += llbl_QuenMK_LinkClicked;
            // 
            // llbl_DangKy
            // 
            llbl_DangKy.AutoSize = true;
            llbl_DangKy.Font = new Font("Tahoma", 9F);
            llbl_DangKy.Location = new Point(548, 505);
            llbl_DangKy.Margin = new Padding(4, 0, 4, 0);
            llbl_DangKy.Name = "llbl_DangKy";
            llbl_DangKy.Size = new Size(76, 22);
            llbl_DangKy.TabIndex = 7;
            llbl_DangKy.TabStop = true;
            llbl_DangKy.Text = "Đăng ký";
            llbl_DangKy.LinkClicked += llbl_DangKy_LinkClicked;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.BackColor = Color.Blue;
            btn_DangNhap.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangNhap.ForeColor = SystemColors.Control;
            btn_DangNhap.Location = new Point(256, 566);
            btn_DangNhap.Margin = new Padding(4);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(202, 56);
            btn_DangNhap.TabIndex = 8;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(715, 654);
            Controls.Add(btn_DangNhap);
            Controls.Add(llbl_DangKy);
            Controls.Add(llbl_QuenMK);
            Controls.Add(ckb_HienMK);
            Controls.Add(txt_MK);
            Controls.Add(txt_TenDN);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "frmDangNhap";
            Text = "Đăng Nhập";
            FormClosing += frmDangNhap_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txt_TenDN;
        private TextBox txt_MK;
        private CheckBox ckb_HienMK;
        private LinkLabel llbl_QuenMK;
        private LinkLabel llbl_DangKy;
        private Button btn_DangNhap;
    }
}