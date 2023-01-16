using IdentityServer4.Storage;
using IdentityServer4.Stores;

namespace IdentityServer4.Host.Stores
{
    public class SavedConsentStore : ISavedConsentStore
    {
        public async Task<UserSavedConsent> GetFromFilters(string userID, string clientID, IEnumerable<string> requiredScopes)
        {
            return default;
        }

        public Task<IEnumerable<UserSavedConsent>> GetFromFilters(string userID, string clientID)
        {
            return default;
        }

        public async Task DeleteFromFilters(string userID, string clientID)
        {
        }

        public async Task Store(UserSavedConsent userSavedConsent)
        {
        }
    }
}
