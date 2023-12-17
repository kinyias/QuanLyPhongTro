using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongTro.services
{
    public interface IServices<T>
    {
        List<T> getAll();
        void create(T entity);
        void delete(T entity);
        void update(string id,T entity);
    }
}
