using System.Threading.Tasks;
using DotnetCore3.Models;

namespace DotnetCore3.Data
{
    public class AuthRepository : IAuthRepository
    {
        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<int>> Register(User user, string pawssword)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> userExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}