using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_Covid_App.Entities;

namespace My_Covid_App.Models
{
    public class CovidDBContext : IdentityDbContext<User>
    {
        public CovidDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Patients> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Patients>()
                .HasOne(p => p.User)
                .WithMany(u => u.Patients)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
