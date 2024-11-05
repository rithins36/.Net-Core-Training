using ExerciseAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExerciseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<User> _users=new List<User>();

        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(_users);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            if ( user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] User value)
        {
            _users.Add(value);
            return Ok();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {


        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
