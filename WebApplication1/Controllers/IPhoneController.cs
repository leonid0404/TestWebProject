using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IPhoneController : ControllerBase
    {
        private readonly IIPhoneService _iPhoneService;
        public IPhoneController(IIPhoneService iPhoneService)
        {
            _iPhoneService = iPhoneService;
        }
        // GET: api/<IPhoneController>
        [HttpGet]
        public IEnumerable<IPhone> Get()
        {
            return _iPhoneService.GetAll();
        }

        // GET api/<IPhoneController>/5
        [HttpGet("{id}")]
        public IPhone Get(Guid id)
        {
            return _iPhoneService.Get(id);
        }

        // POST api/<IPhoneController>
        [HttpPost]
        public void Post([FromBody] IPhone phone)
        {
            _iPhoneService.Create(phone);
        }

        // PUT api/<IPhoneController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] IPhone phone)
        {
            _iPhoneService.Update(id, phone);
        }

        // DELETE api/<IPhoneController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _iPhoneService.Remove(id);
        }
    }
}
