using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.PI
{
    class Calculations
    {
        public static int TempSum { get; set; }
        public static int TempSub { get; set; }
        public static int TempMul { get; set; }

        public bool AccessLocation(bool isOpened, MyDelegate5 grant, MyDelegate5 deny)
        {
            string city = "cairo";
            if (isOpened)
            {
                var currentLocation = grant.Invoke(city);
                Console.WriteLine(currentLocation);
                return true;
            }
            else
            {
                var currentLocation = deny.Invoke(city);
                Console.WriteLine(currentLocation);
                return false;
            }
        }

        public static string OpenLocation(string loc)
        {
            Console.WriteLine("location can be accessed");
            return loc;
        }

        public static string CloseLocation(string loc)
        {
            return "location can't be accessed\n";
        }

        public static void DoTask(int x, int y, MyDelegate myDel)
        {
            var val = myDel.Invoke(x, y);
            Console.WriteLine(val);
        }

        public static void DoTask<T>(T x, T y, Func<T, T, T> myDel)
        {
            T val = myDel.Invoke(x, y);
            Console.WriteLine(val);
        }

        public static int Sum(int a, int b){
            TempSum = a + b;
            Console.WriteLine($"sum = {TempSum}");
            return TempSum;
        }

        public static void Test(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string Sum(string a, string b){
            Console.WriteLine($"sum = {a+b}");
            return a + b;
        }

        public static decimal Sum(decimal a, decimal b){
            Console.WriteLine($"sum = {a+b}");
            return a + b;
        }


        public static T Sum<T>(T a, T b) where T : INumber<T>
        {
            Console.WriteLine($"sum = {a + b}");
            return a + b;
        }

        public static T Sub<T>(T a, T b) where T : INumber<T>
        {
            Console.WriteLine($"sub = {a - b}");
            return a - b;
        }



        //public static int Sum(int a, int b, int s){
        //    return a + b;
        //}

        public static int Sub(int a, int b, int c)
        {
            return a - b;
        }

        public static int Sub(int a, int b){
            TempSub = a - b;
            Console.WriteLine($"sub = {TempSub}");
            return TempSub;
        }

        //public static float Sub(int a, float b){
        //    return (float)(a - b);
        //}

        public static int Sub(int a, float b){
            return (int)(a - b);
        }

        public static int Sub(float a, int b){
            return (int)(a - b);
        }

        public static int Mul(int a, int b)
        {
            TempMul = a * b;
            Console.WriteLine($"mul = {TempMul}");
            return TempMul;
        }

        public static bool IsGreaterThanZero(int x)
        {
            return x > 0;
        }

        public static bool IsGreaterThanZero(double x)
        {
            return x > 0;
        }
    }
}
