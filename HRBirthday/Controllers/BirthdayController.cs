using HRBirthday.Entity;
using HRBirthday.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRBirthday.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirthdayController : ControllerBase
    {
        private readonly IStaffRepo _staffRepo;
        public BirthdayController(IStaffRepo staffRepo)
        {
            _staffRepo = staffRepo;
        }
        // GET: api/<BirthdayController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _staffRepo.GetAll();
            return Ok(result);
        }

        // GET api/<BirthdayController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BirthdayController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Staff staff)
        {
            var result = await _staffRepo.Add(staff);
            return Created("~/api/birthday/", result);
        }

        // PUT api/<BirthdayController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BirthdayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
