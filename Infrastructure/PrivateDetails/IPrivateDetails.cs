using MakeWell.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace MakeWell.People
{
    public interface IPrivateDetails : IEntity
    {
        [Required]
        string FirstMidName { get; set; }
        [Required]
        string LastName { get; set; }
        string Gender { get; set; }
        DateTime DateOfBirth { get; set; }
    }
}
