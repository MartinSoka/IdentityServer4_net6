using IdentityServer4.Models;

namespace IdentityServer4.Host.Repositories
{
    public interface IClientRepository
    {
        Task<Client> GetByID(string id);
        Task Update(Client client);
        Task Insert(Client client);
    }
}
