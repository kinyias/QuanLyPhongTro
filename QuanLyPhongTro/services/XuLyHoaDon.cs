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
    internal class XuLyHoaDon : IServices<HoaDon>
    {
        private List<HoaDon> List;
        public XuLyHoaDon()
        {
            List = CDataAccessLayer.Init().getLstHoaDon();
        }

        public void create(HoaDon entity)
        {
            if (entity == null)
                return;
            HoaDon p = List.Find(ph => ph.Mahoadon == entity.Mahoadon);
            if (p == null)
            {
                List.Add(entity);
                return;
            }
            return;
        }

        public void delete(HoaDon entity)
        {
            if (entity == null)
                return;
            HoaDon p = List.Find(ph => ph.Mahoadon == entity.Mahoadon);
            if (p != null)
            {
                List.Remove(entity);
                return;
            }
            return;
        }

        public List<HoaDon> getAll()
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

        public void update(string id, HoaDon entity)
        {
            if (entity == null)
                return;
            HoaDon hd = List.Find(hd => hd.Mahoadon == entity.Mahoadon);
            if (hd != null)
            {
                hd.Mahoadon = entity.Mahoadon;
                hd.Makhachhang = entity.Makhachhang;
                hd.Tiendien = entity.Tiendien;
                hd.Tiennuoc = entity.Tiennuoc;
                hd.Maphong = entity.Maphong;
                hd.BooleanTrangThai = entity.BooleanTrangThai;
                return;
            }
            return;
        }
    }
}
