using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_Covid_App.Models;

namespace My_Covid_App.Models
{
    public class CovidDBContext : IdentityDbContext<User>
    {
        public CovidDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
