using IdentityServer4.Stores;

namespace IdentityServer4.Host.Stores
{
    public class UserEmailStore : IUserEmailStore
    {
        public async Task<bool> UserEmailIsConfirmedAsync(string subjectId)
        {
            return true;
        }
    }
}
