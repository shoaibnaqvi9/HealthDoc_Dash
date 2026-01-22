using System.ComponentModel.DataAnnotations;

namespace HealthDoc.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        [Phone]
        public string Phone { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
