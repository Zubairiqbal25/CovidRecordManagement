using Covid.Entities.Patient;
using Covid.Entities.Entities;

namespace Covid.DAL.Repositories
{
    public class PatientData : IPatientData
    {
        #region Crud Operation on Patient Data
            // Get All vaccinated Patient List 
            public List<Patient> getPatient()
            {
                return PatientList.ToList();
            }
            // Get vaccinated Patient by Id
            public Patient getPatient(int id)
            {
                return PatientList.FirstOrDefault(x => x.id == id) ?? new Patient();
            }
            public List<Patient> AddPatient(Patient data)
            {
                PatientList.Add(data);
                return PatientList.ToList();
            }

            public Patient UpdatePatient(int id,Patient data)
            {
                var PatientData = PatientList.FirstOrDefault(x => x.id == id);
                if (PatientData != null)
                {
                    PatientData = data;
                }
                return PatientData ?? new Patient();
            }
            public string DeletePatient(int id)
            {
                if (id != 0)
                {
                    PatientList.Remove(PatientList.FirstOrDefault(x => x.id == id));
                    return "Successfull";
                }
                else
                {
                    return "Not Data found";
                }
            
            }
        #endregion
        //User Data is Put in List because in there is requirment for database
        //Patient List Data
        List<Patient> PatientList = new List<Patient> {
            new Patient
            {
                id = 1,
                firstName= "Muhammad",
                lastName= "Zubair",
                dateOfBirth = new DateTime(1997, 07, 20, 10, 45, 30),
                HospitalName= Hospitals.Dubai_Hospital,
                vaccinationDate = new DateTime(2021, 09, 21),
                vaccine = Vaccine.Sinopharm,
                Status = DoseStatus.Complete
            },
            new Patient
            {
                id = 2,
                firstName= "Muhammad",
                lastName= "Umair",
                dateOfBirth = new DateTime(1996, 07, 05, 10, 45, 30),
                HospitalName= Hospitals.NMC_Hospital,
                vaccinationDate = new DateTime(2021, 09, 21),
                vaccine = Vaccine.Sinopharm,
                Status = DoseStatus.Complete
            },
            new Patient
            {
                id = 3,
                firstName= "Adeel",
                lastName= "Ali",
                dateOfBirth = new DateTime(1997, 07, 24, 10, 45, 30),
                HospitalName= Hospitals.First_Medical_Center,
                vaccinationDate = new DateTime(2021, 09, 21),
                vaccine = Vaccine.Sinopharm,
                Status = DoseStatus.Complete
            }
        };
    }
}
