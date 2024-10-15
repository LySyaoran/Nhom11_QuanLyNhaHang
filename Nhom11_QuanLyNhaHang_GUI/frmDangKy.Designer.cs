namespace RESTAURANT_MANAGEMENT
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            txt_MK = new TextBox();
            txt_TenDN = new TextBox();
            pictureBox1 = new PictureBox();
            txt_XacNhanMK = new TextBox();
            txt_Email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_DangKy = new Button();
            ckb_HienMK = new CheckBox();
            llbl_DangNhap = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_MK
            // 
            txt_MK.BorderStyle = BorderStyle.FixedSingle;
            txt_MK.Font = new Font("Tahoma", 10.8F);
            txt_MK.Location = new Point(319, 422);
            txt_MK.Margin = new Padding(4);
            txt_MK.Name = "txt_MK";
            txt_MK.PasswordChar = '*';
            txt_MK.Size = new Size(404, 34);
            txt_MK.TabIndex = 10;
            // 
            // txt_TenDN
            // 
            txt_TenDN.BorderStyle = BorderStyle.FixedSingle;
            txt_TenDN.Font = new Font("Tahoma", 10.8F);
            txt_TenDN.Location = new Point(319, 361);
            txt_TenDN.Margin = new Padding(4);
            txt_TenDN.Name = "txt_TenDN";
            txt_TenDN.Size = new Size(404, 34);
            txt_TenDN.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 60);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(633, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txt_XacNhanMK
            // 
            txt_XacNhanMK.BorderStyle = BorderStyle.FixedSingle;
            txt_XacNhanMK.Font = new Font("Tahoma", 10.8F);
            txt_XacNhanMK.Location = new Point(319, 484);
            txt_XacNhanMK.Margin = new Padding(4);
            txt_XacNhanMK.Name = "txt_XacNhanMK";
            txt_XacNhanMK.PasswordChar = '*';
            txt_XacNhanMK.Size = new Size(404, 34);
            txt_XacNhanMK.TabIndex = 11;
            // 
            // txt_Email
            // 
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Font = new Font("Tahoma", 10.8F);
            txt_Email.Location = new Point(319, 542);
            txt_Email.Margin = new Padding(4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(404, 34);
            txt_Email.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F);
            label1.Location = new Point(90, 366);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 27);
            label1.TabIndex = 13;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F);
            label2.Location = new Point(90, 426);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 27);
            label2.TabIndex = 14;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F);
            label3.Location = new Point(90, 486);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 27);
            label3.TabIndex = 15;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F);
            label4.Location = new Point(90, 546);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 27);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // btn_DangKy
            // 
            btn_DangKy.BackColor = Color.Blue;
            btn_DangKy.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DangKy.ForeColor = SystemColors.Control;
            btn_DangKy.Location = new Point(316, 628);
            btn_DangKy.Margin = new Padding(4);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(202, 56);
            btn_DangKy.TabIndex = 17;
            btn_DangKy.Text = "Đăng Ký";
            btn_DangKy.UseVisualStyleBackColor = false;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // ckb_HienMK
            // 
            ckb_HienMK.AutoSize = true;
            ckb_HienMK.Font = new Font("Tahoma", 9F);
            ckb_HienMK.Location = new Point(572, 584);
            ckb_HienMK.Margin = new Padding(4);
            ckb_HienMK.Name = "ckb_HienMK";
            ckb_HienMK.Size = new Size(151, 26);
            ckb_HienMK.TabIndex = 18;
            ckb_HienMK.Text = "Hiện mật khẩu";
            ckb_HienMK.UseVisualStyleBackColor = true;
            ckb_HienMK.CheckedChanged += ckb_HienMK_CheckedChanged;
            // 
            // llbl_DangNhap
            // 
            llbl_DangNhap.AutoSize = true;
            llbl_DangNhap.Font = new Font("Tahoma", 9F);
            llbl_DangNhap.Location = new Point(319, 588);
            llbl_DangNhap.Margin = new Padding(4, 0, 4, 0);
            llbl_DangNhap.Name = "llbl_DangNhap";
            llbl_DangNhap.Size = new Size(99, 22);
            llbl_DangNhap.TabIndex = 19;
            llbl_DangNhap.TabStop = true;
            llbl_DangNhap.Text = "Đăng Nhập";
            llbl_DangNhap.LinkClicked += llbl_DangNhap_LinkClicked;
            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 740);
            Controls.Add(llbl_DangNhap);
            Controls.Add(ckb_HienMK);
            Controls.Add(btn_DangKy);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Email);
            Controls.Add(txt_XacNhanMK);
            Controls.Add(txt_MK);
            Controls.Add(txt_TenDN);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "frmDangKy";
            Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_MK;
        private TextBox txt_TenDN;
        private PictureBox pictureBox1;
        private TextBox txt_XacNhanMK;
        private TextBox txt_Email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_DangKy;
        private CheckBox ckb_HienMK;
        private LinkLabel llbl_DangNhap;
    }
}