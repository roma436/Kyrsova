using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.BLL.Interface
{
    public interface ILoadService
    {
        Task AddLoad(Load load);

        void UpdateLoad(int id,Load load);

        void DeleteLoad(int id);

        Task<Load> GetLoadById(int id);

        Task<IEnumerable<Load>> GetAllLoad();

        IQueryable<Object> GetZaputByCodDial();
    }
}
