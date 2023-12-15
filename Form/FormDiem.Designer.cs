namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormDiem
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
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.ln_chonhocki = new System.Windows.Forms.Label();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.cbx_Chonhocky = new System.Windows.Forms.ComboBox();
            this.btn_Xuatfile = new System.Windows.Forms.Button();
            this.grb_Bangdiemsv = new System.Windows.Forms.GroupBox();
            this.dtgrv_bangdiemsv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_Bangdiemsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_bangdiemsv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(145, 20);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(230, 22);
            this.txt_timkiem.TabIndex = 11;
            // 
            // ln_chonhocki
            // 
            this.ln_chonhocki.AutoSize = true;
            this.ln_chonhocki.Font = new System.Drawing.Font("UTM Alexander", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_chonhocki.Location = new System.Drawing.Point(547, 21);
            this.ln_chonhocki.Name = "ln_chonhocki";
            this.ln_chonhocki.Size = new System.Drawing.Size(88, 18);
            this.ln_chonhocki.TabIndex = 10;
            this.ln_chonhocki.Text = "Chọn Học Kỳ: ";
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("UTM Alexander", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(76, 20);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(61, 18);
            this.lb_timkiem.TabIndex = 9;
            this.lb_timkiem.Text = "Tìm Kiếm";
            // 
            // cbx_Chonhocky
            // 
            this.cbx_Chonhocky.FormattingEnabled = true;
            this.cbx_Chonhocky.Items.AddRange(new object[] {
            "Học kì 1",
            "Học kì 2",
            "Học kì 3"});
            this.cbx_Chonhocky.Location = new System.Drawing.Point(641, 18);
            this.cbx_Chonhocky.Name = "cbx_Chonhocky";
            this.cbx_Chonhocky.Size = new System.Drawing.Size(121, 24);
            this.cbx_Chonhocky.TabIndex = 8;
            // 
            // btn_Xuatfile
            // 
            this.btn_Xuatfile.Font = new System.Drawing.Font("UTM Alexander", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuatfile.Location = new System.Drawing.Point(428, 388);
            this.btn_Xuatfile.Name = "btn_Xuatfile";
            this.btn_Xuatfile.Size = new System.Drawing.Size(117, 42);
            this.btn_Xuatfile.TabIndex = 7;
            this.btn_Xuatfile.Text = "Xuất file Exel";
            this.btn_Xuatfile.UseVisualStyleBackColor = true;
            // 
            // grb_Bangdiemsv
            // 
            this.grb_Bangdiemsv.Controls.Add(this.dtgrv_bangdiemsv);
            this.grb_Bangdiemsv.Font = new System.Drawing.Font("UTM Alexander", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Bangdiemsv.Location = new System.Drawing.Point(62, 66);
            this.grb_Bangdiemsv.Name = "grb_Bangdiemsv";
            this.grb_Bangdiemsv.Size = new System.Drawing.Size(827, 306);
            this.grb_Bangdiemsv.TabIndex = 12;
            this.grb_Bangdiemsv.TabStop = false;
            this.grb_Bangdiemsv.Text = "Bảng Điểm Sinh Viên";
            // 
            // dtgrv_bangdiemsv
            // 
            this.dtgrv_bangdiemsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_bangdiemsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dtgrv_bangdiemsv.Location = new System.Drawing.Point(0, 24);
            this.dtgrv_bangdiemsv.Name = "dtgrv_bangdiemsv";
            this.dtgrv_bangdiemsv.RowHeadersWidth = 51;
            this.dtgrv_bangdiemsv.RowTemplate.Height = 24;
            this.dtgrv_bangdiemsv.Size = new System.Drawing.Size(956, 292);
            this.dtgrv_bangdiemsv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 56;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã học phần";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên học phần";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số tính chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Lần học";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Lần thi";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Đánh giá";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã sinh viên";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Chuyên cần";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Điểm thực hành";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Điểm thảo luận";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Kiểm tra giữa kì";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Thi kết thúc";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Tổng kết học phần";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Điểm chữ";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // FormDIem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.grb_Bangdiemsv);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.ln_chonhocki);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.cbx_Chonhocky);
            this.Controls.Add(this.btn_Xuatfile);
            this.Name = "FormDIem";
            this.Text = "FormDIem";
            this.grb_Bangdiemsv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_bangdiemsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label ln_chonhocki;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.ComboBox cbx_Chonhocky;
        private System.Windows.Forms.Button btn_Xuatfile;
        private System.Windows.Forms.GroupBox grb_Bangdiemsv;
        private System.Windows.Forms.DataGridView dtgrv_bangdiemsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}