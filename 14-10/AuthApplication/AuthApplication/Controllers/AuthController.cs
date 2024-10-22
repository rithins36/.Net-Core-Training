using AuthApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly Jwtsettings _jwtsettings;

        public AuthController(Jwtsettings jwtsettings)

        {

            _jwtsettings = jwtsettings;

        }

        [HttpPost("token")]

        public IActionResult GenerateToken()

        {

            var claims = new[]

            {

        new Claim(JwtRegisteredClaimNames.Sub, "testuser"),

        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

      };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtsettings.SecretKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(

              issuer: _jwtsettings.Issuer,

              audience: _jwtsettings.Audience,

              claims: claims,

              expires: DateTime.Now.AddMinutes(_jwtsettings.ExpiryMinutes),

              signingCredentials: creds

              );

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));

        }

    }
}
