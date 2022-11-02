using Covid.Entities.Patient;

namespace Covid.Services.Patients
{
    public interface IPatientService
    {
        List<Patient> AddPatient(Patient data);
        string DeletePatient(int id);
        List<Patient> getPatients();
        Patient getPatients(int id);
        Patient UpdatePatient(int id, Patient data);
    }
}