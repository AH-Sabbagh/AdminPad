using Microsoft.AspNetCore.Components;

namespace AdminPad.Client.Pages.Admin
{
    public partial class AccountManager
    {
        [Inject] private IUserAccountManager _userAccountManager;
    }
}
