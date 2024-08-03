using Microsoft.EntityFrameworkCore;

namespace UsersList.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubCategories> SubCategories { get; set; }
    }
}
