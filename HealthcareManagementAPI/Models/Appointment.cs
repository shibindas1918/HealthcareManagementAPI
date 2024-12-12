namespace HealthcareManagementAPI.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } = string.Empty;

        // Navigation Properties
        public Patient? Patient { get; set; }
        public Doctor? Doctor { get; set; }
    }

}
