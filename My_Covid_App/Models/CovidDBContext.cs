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

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }

        public DbSet<Pharmacist> Pharmacists { get; set;}

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Nurse> Nurses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Patient>()
                .HasOne(p => p.User)
                .WithMany(u => u.Patients)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Receptionist>()
                .HasOne(r => r.User)
                .WithMany(u => u.Receptionists)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Pharmacist>()
                .HasOne(p => p.User)
                .WithMany(u => u.Pharmacists)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Doctor>()
                .HasOne(d => d.User)
                .WithMany(u => u.Doctors)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Nurse>()
                .HasOne(n => n.User)
                .WithMany(u => u.Nurses)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
