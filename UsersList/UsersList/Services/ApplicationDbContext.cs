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
                new User {
                    Id = 1, 
                    Name = "Andrzej",
                    LastName = "Kowal",
                    Email = "Siemanko@xd.pl",
                    Password = "password",
                    CategoryId = 1,
                    Phone = "123456789",
                    BirthDate = new DateTime(2000, 12, 12)
                },
                new User
                {
                    Id = 2,
                    Name = "Janusz",
                    LastName = "Kowal",
                    Email = "Siemal",
                    Password = "password",
                    CategoryId = 2,
                    Phone = "123456789",
                    BirthDate = new DateTime(1998, 12, 12)
                }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Private" },
                new Category { Id = 2, Name = "Business" },
                new Category { Id = 3, Name = "Other", PossibleToAddSub = true }
                );

            modelBuilder.Entity<SubCategories>().HasData(
                new SubCategories { Id = 1, Name = "Boss", CategoryId = 2 },
                new SubCategories { Id = 2, Name = "Client", CategoryId = 2 },
                new SubCategories { Id = 3, Name = "Random", CategoryId = 3 }
                );
        }
    }
}
