using MakeWell.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell
{
    public interface IPerson : IEntity
    {
        PrivateDetails PrivateDetails { get; set; }
    }
}
