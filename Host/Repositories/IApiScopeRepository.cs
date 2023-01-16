using IdentityServer4.Models;

namespace IdentityServer4.Host.Repositories
{
    public interface IApiScopeRepository
    {
        Task<IEnumerable<ApiScope>> GetAll();
    }
}
