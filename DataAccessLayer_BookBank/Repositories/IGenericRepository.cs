using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BookBank.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        T GetById(int id);
        public void Add(T entity);
        public void Remove(T entity);
        public void Modify(T entity);
        public void Save();
    }
}
