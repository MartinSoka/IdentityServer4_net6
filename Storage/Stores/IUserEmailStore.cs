using System.Threading.Tasks;

namespace IdentityServer4.Stores
{
    public interface IUserEmailStore
    {
        Task<bool> UserEmailIsConfirmedAsync(string subjectId);
    }
}
