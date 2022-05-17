using DataAccessLayer_BookBank.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BookBank.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        BookContext dbContext = null;
        DbSet<T> table = null;

        public GenericRepository()
        {
            dbContext = new BookContext();
            table = dbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Add(T entity)
        {
            dbContext.Add<T>(entity);
        }

        public void Modify(T entity)
        {
            dbContext.ChangeTracker.Clear();
            table.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(T entity)
        {
            dbContext.Remove<T>(entity);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
