using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.models
{
    [Serializable]
     class HoaDon
    {
        private string m_mahoadon;
        private string m_makhachhang;
        private double m_tiendien;
        private double m_tiennuoc;

        HoaDon() { 
            m_mahoadon = string.Empty;
            m_makhachhang = string.Empty;
            m_tiendien = 0;
            m_tiennuoc = 0;
        }
        HoaDon(string mahoadon, string makhachhang, double tiendien, double tiennuoc)
        {
            m_mahoadon = mahoadon;
            m_makhachhang = makhachhang;
            m_tiendien = tiendien;
            m_tiennuoc = tiennuoc;
        }

        public string Mahoadon { get => m_mahoadon; set => m_mahoadon = value; }
        public string Makhachhang { get => m_makhachhang; set => m_makhachhang = value; }
        public double Tiendien { get => m_tiendien; set => m_tiendien = value; }
        public double Tiennuoc { get => m_tiennuoc; set => m_tiennuoc = value; }
    }
}
