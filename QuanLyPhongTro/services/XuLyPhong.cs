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
    internal class XuLyPhong : IServices<Phong>
    {
        private List<Phong> List;
        public XuLyPhong()
        {
            List = CDataAccessLayer.Init().getLstPhong();
        }

        public void create(Phong entity)
        {
            if (entity == null)
                return;
            Phong p = List.Find(ph => ph.Maphong == entity.Maphong);    
            if(p == null)
            {
                List.Add(entity);
                return;
            }
            return;
        }

        public void delete(Phong entity)
        {
            if(entity == null)
                return;
            Phong p = List.Find(ph => ph.Maphong == entity.Maphong);
            if (p != null)
            {
                List.Remove(entity);
                return;
            }
            return;
        }

        public List<Phong> getAll()
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
        public void UpdatePhong(string maPhong, double giaTien)
        {
            Phong p = List.Find(ph => ph.Maphong ==  maPhong);
            if(p != null)
            {
                p.Giaphong = giaTien;
                return;
            }
            return;
        }

        public void updateTrangThai(string maPhong, bool trangthai)
        {
            Phong p = List.Find(ph => ph.Maphong == maPhong);
            if (p != null)
            {
                p.BooleanTrangThai = trangthai;
                return;
            }
            return;
        }

        public void update(string id, Phong entity)
        {
            throw new NotImplementedException();
        }
    }
}
