using System.Net.Http.Json;
using AdminPad.Shared.Dtos;
using AdminPad.Shared.Models;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace AdminPad.Client.Services.AuthService
{
    public class AuthService:IAuthService
    {
        private readonly HttpClient _http;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authStateProvider;
        public Task<ServiceResponse<string>> Login(LoginDto loginDto)
        {
            var response = await _http.PostAsJsonAsync("api/auth/login", loginDto);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<string>>();
            if (result.Success)
            {
                await _localStorage.SetItemAsync("authtoken", result.Data);
                ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAs
            }
        }

        public Task<ServiceResponse<string>> Register(RegisterDto registerDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserAuthenticated()
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }
    }
}
