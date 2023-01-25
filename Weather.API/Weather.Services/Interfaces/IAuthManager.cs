using Microsoft.AspNetCore.Identity;
using Weather.API.Weather.Models.DTOS;

namespace Weather.API.Weather.Services.Interfaces
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> RegisterUser(RegisterUserDto registerUser);
        Task<AuthResponseDto> Login(LoginDto login);
    }
}
