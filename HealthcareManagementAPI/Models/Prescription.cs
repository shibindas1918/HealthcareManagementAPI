namespace HealthcareManagementAPI.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public int AppointmentId { get; set; }
        public string Medicine { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;

        // Navigation Property
        public Appointment? Appointment { get; set; }
    }

}
