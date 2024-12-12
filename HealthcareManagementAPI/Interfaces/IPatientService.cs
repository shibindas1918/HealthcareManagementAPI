using HealthcareManagementAPI.Models;

namespace HealthcareManagementAPI.Interfaces
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllPatients();
        Task<Patient> GetPatientById(int id);
        Task AddPatient(Patient patient);
        Task UpdatePatient(Patient patient);
        Task DeletePatient(int id);
    }

}
