using System.Threading.Tasks;
using DotnetCore3.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            CreatePassWordHash(password, out byte[] passwordhash, out byte[] passwordSalt);

            user.PasswordHash = passwordhash;
            user.PasswordSalt = passwordSalt;
            
            await _context.users.AddAsync(user);
            await _context.SaveChangesAsync();
            ServiceResponse<int> response = new ServiceResponse<int>();
            response.Data = user.Id;
            return response;
         }

        public async Task<bool> UserExists(string username)
        {
            if(await _context.users.AnyAsync(x => x.Username.ToLower() == username.ToLower()))
            {
                return true;
            }
            return false;
            
        }

        private void CreatePassWordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}