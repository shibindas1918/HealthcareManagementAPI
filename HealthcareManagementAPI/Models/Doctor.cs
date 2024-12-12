namespace HealthcareManagementAPI.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public string Availability { get; set; } = string.Empty;
    }

}
