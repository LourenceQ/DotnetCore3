using DotnetCore3.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> users { get; set; }
    }
}