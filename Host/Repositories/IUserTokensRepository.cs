using Microsoft.AspNetCore.Identity;

namespace IdentityServer4.Host.Repositories
{
    public interface IUserTokensRepository
    {
        Task<IdentityUserToken<string>> GetByFilters(string userID, string name, string provider);
        Task Insert(IdentityUserToken<string> token);
        Task DeleteByFilters(string userID, string name, string provider);
    }
}
