namespace OOP.PII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                  1. Declaration
                  2. Equality
                  3. Constructors
                  4. Destructors
                  5. Inheritance

             */

            #region Declaration
            //int x;
            //Console.WriteLine(x);

            //Point2D point = new Point2D();
            //point.X = 23;

            //Student student = new Student("Abdalmon3m", 25); // allocate obj in heap
            //student.Name = "Men3m"; 
            #endregion

            #region Equality

            //Point2D p1 = new Point2D(2, 4);
            //Point2D p2 = new Point2D(1, 3);

            //Console.WriteLine(p1.GetString());
            //Console.WriteLine(p2.GetString());

            //p2 = p1;       // Deep Copy
            //p2.X = -1;

            ////int x = 2;
            ////int y = x;
            ////x = 3;

            //Console.WriteLine(p1.GetString());
            //Console.WriteLine(p2.GetString());


            //Student s1 = new Student("malak", 19);
            //Student s2 = new Student("saleh", 20);

            //Console.WriteLine(s1.GetString());
            //Console.WriteLine(s2.GetString());

            //s2 = s1; // Shallow Copy
            //s2.Name = "Mohamed";

            //Console.WriteLine(s1.GetString());
            //Console.WriteLine(s2.GetString());

            #endregion

            #region Constructors
            // default ctor
            //Student s = new Student();
            //Point2D p = new Point2D();

            #endregion

            #region Destructors
            // default ctor
            //Student s = new Student();
            //Point2D p = new Point2D();

            #endregion

            #region Inheritance
            /*
             System.object
                 > GetType()
                 > ToString()
                 > Equals()
                 > GetHashCode()
             */

            #region GetType
            //Point2D p = new Point2D();
            //Console.WriteLine(p.GetType());
            //Console.WriteLine(p.GetType().Name);
            //Console.WriteLine(p.GetType().FullName);
            //Console.WriteLine(p.GetType().BaseType);

            //Student s = new Student("Men3m");
            //Console.WriteLine(s.GetType());
            //Console.WriteLine(s.GetType().Name);
            //Console.WriteLine(s.GetType().FullName);
            //Console.WriteLine(s.GetType().BaseType);
            #endregion

            #region ToString
            //Student s = new Student("Men3m");
            //Console.WriteLine(s.ToString());
            //Console.WriteLine(s);

            //int x = 12;
            //Console.WriteLine(x.ToString()); // represent x in string format
            #endregion

            #region Equals

            //Student s1 = new Student("Ahmed", 20);
            //Student s2 = new Student("Ahmed", 20);
            ////Student s2 = new Student("Ammar", 25);
            ////Student s2 = new Student("Ammar", 20);
            ////Student s2 = new Student("Ahmed", 25);

            ////s2 = s1;

            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equals");
            //}
            #endregion

            #region GetHashCode
            Student s1 = new Student("Ahmed", 20);
            Student s2 = new Student("Ahmed", 20);
            //Student s2 = new Student("Ammar", 25);

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            #endregion

            #endregion

            #region Constructor-Chaining
            //Student s = new Student();

            //Console.WriteLine(s.GetString());

            #endregion
        }
    }
}
