using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.BLL.Interface
{
    public interface ITeacherService
    {
        Task AddTeacher(Teacher teacher);

        void UpdateTeacher(int id,Teacher teacher);

        void DeleteTeacher(int id);

        Task<Teacher> GetTeacherById(int id);

        Task<IEnumerable<Teacher>> GetAllTeacher();
    }
}
