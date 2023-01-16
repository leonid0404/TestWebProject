using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models.IncomeModels.HouseModels;
using WebApplication1.Models.ViewModels.HouseModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _houseService;
        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }
        // GET: api/<HouseController>
        [HttpGet]
        public IEnumerable<HouseViewModel> Get()
        {
            return _houseService.GetAll();
        }

        // GET api/<HouseController>/5
        [HttpGet("{id}")]
        public HouseViewModel Get(Guid id)
        {
            return _houseService.Get(id);
        }

        // POST api/<HouseController>
        [HttpPost]
        public void Post([FromBody] HouseIncomeModel houseIncomeModel)
        {
            _houseService.Create(houseIncomeModel);
        }

        // PUT api/<HouseController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] HouseIncomeModel houseIncomeModel)
        {
            _houseService.Update(id, houseIncomeModel);
        }

        // DELETE api/<HouseController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _houseService.Remove(id);
        }
    }
}
