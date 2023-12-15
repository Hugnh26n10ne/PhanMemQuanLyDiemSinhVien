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
        public int CheckTaiKhoan(string taiKhoan)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int ketQua = 0;

            string query = "SELECT 1 FROM [73DCTT23_QLDiemSV].[dbo].[User] WHERE [tai_khoan] = @tai_khoan";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@tai_khoan", taiKhoan);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Tài khoản tồn tại
                        ketQua = 1;
                    }
                }
            }


            return ketQua;
        }
        public int CheckMatKhau(string matKhau)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int ketQua = 0;

            string query = "SELECT 1 FROM [73DCTT23_QLDiemSV].[dbo].[User] WHERE [mat_khau] = @mat_khau";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@mat_khau", matKhau);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Tài khoản tồn tại
                        ketQua = 1;
                    }
                }
            }


            return ketQua;
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
            if(CheckTaiKhoan(sinhVien.TaiKhoan) != 1)
            {
                MessageBox.Show("Tài khoản không tồn tại!");
                tbx_TaiKhoan.Focus();
            }
            if (CheckMatKhau(sinhVien.MatKhau) != 1)
            {
                MessageBox.Show("Sai mật khẩu!");
                tbx_MatKhau.Focus();
            }
            MessageBox.Show("Đăng nhập thành công!");
        }

        private void pbx_Show_Click(object sender, EventArgs e)
        {
            pbx_Show.Hide();
            pbx_Hide.Show();
            tbx_MatKhau.PasswordChar = '*';
        }

        private void pbx_Hide_Click(object sender, EventArgs e)
        {
            pbx_Hide.Hide();
            pbx_Show.Show();
            tbx_MatKhau.PasswordChar = default;
        }
    }
}
