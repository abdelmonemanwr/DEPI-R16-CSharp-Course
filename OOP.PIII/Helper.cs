using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIII
{
    public static class Helper
    {
        //public int Property { get; set; }
        public static int Count { get; set; }
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        // Extension Method
        // static class 
        // static method
        // this + caller 

        public static int CountWords(this string sentence)
        {
            return sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int CountWords(this string sentence, int x, int y)
        {
            return sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
