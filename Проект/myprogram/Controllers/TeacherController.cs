using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using myprogram.BLL.DTO;
using myprogram.BLL.Interface;
using myprogram.DAL.Models;

namespace myprogram.Controllers
{
    [Route("/api/Teacher")]
    public class TeacherController : ControllerBase
    {
        private ITeacherService _TeacherService;
        private IMapper _mapper;

        #region Constructors
        public TeacherController(ITeacherService service, IMapper mapper)
        {
            _TeacherService = service;
            _mapper = mapper;
        }
        #endregion

        [HttpGet]
        [Route("GetTeacher")]
        public async Task<IEnumerable<TeacherDTO>> GetAllTeacher()
        {
            var teacher = await _TeacherService.GetAllTeacher();
            var resource = _mapper.Map<IEnumerable<Teacher>, IEnumerable<TeacherDTO>>(teacher);
            return resource;
        }

        [HttpGet]
        [Route("GetTeacher/{id}")]
        public async Task<TeacherDTO> GetTeacherById(int id)
        {
            var teacher = await _TeacherService.GetTeacherById(id);
            var resource = _mapper.Map<Teacher, TeacherDTO>(teacher);
            return resource;
        }

        [HttpPost]
        [Route("AddTeacher")]
        public async Task AddTeacher([FromBody] TeacherDTO Teacher)
        {
            var teacher = _mapper.Map<TeacherDTO, Teacher>(Teacher);
            await _TeacherService.AddTeacher(teacher);
        }

        [HttpDelete]
        [Route("RemoveTeacher/{id}")]
        public void DeleteTeacher(int id)
        {
            _TeacherService.DeleteTeacher(id);
        }

        [Route("UpdateTeacher/{id}")]
        [HttpPut]
        public void UpdateTeacher(int id,[FromBody]Teacher teacher)
        {
            _TeacherService.UpdateTeacher(id,teacher);
        }
    }
}
