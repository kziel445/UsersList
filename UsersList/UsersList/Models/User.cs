using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System.ComponentModel.DataAnnotations;

namespace UsersList.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CategoryId { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
