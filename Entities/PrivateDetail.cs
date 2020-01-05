using MakeWell.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.Entities
{
    public class PrivateDetail
        : Entity
        , IPrivateDetail
    {
        public string Value { get; set; }
        public string Kind { get; set; }

        public override string ToString()
        {
            return $"{Kind}: {Value}";
        }
    }
}
