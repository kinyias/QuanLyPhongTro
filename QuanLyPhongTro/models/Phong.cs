using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.models
{
    [Serializable]
    public class Phong
    {
        private string m_maphong;
        private double m_giaphong;
        private double m_dientich;
        private bool m_booleanTrangThai;
        public Phong()
        {
            m_maphong = string.Empty;
            m_giaphong = 0;
            m_dientich = 0;
            m_booleanTrangThai = false;
        }
        public Phong(string maphong, double giaphong, double dientich,bool booleanTrangThai)
        {
            m_maphong = maphong;
            m_giaphong = giaphong;
            m_dientich = dientich;
            m_booleanTrangThai = booleanTrangThai;
        }

        public string Maphong { get => m_maphong; }
        public double Giaphong { get => m_giaphong; set => m_giaphong = value; }
        public double Dientich { get => m_dientich; }
        public string Trangthai { get {
                if (m_booleanTrangThai == true)
                    return "Phòng trống";
                else
                    return "Phòng đã thuê";
            } }

        public bool BooleanTrangThai { get => m_booleanTrangThai; set => m_booleanTrangThai = value; }

        public override string ToString()
        {
            return Maphong;
        }
    }
}
