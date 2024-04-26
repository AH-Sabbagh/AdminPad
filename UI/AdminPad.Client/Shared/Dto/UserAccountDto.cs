namespace AdminPad.Client.Shared.Dto;
public class UserAccountDto
{
    public string UserId { get; set; } = string.Empty;
    public string UserName { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public string Notes { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string UserRole { get; set; }
    public bool IsSuperUser { get; set; }

}
