using Microsoft.AspNetCore.Identity;
using My_Covid_App.Entities;

namespace My_Covid_App.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Patients> Patients { get; } = new HashSet<Patients>();

    }
}
