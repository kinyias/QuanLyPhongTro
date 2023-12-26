using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.models
{
    [Serializable]
    public class HoaDon
    {
        private string m_mahoadon;
        private string m_makhachhang;
        private string m_maphong;
        private double m_tiendien;
        private double m_tiennuoc;
        private bool m_booleanTrangThai;

        public HoaDon() { 
            m_mahoadon = string.Empty;
            m_makhachhang = string.Empty;
            m_tiendien = 0;
            m_tiennuoc = 0;
            m_booleanTrangThai = false;
        }
        public HoaDon(string mahoadon, string makhachhang, double tiendien, double tiennuoc, string maphong, bool trangthai)
        {
            m_mahoadon = mahoadon;
            m_makhachhang = makhachhang;
            m_tiendien = tiendien;
            m_tiennuoc = tiennuoc;
            m_maphong = maphong;
            m_booleanTrangThai = trangthai;
        }

        public string Mahoadon { get => m_mahoadon; set => m_mahoadon = value; }
        public string Makhachhang { get => m_makhachhang; set => m_makhachhang = value; }
        public string Maphong { get => m_maphong; set => m_maphong = value; }
        public double Tiendien { get => m_tiendien; set => m_tiendien = value; }
        public double Tiennuoc { get => m_tiennuoc; set => m_tiennuoc = value; }
        public string Trangthai
        {
            get
            {
                if (m_booleanTrangThai == true)
                    return "Đã đóng tiền";
                else
                    return "Chưa đóng tiền";
            }
        }

        public bool BooleanTrangThai { get => m_booleanTrangThai; set => m_booleanTrangThai = value; }
    }
}
