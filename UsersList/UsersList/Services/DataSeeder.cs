using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using UsersList.Models;

namespace UsersList.Services
{
    public class DataSeeder
    {
        public static async Task SeedData(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            await SeedAdmin(userManager);
        } 
        private static async Task SeedAdmin(UserManager<ApplicationUser> userManager)
        {
            var adminUser = await userManager.FindByEmailAsync("admin@admin.com"); 
            if(adminUser== null)
            {
                adminUser = new ApplicationUser
                {
                    Id = "admin-user-id",
                    FirstName = "Johny",
                    CreateAt = DateTime.UtcNow,
                    UserName = "admin@admin.com",
                    NormalizedUserName = "admin@admin.com",
                    Email = "admin@admin.com",
                    NormalizedEmail = "admin@admin.com",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString()
                };
            }
            var password = "Admin!2345";

            
            await userManager.CreateAsync(adminUser, password);

        }
    }
}
