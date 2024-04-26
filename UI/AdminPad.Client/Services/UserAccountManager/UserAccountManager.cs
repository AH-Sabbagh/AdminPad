using System.Net.Http.Json;
using AdminPad.Client.Shared.Dto;
using AdminPad.Shared.Models;

namespace AdminPad.Client.Services.UserAccountManager;
public class UserAccountManager : IUserAccountManager
{
    private readonly HttpClient _http;

    public UserAccountManager(HttpClient http)
    {
        _http = http;
    }
    public event Action? OnChange;
    public List<UserAccountDto> UserList { get; set; } = new List<UserAccountDto>();
    public async Task GetUserAccounts()
    {
        var response =
            await _http.GetFromJsonAsync<ServiceResponse<List<UserAccountDto>>>("api/UserAccount/GetUserAccounts");
        if (response is not null && response.Data != null)
        {
            UserList = response.Data;
        }
    }

    public async Task<ServiceResponse<UserAccountDto>?> GetUserDetails(string userId)
    {
        return await _http.GetFromJsonAsync<ServiceResponse<UserAccountDto>>($"api/UserAccount/GetUser/{userId}");
    }

    public async Task<ServiceResponse<int>?> CreateNewUserAccount(UserAccountDto userAccount)
    {
        var response = await _http.PostAsJsonAsync("api/auth/CreateUser", userAccount);
        return await response.Content.ReadFromJsonAsync<ServiceResponse<int>>();
    }

    public async Task<ServiceResponse<int>?> UpdateUserAccount(UserAccountDto userAccount)
    {
        var response= await _http.PostAsJsonAsync("api/auth/UpdateUser", userAccount);
        return await response.Content.ReadFromJsonAsync<ServiceResponse<int>>();
    }

    public async Task<ServiceResponse<int>?> DeleteUserAccount(string userId)
    {
        var response = await _http.DeleteAsync($"api/auth/deleteUser/{userId}");
        return await response.Content.ReadFromJsonAsync<ServiceResponse<int>>();
    }
}
