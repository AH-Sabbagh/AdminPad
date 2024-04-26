using AdminPad.Shared.Dtos;
using AdminPad.Shared.Models;

namespace AdminPad.Client.Services.AuthService;
public interface IAuthService
{
    Task<ServiceResponse<string>> Login(LoginDto loginDto);
    Task<ServiceResponse<string>> Register(RegisterDto registerDto);
    Task<bool> IsUserAuthenticated();
    Task Logout();
}
