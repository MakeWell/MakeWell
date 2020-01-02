using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.Clinics
{
    public interface IPatient : IPerson
    {
        IHealthInsuranceProvider HealthInsuranceProvider { get; set; }
    }
}
