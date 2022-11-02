using FluentValidation;

namespace Covid.Entities.Patient
{
    public class PatientValidation : AbstractValidator<Patient>
    {
        public PatientValidation()
        {
            RuleFor(x => x.firstName).NotEmpty().NotNull();
            RuleFor(x => x.lastName).NotEmpty().NotNull();
            RuleFor(x => x.firstName).NotEmpty().NotNull();
            RuleFor(x => x.dateOfBirth).NotEmpty();
            RuleFor(x => x.dateOfBirth).NotEmpty();
            RuleFor(x => x.vaccinationDate).NotEmpty();
            RuleFor(x => x.HospitalName).NotEmpty().NotNull();
            RuleFor(x => x.Status).NotEmpty().NotNull();
        }
    }
}
