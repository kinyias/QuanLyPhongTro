using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.models
{
    [Serializable]
    class Phong
    {
        private string m_maphong;
        private double m_giaphong;
        private double m_dientich;
        private string m_trangthai;
        Phong()
        {
            m_maphong = string.Empty;
            m_giaphong = 0;
            m_dientich = 0;
            m_trangthai = string.Empty;
        }
        Phong(string maphong, double giaphong, double dientich, string trangthai)
        {
            m_maphong = maphong;
            m_giaphong = giaphong;
            m_dientich = dientich;
            m_trangthai = trangthai;
        }

        public string Maphong { get => m_maphong; set => m_maphong = value; }
        public double Giaphong { get => m_giaphong; set => m_giaphong = value; }
        public double Dientich { get => m_dientich; set => m_dientich = value; }
        public string Trangthai { get => m_trangthai; set => m_trangthai = value; }
    }
}
