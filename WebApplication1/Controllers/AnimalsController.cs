using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalsService _animalsService;
        public AnimalsController(IAnimalsService animalsService)
        {
            _animalsService = animalsService;
        }

        // GET: api/<AnimalsController>
        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return _animalsService.GetAll();
        }

        // GET api/<AnimalsController>/5
        [HttpGet("{id}")]
        public Animal? Get(int id)
        {
            return _animalsService.Get(id);
        }

        // POST api/<AnimalsController>
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _animalsService.Create(animal);
        }

        // PUT api/<AnimalsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)
        {
            _animalsService.Update(id, animal);
        }

        // DELETE api/<AnimalsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _animalsService.Remove(id);
        }
    }
}
