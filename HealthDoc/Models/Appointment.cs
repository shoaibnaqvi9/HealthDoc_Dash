using System.ComponentModel.DataAnnotations;

namespace HealthDoc.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public DateTime AppointmentDate { get; set; }

        [Required]
        public string Status { get; set; } // Scheduled, Completed, Cancelled

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public MedicalReport MedicalReport { get; set; }
    }
}
