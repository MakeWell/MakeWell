using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakeWell.People
{
    public interface IAge
    {
        [DataType(DataType.Date)] 
        DateTime DateOfEvent { get; set; }
        
        [Column("TodaysPrice")]
        [Range(10.30, 46.60)] int Years { get; set; }
        int Months { get; set; }
        int Days { get; set; }
        int Hours { get; set; }
        int Minutes { get; set; }
        int Seconds { get; set; }
        string GetAgeString();
    }
}
