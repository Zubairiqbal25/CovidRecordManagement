
namespace Covid.Entities.Entities
{
  
        public class Connection
        {
            public string DefaultConnection { get; set; }
        }
        public enum DoseStatus
        {
            Complete = 1,
            NoVaccice = 2,
            InComplete = 3
        };
        public enum Vaccine
        {
            Sinopharm = 1,
            Pfizer = 2
        };
        public enum Hospitals {
            First_Medical_Center = 1,
            Dubai_Hospital = 2,
            NMC_Hospital = 3
        };

}
