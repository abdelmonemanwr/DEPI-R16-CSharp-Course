using System.Security.AccessControl;

namespace Delegates.PI
{
    // access-modifier delegate return-type delName (T1 p1, T2 p2)
    // access-modifier return-type funcName (T1 p1, T2 p2)
    // public int sum(int a, int b)

    // declarations
    public delegate int MyDelegate(int a, int b); 
    public delegate int MyDelegate2(int a, float b);
    public delegate void MyDelegate3(int a, float b, string c);
    public delegate string MyDelegate5(string location);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
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

        }
    }
}
