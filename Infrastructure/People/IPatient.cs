using MakeWell.Entities;

namespace MakeWell.Infrastructure
{
    public interface IPatient : IIsrCitizen
    {
        HealthInsuranceProvider HealthInsuranceProvider { get; set; }
    }
}
