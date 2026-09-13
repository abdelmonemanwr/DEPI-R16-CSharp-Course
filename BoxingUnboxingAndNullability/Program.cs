namespace BoxingUnboxingAndNullability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing & Unboxing
            //int x = 12; // stack : value dt

            //x++;
            //x += 13;

            //object obj = x; // boxing | no data loss | implicit - safe

            //obj += 3;
            //int objValue = (int)obj;  // unboxing | explicit - unsafe
            //objValue += 3;
            //obj = objValue; // boxing

            //long objValue2 = (long)obj;
            //long objValue2 = (int)obj;
            //long objValue2 = (long)(int)obj;
            //Console.WriteLine(objValue2);

            //long y = 12; 
            #endregion

            #region Nullable Value Types

            //decimal salary = null;
            //decimal? salary = 999.99m;
            //decimal? salary = null;

            //try
            //{
            //    Console.WriteLine(salary.Value);
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine("invalid value");
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}

            //if (salary.HasValue)
            //{
            //    Console.WriteLine(salary.Value);
            //}
            //else
            //{
            //    Console.WriteLine("null value");
            //}


            // null coalescing operator
            //decimal? salary = 999.99m;
            //decimal? salary = null;
            //Console.WriteLine(salary ?? -1);
            // salary??=-1;
            //Console.WriteLine(salary);

            #endregion

            #region Nullable Reference Types

            // student = null
            // student.Name => NullReferenceException

            //string? name = "men3m";
            //name = null;
            //Console.WriteLine(name);
            #endregion

            #region Null Conditional Operator
            //decimal? salary = null;
            //Console.WriteLine(salary.Value);

            //int x = 10;
            //x += 2;
            //x++;
            //Console.WriteLine(x+1);
            ////x = x + 2;

            ////string? name = "shahd";
            //string? name = null;
            //name ??= "Unknown";
            //Console.WriteLine(name);
            #endregion
        }
    }
}
