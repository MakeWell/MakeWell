using MakeWell.Infrastructure;
using System.Collections.Generic;

namespace MakeWell.Entities
{
    public class HealthInsuranceProvider
        : IHealthInsuranceProvider
    {
        public int Id { get; set; }
        public string EntityId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string DisplayText { get; set; }
        public Signature Signature { get; set; }
        public IEnumerable<Patient> Patients { get; set; }

        public override string ToString()
        {
            return Name;

        }
    }
}
