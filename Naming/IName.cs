using MakeWell.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.Naming
{
    public interface IName : IEntity
    {
        string Text { get; set; }
        string Kind { get; set; }
        string GetString();
    }
}
