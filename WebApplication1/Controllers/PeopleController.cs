using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.IncomeModels.PeopleModels;
using WebApplication1.Models.ViewModels.PeopleModels;
using WebApplication1.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService _peopleService;
        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<HumanViewModel> Get()
        {
            return _peopleService.GetAll();
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public HumanViewModel Get(Guid id)
        {
            return _peopleService.Get(id);
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post([FromBody] HumanIncomeModel human)
        {
            _peopleService.Create(human);
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Human human)
        {
            _peopleService.Update(id, human);
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _peopleService.Remove(id);
        }
    }
}
