using AdminPad.Shared.Dtos;
using AdminPad.Shared.Models;
using System.Security.Claims;
using System.Text;

namespace AdminPad.Server.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public Task<ServiceResponse<int>> CreateUserAccount(UserAccountDto user)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<int>> DeleteUserAccount(string userId)
        {
            throw new NotImplementedException();
        }

        public string GetUserId()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<int>> UpdateUserAccount(UserAccountDto user)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<string>> UserLogin(LoginDto user)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<int>> UserRegister(RegisterDto user)
        {
            throw new NotImplementedException();
        }
    }
}
