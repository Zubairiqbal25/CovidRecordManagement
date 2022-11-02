
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Covid.Entities.Entities;

namespace Covid.Entities.Patient
{
    public class Patient
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string EmirateId { get; set; }
        public Hospitals HospitalName {get;set;}
        public DateTime vaccinationDate { get; set; }
        public Vaccine vaccine { get; set; }
        public DoseStatus Status { get; set; }
    }
}
