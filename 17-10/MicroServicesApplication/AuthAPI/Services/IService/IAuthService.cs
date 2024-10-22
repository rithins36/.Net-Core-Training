using AuthAPI.Models.Dto;

namespace AuthAPI.Services.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginRequestDto> Login(LoginRequestDto loginRequestDto);
    }
}
