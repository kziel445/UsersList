using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UsersList.ViewModels;
using UsersList.Services;
using System.Threading.Tasks;
using UsersList.ViewModels;

namespace UsersList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<UserViewModel> Users { get; set; }
        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                var users = await _context.Users
                    .Include(u => u.Category)
                    .ToListAsync();


                Users = users.Select(user => new UserViewModel
                {
                    Id = user.Id,
                    Name = user.Name,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    BirthDate = user.BirthDate.ToShortDateString(),
                    Phone = user.Phone,
                    Category = user.Category.Name
                }).ToList();
            }
            
        }
    }
}