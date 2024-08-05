using Microsoft.EntityFrameworkCore;

namespace UsersList.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool PossibleToAddSub { get; set; } = false;

        // Navigation
        public ICollection<User> Users { get; set; }
    }
}
