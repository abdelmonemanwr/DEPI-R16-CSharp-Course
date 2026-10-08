using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;

namespace Delegates.PI
{
    // access-modifier delegate return-type delName (T1 p1, T2 p2)
    // access-modifier return-type funcName (T1 p1, T2 p2)
    // public int sum(int a, int b)

    // declarations
    public delegate int MyDelegate(int a, int b); 
    public delegate int MyDelegate4(string a, string b); 
    public delegate int MyDelegate2(int a, float b);
    public delegate void MyDelegate3(int a, float b, string c);
    public delegate string MyDelegate5(string location);


    public delegate T GenericDelegate<T>(T a, T b);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            //MyDelegate d1 = new MyDelegate(Calculations.Sum);
            //int res = d1.Invoke(12, 3);
            //Console.WriteLine($"summation = {res}");

            //MyDelegate2 myDel2 = Calculations.Sub;
            //int output= myDel2(12, 1.6f);
            //Console.WriteLine($"subtraction = {output}");

            //MyDelegate d2 = new MyDelegate(Calculations.Sum);
            //d2 = Calculations.Mul;
            //int res2 = d2(12, 3);
            //Console.WriteLine($"summation = {res2}");

            //int x = 12;
            //int y = 5;
            //x = 1;
            //Console.WriteLine(x+y);


            //MyDelegate d3 = new MyDelegate(Calculations.Sum);
            //if (char.TryParse(Console.ReadLine(), out char myOperator))
            //{
            //    switch (myOperator)
            //    {
            //        case '+':
            //            d3 = Calculations.Sum;
            //            break;
            //        case '-':
            //            d3 = Calculations.Sub;
            //            break;
            //        case '*':
            //            d3 = Calculations.Mul;
            //            break;
            //        default:
            //            throw new Exception("no other allowed operators existed");
            //    }

            //    bool isValid2 = int.TryParse(Console.ReadLine(), out int a);
            //    bool isValid3 = int.TryParse(Console.ReadLine(), out int b);
            //    Calculations.DoTask(a, b, d3);
            //}


            //Calculations calc = new Calculations();
            //bool isValid = bool.TryParse(Console.ReadLine(), out bool isLocaitonOpened);

            //var result = calc.AccessLocation(
            //    isOpened: isLocaitonOpened, 
            //    grant: new MyDelegate5(Calculations.OpenLocation),
            //    deny: new MyDelegate5(Calculations.CloseLocation)
            //);

            //Console.WriteLine(result); 
            #endregion

            #region Multicasting Delegate (list of subscripers)

            //MyDelegate d = Calculations.Sum;
            //d += Calculations.Sub;
            //d += Calculations.Mul;
            //int result = d.Invoke(2,10);
            //Console.WriteLine($"result = {result}");

            //MyDelegate d = Calculations.Sum;
            //d += Calculations.Sub;
            //d += Calculations.Mul;
            //d += Calculations.Sum;
            //d -= Calculations.Sub;
            //int result = d.Invoke(2,10);
            //Console.WriteLine($"result = {result}");

            //MyDelegate d1 = Calculations.Sum;
            //d1 += Calculations.Mul;
            //d1 += Calculations.Sub;

            //MyDelegate d2 = Calculations.Sub;
            //d2 += Calculations.Mul;

            //MyDelegate d3 = d1 + d2;
            //int result = d3.Invoke(2, 10);
            //Console.WriteLine($"result = {result}");

            //MyDelegate d4 = d1 - d2;
            //int result = d4.Invoke(2, 10);
            //Console.WriteLine($"result = {result}");

            //MyDelegate d1 = Calculations.Sum;
            //d1 += Calculations.Mul;
            //d1 += Calculations.Sub;

            //Calculations.DoTask(2, 15, d1);

            #endregion

            #region Generic Delegate
            //GenericDelegate<decimal> gd1 = new GenericDelegate<decimal>(Calculations.Sum<decimal>);

            //var result = gd1.Invoke(12.2m, 13.9m);
            //Console.WriteLine(result);

            //GenericDelegate<int> gmcd = Calculations.Sum<int>;
            //gmcd += Calculations.Sub;
            //gmcd += Calculations.Mul;
            //int result = gmcd.Invoke(12, 13);
            //Console.WriteLine(result);

            //GenericDelegate<int> gmcd3 = Calculations.Sum<char>; // error
            //GenericDelegate<int> gmcd2 = Calculations.Sum<bool>; // error
            #endregion

            #region Built-in delegate
            //Func<int, int, int> btd1 = Calculations.Sum;
            //int res1 = btd1.Invoke(23, 2);
            //Console.WriteLine(res1);

            //Func<int, int, int> btd2 = Calculations.Sum<int>;
            //int res2 = btd2.Invoke(23, 2);
            //Console.WriteLine(res2);

            //Func<decimal, decimal, decimal> btd3 = Calculations.Sum<decimal>;
            //decimal res3 = btd3.Invoke(23.2m, 2.1m);
            //Console.WriteLine(res3);

            //double x = 12.3;
            //double y = 12.3;
            //Func<double, double, double> fun = Calculations.Sum;
            //Calculations.DoTask<double>(x, y, fun);

            //char ch1 = 'S';
            //char ch2 = 'A';
            //Func<char, char, char> fun = Calculations.Sum;
            //Calculations.DoTask(ch1, ch2, fun);


            //Action<int, int> ac1 = Calculations.Test;
            //ac1.Invoke(2,3);

            //MyDelegate d = Calculations.Mul;

            //Action<int, int, MyDelegate> ac2 = Calculations.DoTask;
            //ac2.Invoke(2,3, d);

            //Func<double, double, double> btd = Calculations.Sub<double>;
            //Action<double, double, Func<double, double, double>> ac3 = Calculations.DoTask;
            //ac3.Invoke(2.5,1.4, btd);

            
            //List<int> nums = [-1, -2, 20, -13, -7];
            //Console.WriteLine(nums.Find(Calculations.IsGreaterThanZero));


            //List<double> nums = [-1.3, -2.11, -2.9, -1.3, 0.7];
            //Predicate<double> pred = Calculations.IsGreaterThanZero;
            //Console.WriteLine(nums.Find(pred));
            #endregion
        }
    }
}
