using QuanLyPhongTro.database;
using QuanLyPhongTro.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyPhongTro.services
{
    [Serializable]
    class XuLyKhachHang : IServices<KhachHang>
    {
        private List<KhachHang> List;
        public XuLyKhachHang()
        {
            List = CDataAccessLayer.Init().getLstKhachHang();
        }

        public void create(KhachHang entity)
        {
            if (entity == null)
                return;
            KhachHang p = List.Find(ph => ph.Makhach == entity.Makhach);
            if (p == null)
            {
                List.Add(entity);
                return;
            }
            return;
        }

        public void delete(KhachHang entity)
        {
            if (entity == null)
                return;
            KhachHang p = List.Find(ph => ph.Makhach == entity.Makhach);
            if (p != null)
            {
                List.Remove(entity);
                return;
            }
            return;
        }

        public List<KhachHang> getAll()
        {
            return List;
        }
        public void DisplayOnDataGridView(DataGridView dgv)
        {
            if (dgv == null) return;
            BindingSource bs = new BindingSource();
            bs.DataSource = List;
            dgv.DataSource = bs;
        }

        public void update(string id, KhachHang entity)
        {
            KhachHang kh = List.Find(kh => kh.Makhach == id);
            if (kh != null)
            {
                kh.Makhach = entity.Makhach;
                kh.Hoten = entity.Hoten;
                kh.Quequan = entity.Quequan;
                kh.Sdt = entity.Sdt;
                kh.Ngaysinh = entity.Ngaysinh;
                kh.Ngaythue = entity.Ngaythue;
                kh.Ngayketthuc = entity.Ngayketthuc;
                return;
            }
            return;
        }
    }
}
