using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyAquariumAPI.Data;
using MyAquariumAPI.DTO;
using System.Collections.Generic;

namespace MyAquariumAPI.Controllers
{
    [Route("api/tanks")]
    [ApiController]
    public class TanksController : ControllerBase
    {
        private readonly IAquariumRepository _Repository;
        private readonly IMapper _Mapper;

        public TanksController(IAquariumRepository repository, IMapper mapper)
        {
            _Repository = repository;
            _Mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ITankDTO>> GetAllTanks()
        {
            IEnumerable<ITank> myTanks = _Repository.GetAllTanks();

            return Ok(_Mapper.Map<IEnumerable<ITankDTO>>(myTanks));
        }

        [HttpGet("{id}")]
        public ActionResult<ITankDTO> GetTank(int id)
        {
            ITank myTank = _Repository.GetTank(id);

            if (myTank != null)
            {
                return Ok(_Mapper.Map<ITankDTO>(myTank));
            }

            return NotFound();
        }
    }
}
