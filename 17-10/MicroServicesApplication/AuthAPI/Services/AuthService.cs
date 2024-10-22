using AuthAPI.Models;
using AuthAPI.Models.Dto;
using AuthAPI.Services.IService;
using CouponAPI.Data;
using Microsoft.AspNetCore.Identity;

namespace AuthAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthService(AppDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<string> Register(RegistrationRequestDto registrationRequestDto)
        {
            ApplicationUser user = new()
            {
                UserName = registrationRequestDto.Email,
                Email = registrationRequestDto.Email,
                NormalizedEmail = registrationRequestDto.Email.ToUpper(),
                Name = registrationRequestDto.Name,
                PhoneNumber = registrationRequestDto.PhoneNumber
            };
            try
            {
                var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);
                if (result.Succeeded)
                {
                    var userToReturn = _db.ApplicationUsers.First(u => u.UserName == registrationRequestDto.Email);
                    UserDto userDto = new()

                    {

                        Email = userToReturn.Email,

                        ID = userToReturn.Id,

                        Name = userToReturn.Name,

                        PhoneNumber = userToReturn.PhoneNumber

                    };

                    return "";
                }
                else

                {

                    return result.Errors.FirstOrDefault().Description;

                }

            }
            catch (Exception ex)

            {

            }

            return "Error Encountered";
        }
        public Task<LoginRequestDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
