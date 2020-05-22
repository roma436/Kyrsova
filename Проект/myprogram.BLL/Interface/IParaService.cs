using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.BLL.Interface
{
    public interface IParaService
    {
        Task AddPara(Para para);

        void UpdatePara(int id,Para para);

        void DeletePara(int id);

        Task<Para> GetParaById(int id);

        Task<IEnumerable<Para>> GetAllPara();

        IQueryable<Object> GetParaByCodDial();
    }
}
