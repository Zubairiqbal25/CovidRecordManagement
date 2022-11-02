using Covid.Entities.Patient;

namespace Covid.DAL.Repositories
{
    public interface IPatientData
    {
        List<Patient> AddPatient(Patient data);
        string DeletePatient(int id);
        List<Patient> getPatient();
        Patient getPatient(int id);
        Patient UpdatePatient(int id, Patient data);
    }
}