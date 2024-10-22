using AuthAPI.Models.Dto;
using AuthAPI.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;
        protected ResponseDto _response;

        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto registrationRequestDTO)

        {

            var errormessage = await _authService.Register(registrationRequestDTO);

            if (!string.IsNullOrEmpty(errormessage))

            {

                _response.IsSuccess = false;

                _response.Message = errormessage;

                return BadRequest(_response);

            }

            return Ok(_response);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }
    }

}
