using Microsoft.EntityFrameworkCore;
using UsersList.Models;

namespace UsersList.Services
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Andrzej"},
                new User { Id = 2, Name = "Janusz" }
                );
        }
    }
}
