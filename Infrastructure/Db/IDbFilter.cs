using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.Infrastructure
{
    public interface IDbFilter
    {
        bool IsDeleted { get; set; }
        string GlobalContext { get; set; }
        string Tags { get; set; }
    }
}
