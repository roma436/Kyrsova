using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.BLL.Interface
{
    public interface ISubjectService
    {
        Task AddSubject(Subject subject);

        void UpdateSubject(int id, Subject subject);

        void DeleteSubject(int id);

        Task<Subject> GetSubjectById(int id);

        Task<IEnumerable<Subject>> GetAllSubject();
    }
}
