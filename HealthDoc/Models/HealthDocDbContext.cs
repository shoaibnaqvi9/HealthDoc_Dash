using HealthDoc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace HealthDoc.Data
{
    public class HealthDocDbContext : DbContext
    {
        public HealthDocDbContext(DbContextOptions<HealthDocDbContext> options)
            : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalReport> MedicalReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.MedicalReport)
                .WithOne(r => r.Appointment)
                .HasForeignKey<MedicalReport>(r => r.AppointmentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
