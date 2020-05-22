using myprogram.DAL.Interface;
using myprogram.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.BLL.Service
{
    public class LoadService : ILoadService
    {
        private IUnitOfWork _UnitOfWork;

        public LoadService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task AddLoad(Load load)
        {
           await _UnitOfWork.LoadRepository.Insert(load);
        }

        public void DeleteLoad(int id)
        {
            _UnitOfWork.LoadRepository.Delete(id);
        }

        public async Task <IEnumerable<Load>> GetAllLoad()
        {
            var load = await  _UnitOfWork.LoadRepository.GetAll();
            return load;
        }

        public async Task <Load>GetLoadById(int id)
        {
            var load = await _UnitOfWork.LoadRepository.GetById(id);
            return load;
        }

        public void UpdateLoad(int id,Load load)
        {
            _UnitOfWork.LoadRepository.Update(id,load);
        }

        public IQueryable<Object> GetZaputByCodDial()
        {
            return _UnitOfWork.LoadRepository.GetZaputByCodDial();
        }
    }        
}
