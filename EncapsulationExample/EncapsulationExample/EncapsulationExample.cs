using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class EncapsulationExample
    {
        // Private fields
        private string name;
        internal int age;

        // Public property for Name
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Invalid name.");
            }
        }
    }
}
