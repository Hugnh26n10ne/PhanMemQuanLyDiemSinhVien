namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormQuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuenMK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SendOTP = new System.Windows.Forms.Button();
            this.tbx_OTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_QMK = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.tbx_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lb_QMK);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 616);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SendOTP);
            this.groupBox2.Controls.Add(this.tbx_OTP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(163, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 203);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OTP";
            // 
            // btn_SendOTP
            // 
            this.btn_SendOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_SendOTP.Font = new System.Drawing.Font("UTM Akashi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendOTP.ForeColor = System.Drawing.Color.White;
            this.btn_SendOTP.Location = new System.Drawing.Point(120, 116);
            this.btn_SendOTP.Name = "btn_SendOTP";
            this.btn_SendOTP.Size = new System.Drawing.Size(430, 47);
            this.btn_SendOTP.TabIndex = 4;
            this.btn_SendOTP.Text = "Gửi";
            this.btn_SendOTP.UseVisualStyleBackColor = false;
            this.btn_SendOTP.Click += new System.EventHandler(this.btn_SendOTP_Click);
            // 
            // tbx_OTP
            // 
            this.tbx_OTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_OTP.Location = new System.Drawing.Point(120, 69);
            this.tbx_OTP.Name = "tbx_OTP";
            this.tbx_OTP.Size = new System.Drawing.Size(430, 30);
            this.tbx_OTP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập OTP";
            // 
            // lb_QMK
            // 
            this.lb_QMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_QMK.Font = new System.Drawing.Font("UTM Alexander", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_QMK.Location = new System.Drawing.Point(236, 9);
            this.lb_QMK.Name = "lb_QMK";
            this.lb_QMK.Size = new System.Drawing.Size(484, 81);
            this.lb_QMK.TabIndex = 1;
            this.lb_QMK.Text = "QUÊN MẬT KHẨU";
            this.lb_QMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_Email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_SendEmail);
            this.groupBox1.Controls.Add(this.tbx_TaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(163, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 280);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_SendEmail.Font = new System.Drawing.Font("UTM Akashi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendEmail.ForeColor = System.Drawing.Color.White;
            this.btn_SendEmail.Location = new System.Drawing.Point(120, 214);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(430, 47);
            this.btn_SendEmail.TabIndex = 4;
            this.btn_SendEmail.Text = "Gửi";
            this.btn_SendEmail.UseVisualStyleBackColor = false;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tbx_TaiKhoan
            // 
            this.tbx_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_TaiKhoan.Location = new System.Drawing.Point(120, 69);
            this.tbx_TaiKhoan.Name = "tbx_TaiKhoan";
            this.tbx_TaiKhoan.Size = new System.Drawing.Size(430, 30);
            this.tbx_TaiKhoan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tài khoản";
            // 
            // tbx_Email
            // 
            this.tbx_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Email.Location = new System.Drawing.Point(120, 155);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(430, 30);
            this.tbx_Email.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập email";
            // 
            // FormQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 616);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(974, 663);
            this.Name = "FormQuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý điểm sinh viên";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_QMK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.TextBox tbx_TaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SendOTP;
        private System.Windows.Forms.TextBox tbx_OTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Label label3;
    }
}