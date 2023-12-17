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
            throw new NotImplementedException();
        }
    }
}
