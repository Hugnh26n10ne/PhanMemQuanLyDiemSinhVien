namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormRePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_QMK = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SendPassNew = new System.Windows.Forms.Button();
            this.tbx_MatKhauNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_DangNhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lb_QMK);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 616);
            this.panel1.TabIndex = 2;
            // 
            // lb_QMK
            // 
            this.lb_QMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_QMK.Font = new System.Drawing.Font("UTM Alexander", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_QMK.Location = new System.Drawing.Point(236, 128);
            this.lb_QMK.Name = "lb_QMK";
            this.lb_QMK.Size = new System.Drawing.Size(484, 81);
            this.lb_QMK.TabIndex = 1;
            this.lb_QMK.Text = "QUÊN MẬT KHẨU";
            this.lb_QMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_DangNhap);
            this.groupBox1.Controls.Add(this.btn_SendPassNew);
            this.groupBox1.Controls.Add(this.tbx_MatKhauNew);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(163, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập mật khẩu mới";
            // 
            // btn_SendPassNew
            // 
            this.btn_SendPassNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_SendPassNew.Font = new System.Drawing.Font("UTM Akashi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendPassNew.ForeColor = System.Drawing.Color.White;
            this.btn_SendPassNew.Location = new System.Drawing.Point(120, 129);
            this.btn_SendPassNew.Name = "btn_SendPassNew";
            this.btn_SendPassNew.Size = new System.Drawing.Size(430, 47);
            this.btn_SendPassNew.TabIndex = 4;
            this.btn_SendPassNew.Text = "Gửi";
            this.btn_SendPassNew.UseVisualStyleBackColor = false;
            this.btn_SendPassNew.Click += new System.EventHandler(this.btn_SendPassNew_Click);
            // 
            // tbx_MatKhauNew
            // 
            this.tbx_MatKhauNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_MatKhauNew.Location = new System.Drawing.Point(120, 79);
            this.tbx_MatKhauNew.Name = "tbx_MatKhauNew";
            this.tbx_MatKhauNew.Size = new System.Drawing.Size(430, 30);
            this.tbx_MatKhauNew.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu mới";
            // 
            // lb_DangNhap
            // 
            this.lb_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_DangNhap.ForeColor = System.Drawing.Color.Red;
            this.lb_DangNhap.Image = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.login;
            this.lb_DangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_DangNhap.Location = new System.Drawing.Point(407, 179);
            this.lb_DangNhap.Name = "lb_DangNhap";
            this.lb_DangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_DangNhap.Size = new System.Drawing.Size(143, 51);
            this.lb_DangNhap.TabIndex = 5;
            this.lb_DangNhap.Text = "Đăng nhập";
            this.lb_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_DangNhap.Click += new System.EventHandler(this.lb_DangNhap_Click);
            // 
            // FormRePassword
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
            this.Name = "FormRePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý điểm sinh viên";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_QMK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SendPassNew;
        private System.Windows.Forms.TextBox tbx_MatKhauNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_DangNhap;
    }
}