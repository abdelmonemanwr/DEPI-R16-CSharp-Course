using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIII.HAS_A
{
    internal class Course
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Duration { get; set; }

        public Course()
        {
            
        }

        public Course(string name, int number, int duration)
        {
            Name = name;
            Number = number;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{Number}-{Name}-{Duration}Hours";
        }
    }
}
