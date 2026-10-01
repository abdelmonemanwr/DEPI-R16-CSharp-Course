using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Operations
    {
        // call by value
        public void Swap(int a, int b)
        {
            Console.WriteLine($"Before: A = {a}, B = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After: A = {a}, B = {b}");
        }

        // call by reference
        //public void Swap(ref int a, ref int b)
        //{
        //    Console.WriteLine($"Before: A = {a}, B = {b}");
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($"After: A = {a}, B = {b}");
        //}
        //public void Swap(ref char a, ref char b)
        //{
        //    Console.WriteLine($"Before: A = {a}, B = {b}");
        //    char temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($"After: A = {a}, B = {b}");
        //}
        //public void Swap(ref decimal a, ref decimal b)
        //{
        //    Console.WriteLine($"Before: A = {a}, B = {b}");
        //    decimal temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($"After: A = {a}, B = {b}");
        //}
    }

    class GenericOperations
    {
        // Generic call by reference method
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        
        public static void Print<T1, T2>(T1 a, T2 b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
