using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using myprogram.BLL.DTO;
using myprogram.BLL.Interface;
using myprogram.DAL.Models;

namespace myprogram.Controllers
{
    [Route("/api/Load")]
    //[Authorize]
    public class LoadController : ControllerBase
    {
        private ILoadService _LoadService;
        private IMapper _mapper;

        #region Constructors
        public LoadController(ILoadService service,IMapper mapper)
        {
            _LoadService = service;
            _mapper = mapper;
        }
        #endregion

        [HttpGet]
        [Route("GetLoad")]
        
        public async Task<IEnumerable<LoadDTO>> GetAllLoad()
        {
            var load = await _LoadService.GetAllLoad();
            var resource = _mapper.Map<IEnumerable<Load>, IEnumerable<LoadDTO>>(load);
            return resource;
        }

        [HttpGet]
        [Route("GetLoad/{id}")]
        public async Task<LoadDTO> GetLoadById(int id)
        {
            var load = await _LoadService.GetLoadById(id);
            var resource = _mapper.Map<Load, LoadDTO>(load);
            return resource;
        }

        [HttpPost]
        [Route("AddLoad")]
        public async Task AddLoad([FromBody] LoadDTO Load)
        {
            var load = _mapper.Map<LoadDTO, Load>(Load);
            await _LoadService.AddLoad(load);
        }

        [HttpDelete]
        [Route("RemoveLoad/{id}")]
        public void DeleteLoad(int id)
        {
            _LoadService.DeleteLoad(id);
        }

        [Route("UpdateLoad/{id}")]
        [HttpPut]
        public void UpdateLoad(int id,[FromBody]Load load)
        {
            _LoadService.UpdateLoad( id,load);
        }

        [HttpGet]
        [Route("GetLoad12")]
        public IQueryable<Object> GetZaputByCodDial()
        {
            return _LoadService.GetZaputByCodDial();
        }
    }
}
