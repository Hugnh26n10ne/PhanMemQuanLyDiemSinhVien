using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyDiemSinhVien
{
    internal class cls_SinhVien
    {
        private string m_TaiKhoan = "";
        private string m_MatKhau = "";
        private int m_Level = 0;

        #region "Thuộc tính User"

        public string TaiKhoan { get => m_TaiKhoan; set => m_TaiKhoan = value; }
        public string MatKhau { get => m_MatKhau; set => m_MatKhau = value; }
        public int Level { get => m_Level; set => m_Level = value; }

        #endregion
    }
}
