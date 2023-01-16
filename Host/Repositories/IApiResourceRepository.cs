using IdentityServer4.Models;

namespace IdentityServer4.Host.Repositories
{
    public interface IApiResourceRepository
    {
        Task<IEnumerable<ApiResource>> GetAll();
    }
}
