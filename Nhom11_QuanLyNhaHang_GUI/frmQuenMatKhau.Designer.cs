namespace RESTAURANT_MANAGEMENT
{
    partial class frmQuenMatKhau
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
            label1 = new Label();
            txt_Email = new TextBox();
            btn_Send = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 63);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào Email của tài khoản";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(190, 116);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(377, 31);
            txt_Email.TabIndex = 1;
            // 
            // btn_Send
            // 
            btn_Send.BackColor = Color.Blue;
            btn_Send.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Send.ForeColor = SystemColors.Window;
            btn_Send.Location = new Point(324, 169);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(109, 51);
            btn_Send.TabIndex = 2;
            btn_Send.Text = "SEND";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += btn_Send_Click;
            // 
            // frmQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 292);
            Controls.Add(btn_Send);
            Controls.Add(txt_Email);
            Controls.Add(label1);
            Name = "frmQuenMatKhau";
            Text = "frmQuenMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Email;
        private Button btn_Send;
    }
}