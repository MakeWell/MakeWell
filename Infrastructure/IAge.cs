using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.People
{
    public interface IAge
    {
        DateTime DateOfEvent { get; set; }
        int Years { get; set; }
        int Months { get; set; }
        int Days { get; set; }
        int Hours { get; set; }
        int Minutes { get; set; }
        int Seconds { get; set; }
        string GetAgeString();
    }
}
