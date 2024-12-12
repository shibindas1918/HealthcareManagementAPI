using HealthcareManagementAPI.Interfaces;
using HealthcareManagementAPI.Models;
using System.Data;
using Dapper;

namespace HealthcareManagementAPI.Services
{
    public class PatientService : IPatientService
    {
        private readonly IDbConnection _dbConnection;

        public PatientService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Patient>> GetAllPatients()
        {
            string query = "SELECT * FROM Patients";
            return await _dbConnection.QueryAsync<Patient>(query);
        }

        public async Task<Patient> GetPatientById(int id)
        {
            string query = "SELECT * FROM Patients WHERE PatientId = @Id";
            return await _dbConnection.QueryFirstOrDefaultAsync<Patient>(query, new { Id = id });
        }

        public async Task AddPatient(Patient patient)
        {
            string query = "INSERT INTO Patients (Name, Age, Gender, Contact) VALUES (@Name, @Age, @Gender, @Contact)";
            await _dbConnection.ExecuteAsync(query, patient);
        }

        public async Task UpdatePatient(Patient patient)
        {
            string query = "UPDATE Patients SET Name = @Name, Age = @Age, Gender = @Gender, Contact = @Contact WHERE PatientId = @PatientId";
            await _dbConnection.ExecuteAsync(query, patient);
        }

        public async Task DeletePatient(int id)
        {
            string query = "DELETE FROM Patients WHERE PatientId = @Id";
            await _dbConnection.ExecuteAsync(query, new { Id = id });
        }
    }

}
