using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.Globalization
{
    public interface IIsrCitizen : IPerson
    {
        string IsrId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
