using System.ComponentModel.DataAnnotations;

namespace HealthDoc.Models
{
    public class MedicalReport
    {
        public int Id { get; set; }

        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
    }
}
