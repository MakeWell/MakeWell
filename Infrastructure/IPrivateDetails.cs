using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MakeWell.People
{
    public interface IPrivateDetails
    {
        [Key]
        int ID { get; set; }
        [Required]
        string FirstMidName { get; set; }
        [Required]
        string LastName { get; set; }
        string Name { get; set; }
        GenderEnum? Gender { get; set; }
        DateTime DateOfBirth { get; set; }



    }
}
