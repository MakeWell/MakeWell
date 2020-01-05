using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MakeWell.Infrastructure
{
    public interface IVersionable
    {
        [Timestamp]
        int Version { get; set; }
    }
}
