using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIII
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        //static int temp;  // static field

        public static int Count { get; private set; } //= 10;   // automatic static property

        //public static Student() { }
        //static Student(int Count) { }
        //public static Student(int Count) { }

        static Student()
        {
            Count = 20; 
        }

        public Student()
        {
            //Count = 10;
            Count++;
        }

        public Student(int Id, string Name, int Age)
        {
            //Count = 10;
            Count++;
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        // static method
        public static int Sum(int n1, int n2)
        {
            //Console.WriteLine(Name);
            return n1 + n2 + Count;
        }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Age={Age}, Count={Count}";
        }
    }
}
