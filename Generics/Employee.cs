using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee() { }
        public Employee(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }

    }
}
