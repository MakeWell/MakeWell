using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.Clinics
{
    public class HealthInsuranceProvider : IHealthInsuranceProvider
    {
        public int Id { get; set; }
        public byte[] Timestamp { get; set; }
        public string Datastamp { get; set; }
        public string Name { get; set; }
    }
}
