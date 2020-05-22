        
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
    [Route("/api/Subject")]
    public class SubjectController : ControllerBase
    {
        private ISubjectService _SubjectService;
        private IMapper _mapper;

        #region Constructors
        public SubjectController(ISubjectService service, IMapper mapper)
        {
            _SubjectService = service;
            _mapper = mapper;
        }
        #endregion

        [HttpGet]
        [Route("GetSubject")]
        public async Task<IEnumerable<SubjectDTO>> GetAllSubject()
        {
            var subject = await _SubjectService.GetAllSubject();
            var resource = _mapper.Map<IEnumerable<Subject>, IEnumerable<SubjectDTO>>(subject);
            return resource;
        }

        [HttpGet]
        [Route("GetSubject/{id}")]
        public async Task<SubjectDTO> GetSubjectById(int id)
        {
            var subject = await _SubjectService.GetSubjectById(id);
            var resource = _mapper.Map<Subject, SubjectDTO>(subject);
            return resource;
        }

        [HttpPost]
        [Route("AddSubject")]
        public async Task AddSubject([FromBody] SubjectDTO Subject)
        {
            var subject = _mapper.Map<SubjectDTO, Subject>(Subject);
            await _SubjectService.AddSubject(subject);
        }

        [HttpDelete]
        [Route("RemoveSubject/{id}")]
        public void DeleteSubject(int id)
        {
            _SubjectService.DeleteSubject(id);
        }

        [Route("UpdateSubject/{id}")]
        [HttpPut]
        public void UpdateSubject(int id, [FromBody]Subject subject)
        {
            _SubjectService.UpdateSubject(id ,subject);
        }
    }
}
