using System.Threading.Tasks;
using DotnetCore3.Models;

namespace DotnetCore3.Data
{
    public interface IAuthRepository
    {
         Task<ServiceResponse<int>> Register(User user, string password);
         Task<ServiceResponse<string>> Login(string username, string password);
         Task<bool> userExists(string username);
         
    }
}