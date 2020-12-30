using System.Threading.Tasks;
using Udemy_NetCore.Models;

namespace Udemy_NetCore.Data
{
    public interface IAuthRepository
    {
         Task<ServiceResponse<int>> Register(User user, string password);
         Task<ServiceResponse<string>> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}