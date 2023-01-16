using IdentityServer4.Models;

namespace IdentityServer4.Host.Repositories
{
    public interface IIdentityResourceRepository
    {
        Task<IEnumerable<IdentityResource>> GetAll();
        Task<IEnumerable<IdentityResource>> GetByScopeNames(IEnumerable<string> scopeNames);
    }
}
