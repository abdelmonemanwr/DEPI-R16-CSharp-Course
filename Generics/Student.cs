using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Student : IComparable<Student>, IComparable, IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Student(int Id, string Name) {
            this.Id = Id;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }

        public int CompareTo(object? obj)
        {
            if (obj is Student std)
            {
                return this.Id.CompareTo(std.Id);
            }
            throw new Exception("Can't sort different Types of objects");
        }

        // std1.CompareTo(std2);
        public int CompareTo(Student? other)
        {
            if (other is null)
            {
                throw new Exception("Can't sort different Types of objects");
            }

            return this.Id.CompareTo(other.Id);

            //return this.Id.CompareTo(other?.Id);

        }


        //FileStream fs = new FileStream("ab", FileAccess.Write)

        public void Dispose()
        {
            Console.WriteLine("dispose is called!");
        }

        ~Student()
        {
            Console.WriteLine("destructor is called!");
        }
    }
}
