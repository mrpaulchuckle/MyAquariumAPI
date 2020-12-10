using Microsoft.AspNetCore.Mvc;
using MyAquariumAPI.Data;
using System.Collections.Generic;

namespace MyAquariumAPI.Controllers
{
    [Route("api/tanks")]
    [ApiController]
    public class TanksController : ControllerBase
    {
        private readonly IRepository _Repository;
        public TanksController(IRepository repository)
        {
            _Repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ITank>> GetAllTanks()
        {
            IEnumerable<ITank> myTanks = _Repository.GetAllTanks();

            return Ok(myTanks);
        }

        [HttpGet("{id}")]
        public ActionResult<ITank> GetTank(int id)
        {
            ITank myTank = _Repository.GetTank(id);
            return Ok(myTank);
        }
    }
}
