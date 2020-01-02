using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.People
{
    public abstract class Person : IPerson
    {
        public abstract PrivateDetails PrivateDetails { get; set; }
        public abstract int Id { get; set; }
        public abstract byte[] Timestamp { get; set; }
        public abstract string Datastamp { get; set; }
        public abstract string Name { get; set; }
    }
}
