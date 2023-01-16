using IdentityServer4.Models;
using IdentityServer4.Stores;

namespace IdentityServer4.Host.Repositories
{
    public interface IPersistentGrantRepository
    {
        Task Insert(PersistedGrant persistedGrant);
        Task<PersistedGrant> GetByKey(string key);
        Task<IEnumerable<PersistedGrant>> GetByFilters(PersistedGrantFilter filter);
        Task DeleteByKey(string key);
        Task DeleteByFilters(PersistedGrantFilter filter);
    }
}
