namespace HealthcareManagementAPI.Models
{
    public class Billing
    {
        public int BillId { get; set; }
        public int AppointmentId { get; set; }
        public decimal Amount { get; set; }
        public string PaidStatus { get; set; } = string.Empty;

        // Navigation Property
        public Appointment? Appointment { get; set; }
    }

}
