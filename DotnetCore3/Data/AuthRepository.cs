using System.Threading.Tasks;
using DotnetCore3.Models;

namespace DotnetCore3.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;

        }
        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ServiceResponse<int>> Register(User user, string pawssword)
        {
            await _context.users.AddAsync(user);
            await _context.SaveChangesAsync();
            ServiceResponse<int> response = new ServiceResponse<int>();
            response.Data = user.Id;
            return response;
         }

        public Task<bool> userExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}