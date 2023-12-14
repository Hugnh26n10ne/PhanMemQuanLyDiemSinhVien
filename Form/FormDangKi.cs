using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormDangKi : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public FormDangKi()
        {
            InitializeComponent();
        }

        private bool CheckNLMK()
        {
            if (tbx_TaiKhoan.Text == tbx_NhapLMK.Text) return true;
            return false;
        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            if (!CheckNLMK())
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp!");
                tbx_NhapLMK.Text = "";
                tbx_NhapLMK.Focus();
                return; 
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }


            cls_SinhVien sinhVien = new cls_SinhVien()
            {
                TaiKhoan = tbx_TaiKhoan.Text,
                MatKhau = tbx_MatKhau.Text,
                Level = 0,
            };

            string query = $"INSERT INTO [User] (tai_khoan, mat_khau, rank) VALUES (N'{sinhVien.TaiKhoan}', N'{sinhVien.MatKhau}', {sinhVien.Level}) ";

            MessageBox.Show(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
