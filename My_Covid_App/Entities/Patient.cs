using My_Covid_App.Models;
using System.ComponentModel.DataAnnotations;

namespace My_Covid_App.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public long Identification { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string NextOfKeen { get; set; }
        [Required]
        public int NextOfKeenPhoneNumber { get; set; }
        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
