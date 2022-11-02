using Covid.DAL.Repositories;
using Covid.Entities.Patient;

namespace Covid.Services.Patients
{
    public class PatientService : IPatientService
    {
        private readonly IPatientData _patientData;
        public PatientService(IPatientData patientData)
        {
            _patientData = patientData;
        }
        public List<Patient> getPatients()
        {
            return _patientData.getPatient().ToList();
        }
        public Patient getPatients(int id)
        {
            return _patientData.getPatient(id);
        }
        public List<Patient> AddPatient(Patient data)
        {
            return _patientData.AddPatient(data);
        }
        public Patient UpdatePatient(int id, Patient data)
        {
            return _patientData.UpdatePatient(id, data);
        }
        public string DeletePatient(int id)
        {
            return _patientData.DeletePatient(id);
        }

    }
}
