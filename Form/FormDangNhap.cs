using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormDangNhap : Form
    {
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_TaiKhoan.Text))
            {
                MessageBox.Show("Không được để trống!");
                tbx_TaiKhoan.Focus();
            }
            if (string.IsNullOrEmpty(tbx_MatKhau.Text))
            {
                MessageBox.Show("Không được để trống!");
                tbx_MatKhau.Focus();
            }

            cls_SinhVien sinhVien = new cls_SinhVien()
            {
                TaiKhoan = tbx_TaiKhoan.Text,
                MatKhau = tbx_MatKhau.Text,
                Level = 0,
            };

            
        }
    }
}
