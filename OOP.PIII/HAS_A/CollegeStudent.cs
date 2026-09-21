using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIII.HAS_A
{
    internal class CollegeStudent
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Course[] Courses { get; set; }

        public CollegeStudent(int id, string name, Course[] courses)
        {
            Id = id;
            Name = name;
            Courses = courses;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{Id}-{Name}-Courses:\n");

            for(int i=0; i < Courses.Length; i++)
            {
                sb.AppendLine( Courses[i].ToString() );
            }

            return sb.ToString();
        }
    }
}
