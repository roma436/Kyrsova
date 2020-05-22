using myprogram.DAL.Interface;
using myprogram.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.BLL.Service
{
    public class SubjectService : ISubjectService
    {
        private IUnitOfWork _UnitOfWork;

        public SubjectService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task AddSubject(Subject subject)
        {
            await _UnitOfWork.SubjectRepository.Insert(subject);
        }

        public void DeleteSubject(int id)
        {
            _UnitOfWork.SubjectRepository.Delete(id);
        }

        public async Task<IEnumerable<Subject>> GetAllSubject()
        {
            var subject = await _UnitOfWork.SubjectRepository.GetAll();
            return subject;
        }

        public async Task<Subject> GetSubjectById(int id)
        {
            var subject = await _UnitOfWork.SubjectRepository.GetById(id);
            return subject;
        }

        public void UpdateSubject(int id,Subject subject)
        {
            _UnitOfWork.SubjectRepository.Update( id,subject);
        }
    }
}
