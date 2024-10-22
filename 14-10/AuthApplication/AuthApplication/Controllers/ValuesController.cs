using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
      
        [HttpGet]

        [Authorize]

        public IActionResult Get()

        {

            return Ok(new { value = "This is a protected view" });

        }
    }
}
