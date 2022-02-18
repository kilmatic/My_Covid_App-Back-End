using System.ComponentModel.DataAnnotations;

namespace My_Covid_App.Models.PatientsModel
{
    public class PatientCreateRequestModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Identification { get; set; }
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
    }
}
