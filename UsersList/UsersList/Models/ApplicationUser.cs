using Microsoft.AspNetCore.Identity;

namespace UsersList.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
