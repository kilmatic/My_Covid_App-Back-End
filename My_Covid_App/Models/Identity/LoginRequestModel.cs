using System.ComponentModel.DataAnnotations;

namespace My_Covid_App.Models.Identity
{
    public class LoginRequestModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
