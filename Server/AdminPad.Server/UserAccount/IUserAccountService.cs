namespace AdminPad.Server.UserAccount;

public interface IUserAccountService
{
    Task<ServiceResponse<List<UserAccountDto>>> GetUserAccounts();
    Task<ServiceResponse<UserAccountDto>> GetUserDetails(string userId);
}
