using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.DAL.Interface
{
    public interface ILoadRepository : IGenericRepository<Load>
    {
        
        public IQueryable<Object> GetZaputByCodDial();

    }
}
