using UsersList.Models;

namespace UsersList.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string BirthDate { get; set; }

        // Foreign key 
        public int CategoryId { get; set; }
        // Navigation
        public string Category { get; set; }
    }
}
