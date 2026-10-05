using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.PI
{
    class Calculations
    {
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

        public static int Sum(int a, int b){
            return a + b;
        }
        //public static int Sum(int a, int b, int s){
        //    return a + b;
        //}

        public static int Sub(int a, int b, int c)
        {
            return a - b;
        }

        public static int Sub(int a, int b){
            return a - b;
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

        public static int Mul(int a, int b){
            return a * b;
        }
    }
}
