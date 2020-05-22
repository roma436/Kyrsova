
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity.Validation;
using myprogram;
using myprogram.DAL.Interface;
//using System.Data.Entity;

namespace myprogram.DAL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected karaContext _context;

        private DbSet<T> dbSet;

        public GenericRepository(karaContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.AsNoTracking()
                              .ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task Insert(T obj)
        {
            await dbSet.AddAsync(obj);
            _context.SaveChanges();
        }

        public  void Delete(int id)
        {
            T entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
            _context.SaveChanges();
        }

        public void Update(int id, T obj)
        {
            dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            
        }
    }
}

