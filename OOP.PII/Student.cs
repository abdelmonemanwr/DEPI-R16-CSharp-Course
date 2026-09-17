using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PII
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // parameterless
        // DRY: Don't Repeat Yourself
        // sum(3,5);
        public Student() : this("Unknown", 10)
        {
            Console.WriteLine("parameterless ctor");
            //Name = "Unknown";
            //Age = 10;
        }

        public Student(string Name) : this(Name, 10)
        {
            
        }

        public Student(int Age) : this("Unknown", Age)
        {
            
        }

        // parameterized
        //public Student(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //}
        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        //public int sum(int x, int y)
        //{
        //    return x + y;
        //}

        //public int sum(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        public string GetString()
        {
            //return ToString();
            return this.ToString();
        }

        // Polymorphism > (Overloading, Overridding, [Method Hidden])


        // represent class : student in a string format
        public override string ToString()
        {
            //return base.ToString();
            return $"Name = {Name}, Age = {Age}\n";
        }

        // method hidden
        //public string ToString()
        //{
        //    //return base.ToString();
        //    return $"Name = {Name}, Age = {Age}\n";
        //}

        // method hidden
        //public new string ToString()
        //{
        //    //return base.ToString();
        //    return $"Name = {Name}, Age = {Age}\n";
        //}

        public override bool Equals(object? obj)
        {
            //// option1:
            //if(obj is Student)
            //{
            //    Student s = (Student)obj;
            //}

            //// option2:
            //if (obj is Student s)
            //{

            //}

            //// option3:
            //Student? s = obj as Student;
            //if (s is null) return false;


            if (obj is Student s)
            {
                //return s.Name == Name;
                //return s.Name == this.Name;


                return s.Name == Name && s.Age == Age;
            }

            return false;
        }

        public override int GetHashCode()
        {
            //return Name.GetHashCode();  // 
            return HashCode.Combine(Name, Age);
            //return HashCode.Combine(this.Name, this.Age);
        }


        // finializer vs Dispose
        // GC decides when to run
        ~Student()
        {
            // block of code
        }
    }
}
