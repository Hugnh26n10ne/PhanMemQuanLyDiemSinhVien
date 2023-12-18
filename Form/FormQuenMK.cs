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
using System.Net.Mail;
using System.Net;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormQuenMK : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        Random rd = new Random();
        int otp;
        public FormQuenMK()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (string.IsNullOrEmpty(tbx_TaiKhoan.Text))
                {
                    MessageBox.Show("Chưa nhập tài khoản!!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("CheckTrungUSER", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@tai_khoan", SqlDbType.NVarChar, 50).Value = tbx_TaiKhoan.Text;
                    SqlParameter kq = new SqlParameter("@ket_qua", SqlDbType.Int);
                    cmd.Parameters.Add(kq).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    int m_kq = (int)kq.Value;

                    if (m_kq == 1)
                    {
                        // Lưu tài khoản
                        Properties.Settings.Default.tai_khoan = tbx_TaiKhoan.Text;
                        Properties.Settings.Default.Save();

                        // tạo mã otp
                        otp = rd.Next(100000, 1000000);
                        string formEmail = "shakaji204@gmail.com";
                        string toEmail = tbx_Email.Text;

                        var formAddress = new MailAddress(formEmail.ToString());
                        var toAddress = new MailAddress(toEmail.ToString());
                        const string formPass = "eqhzbcowqvlsexll";
                        const string subject = "Send OTP Code to Repassword !";
                        string body = $"Mã OTP của bạn là:{otp.ToString()}.\nVui lòng không cung cấp mã OTP này cho bất kì ai!!!!";

                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(formAddress.Address, formPass),
                            Timeout = 200000
                        };

                        using (var message = new MailMessage(formAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                        {
                            smtp.Send(message);
                        }
                        MessageBox.Show("OTP đã được gửi qua email!\nVui lòng kiểm tra gmail để nhận mã OTP");
                        cmd.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại!");
                        return;
                    }

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

        private void btn_SendOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_OTP.Text))
            {
                MessageBox.Show("Vui lòng không để trống!");
            }
            if (tbx_OTP.Text == otp.ToString())
            {
                this.Hide();
                FormRePassword frp = new FormRePassword();
                frp.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai mã OTP!");
                return;
            }
        }
    }
}
