using OOP.PIII.CONSIST_OF;
using OOP.PIII.HAS_A;
using OOP.PIII.USES_A;
using System.Net.Mail;

namespace OOP.PIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region static
            //Console.WriteLine("1) Count = " + Student.Count);
            //Student s1 = new Student(10, "Malak", 19);
            //Console.WriteLine("2) Count = " + Student.Count);
            //Student s2 = new Student(20, "Ahmed", 20);
            //Console.WriteLine("3) Count = " + Student.Count);

            ////s1.Count = 12;
            ////s2.Count = 4;

            ////Student.Count = 15;
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);



            //Student s = new Student();
            //int sum = s.Sum(23, 12);
            //Console.WriteLine(sum);

            //int sum = Student.Sum(23, 12);
            //Console.WriteLine(sum);

            //var pi = Math.PI;
            //Console.WriteLine(Helper.Sum(23, 12));
            //string name = "men3m";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.Substring(2));
            //Console.WriteLine(name.CountWords());

            //string sentence = "hello everybody, this is men3m greeting you :)";
            //Console.WriteLine(Helper.CountWords(sentence));
            //Console.WriteLine(sentence.CountWords());

            #endregion

            #region Operator Overloading
            //int x = 12;
            //int y = 4;
            //int z = x + y;
            //x++;
            //x += 5;
            //x = x + 5;

            //Complex c1 = new(2, -9);
            //Complex c2 = new(-5, 7);
            //Complex c3 = c1 + c2;
            //Complex c4 = c1 - c2;

            //Complex c5 = c1 + 4;
            //c1 += 3; // c1 = c1 + 3; // binary (complex, int)

            //Complex c6 = c1 - 4;

            //c1++;

            //c1--;
            //Console.WriteLine(c1);

            //bool isEqual = c1 == c2;
            //Console.WriteLine(isEqual);

            //isEqual = c1 != c2;
            //Console.WriteLine(isEqual);

            #endregion

            #region USES_A

            // Student Uses Laptop to submit assignment
            // Employee Uses Printer to print some papers

            //Employee employee = new();
            //employee.PrintPaper(new Printer(), "hello R16 students");

            //var printer = new Printer();
            //employee.PrintPaper(printer, "hello R16 students");

            //OrderService orderService = new OrderService();
            //orderService.CreateOrder(new EmailService());

            #endregion

            #region HAS_A
            //CollegeStudent s1 = new CollegeStudent(1, "ahmed", new Course("DB", 12367, 20));
            //Console.WriteLine(s1);


            //Course[] courses =
            //{
            //   new Course("DB", 12367, 20),
            //   new Course("C#", 12334, 26),
            //   new Course("EF", 12337, 15),
            //};
            //CollegeStudent s2 = new CollegeStudent(1, "ahmed", courses);
            //Console.WriteLine(s2);

            #endregion

            #region Consist_OF
            //// Old Way
            //Processor p = new Processor();
            //Laptop laptop1 = new Laptop();
            //Laptop laptop2 = new Laptop();

            // New Way
            Processor processor = new Processor(core:6, gen:8, x:123);
            Laptop laptop1 = new Laptop(processor);
            Laptop laptop2 = new Laptop(processor);
            #endregion

            #region IS_A

            #endregion
        }
    }
}
