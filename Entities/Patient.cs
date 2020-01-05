using MakeWell.Infrastructure;
using System;

namespace MakeWell.Entities
{
    public class Patient : IPatient
    {
        public HealthInsuranceProvider HealthInsuranceProvider { get; set; }
        public string Isr9DigitsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentityNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public PrivateDetail[] PrivateDetails { get; set; }
        public string Gender { get; set; }
        public string EntityId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string DisplayText { get; set; }
        public Signature Signature { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}, {HealthInsuranceProvider.Name}";
        }
    }
}