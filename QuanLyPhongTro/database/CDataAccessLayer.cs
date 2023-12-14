using QuanLyPhongTro.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.database
{
    [Serializable]
    internal class CDataAccessLayer
    {
        private static CDataAccessLayer _access = null;
        private static BinaryFormatter bf = new BinaryFormatter();
        private List<HoaDon> _lstHoaDon;
        private List<KhachHang> _lstKhachHang;
        private List<Phong> _lstPhong;

        private CDataAccessLayer()
        {
            _lstHoaDon = new List<HoaDon>();
            _lstKhachHang = new List<KhachHang>();
            _lstPhong = new List<Phong>();
        }

        public static CDataAccessLayer Init()
        {
            if(_access == null)
                _access = new CDataAccessLayer();
            return _access;
        }

        public List<HoaDon> getLstHoaDon() => _lstHoaDon;
        public List<KhachHang> getLstKhachHang() => _lstKhachHang;  
        public List<Phong> getLstPhong() => _lstPhong;

        public static bool readFile(string filePath)
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                _access = bf.Deserialize(fs) as CDataAccessLayer;
                fs.Close();
                return true;    
            }
            catch
            {
                _access = new CDataAccessLayer();
                return false;
            }
        }

        public static bool saveFile(string filePath)
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                bf.Serialize(fs, _access);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
