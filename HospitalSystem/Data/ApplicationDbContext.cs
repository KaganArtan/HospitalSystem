using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HospitalSystem.Models;

namespace HospitalSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HospitalSystem.Models.Patient> Patient { get; set; } = default!;
        public DbSet<HospitalSystem.Models.Appointment> Appointment { get; set; } = default!;
    }
}
