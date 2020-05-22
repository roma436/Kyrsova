using myprogram.DAL.Interface;
using myprogram.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.BLL.Service
{
    public class ParaService : IParaService
    {
        private IUnitOfWork _UnitOfWork;

        public ParaService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task AddPara(Para para)
        {
            await _UnitOfWork.ParaRepository.Insert(para);
        }

        public void DeletePara(int id)
        {
            _UnitOfWork.ParaRepository.Delete(id);
        }

        public async Task<IEnumerable<Para>> GetAllPara()
        {
            var para = await _UnitOfWork.ParaRepository.GetAll();
            return para;
        }

        public async Task<Para> GetParaById(int id)
        {
            var para = await _UnitOfWork.ParaRepository.GetById(id);
            return para;
        }

        public void UpdatePara(int id,Para para)
        {
            _UnitOfWork.ParaRepository.Update(id,para);
        }

        public IQueryable<Object> GetParaByCodDial()
        {
            return _UnitOfWork.ParaRepository.GetParaByCodDial();
        }
    }
}
