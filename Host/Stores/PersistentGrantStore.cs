using IdentityServer4.Host.Repositories;
using IdentityServer4.Models;
using IdentityServer4.Stores;

namespace IdentityServer4.Host.Stores
{
    public class PersistentGrantStore : IPersistedGrantStore
    {
        private readonly IPersistentGrantRepository _persistentGrantStoreRepository;

        public PersistentGrantStore(IPersistentGrantRepository persistentGrantStoreRepository)
        {
            _persistentGrantStoreRepository = persistentGrantStoreRepository;
        }

        public Task StoreAsync(PersistedGrant grant)
        {
            return _persistentGrantStoreRepository.Insert(grant);
        }

        public Task<PersistedGrant> GetAsync(string key, string type = null)
        {
            return _persistentGrantStoreRepository.GetByKey(key);
        }

        public Task<IEnumerable<PersistedGrant>> GetAllAsync(PersistedGrantFilter filter)
        {
            return _persistentGrantStoreRepository.GetByFilters(filter);
        }

        public Task RemoveAsync(string key)
        {
            return _persistentGrantStoreRepository.DeleteByKey(key);
        }

        public Task RemoveAllAsync(PersistedGrantFilter filter)
        {
            return _persistentGrantStoreRepository.DeleteByFilters(filter);
        }
    }
}
