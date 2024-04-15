using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerRegistration.Model
{
    public class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
