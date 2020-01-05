using MakeWell.Infrastructure;
using System.Collections.Generic;
using MakeWell.Entities;

namespace MakeWell.Infrastructure
{
    public interface IHealthInsuranceProvider : IEntity
    {
        IEnumerable<Patient> Patients { get; set; }
    }
}