using System;

namespace MakeWell.Infrastructure
{
    public interface ICitizen: IPerson
    {
        string NationalIdentityNumber { get; set; }
        DateTime? DateOfBirth { get; set; }

    }
}
