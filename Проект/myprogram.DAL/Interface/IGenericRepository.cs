using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace myprogram.DAL.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int Id);
        Task Insert(T obj);
        void Delete(int Id);
        void Update(int id, T obj);
    }
}