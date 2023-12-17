using System;
using System.Collections.Generic;
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
    public partial class FormRePassword : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public FormRePassword()
        {
            InitializeComponent();
        }

        private void btn_SendPassNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (!string.IsNullOrEmpty(tbx_MatKhauNew.Text))
                {
                    string query = $"UPDATE [User] SET mat_khau = '{tbx_MatKhauNew.Text}' WHERE tai_khoan = '{Properties.Settings.Default.tai_khoan}'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lb_DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap fdn = new FormDangNhap();
            fdn.Show();
        }
    }
}
