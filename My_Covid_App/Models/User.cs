using Microsoft.AspNetCore.Identity;
using My_Covid_App.Entities;

namespace My_Covid_App.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Patient> Patients { get; } = new HashSet<Patient>();

        public IEnumerable<Receptionist> Receptionists { get; } = new HashSet<Receptionist>();  

        public IEnumerable<Pharmacist> Pharmacists { get; } = new HashSet<Pharmacist>();

        public IEnumerable<Nurse> Nurses { get; } = new HashSet<Nurse>();

        public IEnumerable<Doctor> Doctors { get; } = new HashSet<Doctor>();

    }
}
