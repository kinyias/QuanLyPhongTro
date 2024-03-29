﻿using QuanLyPhongTro.views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.models
{
    [Serializable]
    public class KhachHang
    {
        private string m_makhach;
        private string m_phong;
        private string m_hoten;
        private DateTime m_ngaysinh;
        private string m_quequan;
        private string m_sdt;
        private DateTime m_ngaythue;
        private DateTime m_ngayketthuc;
        public KhachHang()
        {
            m_makhach = string.Empty;
            m_phong = string.Empty;
            m_hoten = string.Empty;
            m_ngaysinh = DateTime.Now;
            m_quequan = string.Empty;
            m_sdt = string.Empty;
            m_ngaythue = DateTime.Now;
            m_ngayketthuc = DateTime.Now;
        }
        public KhachHang(string makhach, string maphong, string hoten, DateTime ngaysinh, string quequan, string sdt, DateTime ngaythue, DateTime ngayketthuc)
        {
            m_makhach = makhach;
            m_phong = maphong;
            m_hoten = hoten;
            m_ngaysinh = ngaysinh;
            m_quequan = quequan;
            m_sdt = sdt;
            m_ngaythue = ngaythue;
            m_ngayketthuc = ngayketthuc;
        }

        public string Makhach { get => m_makhach; set => m_makhach = value; }
        public string Maphong { get => m_phong; set => m_phong = value; }
        public string Hoten { get => m_hoten; set => m_hoten = value; }
        public DateTime Ngaysinh { get => m_ngaysinh; set => m_ngaysinh = value; }
        public string Quequan { get => m_quequan; set => m_quequan = value; }
        public string Sdt { get => m_sdt; set => m_sdt = value; }
        public DateTime Ngaythue { get => m_ngaythue; set => m_ngaythue = value; }
        public DateTime Ngayketthuc { get => m_ngayketthuc; set => m_ngayketthuc = value; }
    }
}
