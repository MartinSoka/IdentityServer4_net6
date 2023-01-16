
using IdentityServer4.Models;

namespace IdentityServer4.Host.Repositories
{
    internal class ApiScopeRepository : IApiScopeRepository
    {
        public async Task<IEnumerable<ApiScope>> GetAll()
        {
            
            return new[]
            {
                new ApiScope
                {
                    Enabled = true,
                    Name = "api",
                    DisplayName = "api_access",
                    ShowInDiscoveryDocument = true
                },
                new ApiScope
                {
                    Enabled = true,
                    Name = "api1",
                    DisplayName = "api1",
                    ShowInDiscoveryDocument = true
                },
                new ApiScope
                {
                    Enabled = true,
                    Name = "api2",
                    DisplayName = "api2",
                    ShowInDiscoveryDocument = true
                }
            };
        }
    }
}
