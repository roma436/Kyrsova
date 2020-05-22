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
    [Route("/api/Para")]
    public class ParaController : ControllerBase
    {
        private IParaService _ParaService;
        private IMapper _mapper;

        #region Constructors
        public ParaController(IParaService service, IMapper mapper)
        {
            _ParaService = service;
            _mapper = mapper;
        }
        #endregion

        [HttpGet]
        [Route("GetPara")]
        public async Task<IEnumerable<ParaDTO>> GetAllPara()
        {
            var para = await _ParaService.GetAllPara();
            var resource = _mapper.Map<IEnumerable<Para>, IEnumerable<ParaDTO>>(para);
            return resource;
        }

        [HttpGet]
        [Route("GetPara/{id}")]
        public async Task<ParaDTO> GetParaById(int id)
        {
            var para = await _ParaService.GetParaById(id);
            var resource = _mapper.Map<Para, ParaDTO>(para);
            return resource;
        }

        [HttpPost]
        [Route("AddPara")]
        public async Task AddPara([FromBody] ParaDTO Para)
        {
            var para = _mapper.Map<ParaDTO, Para>(Para);
            await _ParaService.AddPara(para);
        }

        [HttpDelete]
        [Route("RemovePara/{id}")]
        public void DeletePara(int id)
        {
            _ParaService.DeletePara(id);
        }

        [Route("UpdatePara/{id}")]
        [HttpPut]
        public void UpdatePara(int id,[FromBody]Para para)
        {
            _ParaService.UpdatePara(id,para);
        }

        [HttpGet]
        [Route("roma")]
        public IQueryable<Object> GetParaByCodDial()
        {
            return _ParaService.GetParaByCodDial();
        }
    }
}
