using My_Covid_App.Models;
using System.ComponentModel.DataAnnotations;

namespace My_Covid_App.Entities
{
    public class Receptionist
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Identification { get; set; }
        [Required]
        public int EmployeeNumber { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
