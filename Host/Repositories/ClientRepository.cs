using IdentityServer4.Models;
using IdentityServer4.Storage.Models;

namespace IdentityServer4.Host.Repositories
{
    internal static class ClientsMemoryRepository
    {
        public static IList<Client> Clients = new List<Client>
        {
            new Client
            {
                Enabled = true,
                ClientId = "oidc_client",
                ProtocolType = "oidc",
                ClientSecrets = new List<Secret>
                {
                    new Secret
                    {
                        Value = "secret",
                        Type = "SharedSecret"
                    }
                },
                RequireClientSecret = false,
                RequireConsent = true,
                AllowRememberConsent = true,
                AllowedGrantTypes = new List<string>
                {
                    "authorization_code"
                },
                AllowedCorsOrigins = new List<string>
                {
                    "http://localhost:8080"
                },
                RequirePkce = true,
                RedirectUris = new List<string>
                {
                    "http://localhost:8080",
                },
                PostLogoutRedirectUris = new List<string>
                {
                    "http://localhost:8080/signout"
                },
                FrontChannelLogoutSessionRequired = true,
                BackChannelLogoutSessionRequired = true,
                AllowOfflineAccess = true,
                AllowedScopes = new List<string>
                {
                    "api"
                },
                IdentityTokenLifetime = 300,
                AccessTokenLifetime = 3000,
                AuthorizationCodeLifetime = 300,
                AbsoluteRefreshTokenLifetime = 2592000,
                AbsoluteSsoExternalIdpRefreshTokenLifetime = 2592000,
                SlidingRefreshTokenLifetime = 1296000,
                SlidingSsoExternalIdpRefreshTokenLifetime = 1296000,
                RefreshTokenUsage = TokenUsage.OneTimeOnly,
                AccessTokenType = AccessTokenType.Reference,
                EnableLocalLogin = true,
                IncludeJwtId = true,
                ClientClaimsPrefix = "client_",
                DeviceCodeLifetime = 300
            }
        };
    }

    internal class ClientRepository : IClientRepository
    {
        public async Task<Client> GetByID(string id)
        {
            return ClientsMemoryRepository.Clients.FirstOrDefault(a => a.ClientId == id);
        }

        public Task Update(Client client)
        {
            return Task.CompletedTask;
        }

        public Task Insert(Client client)
        {
            return Task.CompletedTask;
        }
    }
}
