using myprogram.DAL.Interface;
using myprogram.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace myprogram.BLL.Service
{
    public class TeacherService : ITeacherService
    {
        private IUnitOfWork _UnitOfWork;

        public TeacherService(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public async Task AddTeacher(Teacher teacher)
        {
            await _UnitOfWork.TeacherRepository.Insert(teacher);
        }

        public void DeleteTeacher(int id)
        {
            _UnitOfWork.TeacherRepository.Delete(id);
        }

        public async Task<IEnumerable<Teacher>> GetAllTeacher()
        {
            var teacher = await _UnitOfWork.TeacherRepository.GetAll();
            return teacher;
        }

        public async Task<Teacher> GetTeacherById(int id)
        {
            var teacher = await _UnitOfWork.TeacherRepository.GetById(id);
            return teacher;
        }

        public void UpdateTeacher(int id,Teacher teacher)
        {
            _UnitOfWork.TeacherRepository.Update( id,teacher);
        }


    }
}
