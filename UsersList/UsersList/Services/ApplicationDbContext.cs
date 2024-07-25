using Microsoft.EntityFrameworkCore;
using UsersList.Models;

namespace UsersList.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        
        public DbSet<User> Users { get; set; }
    }
}
