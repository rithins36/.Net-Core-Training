using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]

        public string Get()
        {
            return "API Successfull!!!";
        }

        [HttpGet]
        public string GetTest()
        {
            return "Next get!!!";
        }
    }
}
