using MakeWell.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell
{
    public interface IPerson : IEntity
    {
        string Name { get; set; }
        GenderEnum? Gender { get; set; }
        DateTime DateOfBirth { get; set; }
    }
}
