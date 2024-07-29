using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UsersList.Models;
using UsersList.Services;
using System.Threading.Tasks;

namespace UsersList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<User> Users { get; set; }
        public async Task OnGetAsync()
        {
            if(_context.Users != null)
            {
                Users = await _context.Users.ToListAsync();
            }
        }
    }
}