namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region builtin-interfaces
            //int[] arr = new int[5] { 12, 1, -10, -8, 0 };
            //Array.Sort(arr);
            //for(int i=0; i<arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            //int x = -15;
            //int y = -15;
            //Console.WriteLine(x.CompareTo(y));

            //Console.WriteLine(x is IComparable);

            //Student[] students = new Student[] {
            //    new Student(2, "Ahmed Mohamed"),
            //    new Student(3, "Shahd"),
            //    new Student(1, "Ahmed Saleh"),
            //};

            //Console.WriteLine(students is IComparable);

            //Array.Sort(students);

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"{students[i]} ");
            //}

            //var std = new Student(2, "Ahmed Mohamed");
            //var emp = new Employee(3, "Ahmed Saleh");
            //std.CompareTo(emp);

            //var std1 = new Student(2, "Ahmed Mohamed");
            //Student? std2 = null;
            //var x = std1.CompareTo(std2);

            //Student? std = new Student(1, "Omar");
            //Console.WriteLine(std);

            //using (Student? std = new Student(1, "Omar"))
            //{
            //    Console.WriteLine(std);
            //}

            //using Student? std = new Student(1, "Omar");
            //Console.WriteLine(std);
            #endregion

            #region Generic Method
            //int x = 12;
            //int y = 13;
            //Operations op = new Operations();
            ////op.Swap(x, y);
            //op.Swap(ref x, ref y);
            //Console.WriteLine($"X = {x}, Y = {y}");

            //int m = 12;
            //int n = 13;
            //GenericOperations.Swap<int>(ref m, ref n);
            //Console.WriteLine($"M = {m}, N = {n}");

            //char c = 'S';
            //char v = 'A';
            //Console.WriteLine($"C = {c}, V = {v}");
            //GenericOperations.Swap<char>(ref c, ref v);
            //Console.WriteLine($"C = {c}, V = {v}");

            //GenericOperations.Print<int, string>(23, "men3m");
            #endregion

            //MyStack st = new MyStack();
            //Console.WriteLine( st.Pop());
            //st.Push("shahd");
            //st.Push("omar");
            //st.Push("aMohamed");
            //Console.WriteLine( st.Pop());
            //st.Push("Men3m");
            //st.Push("Saleh");
            //st.Push("DEPI");
            //st.Push("ITI");

            //MyGenericStack<string> st = new MyGenericStack<string>();
            //MyGenericStack<string> st = new();
            //var st = new MyGenericStack<string>();
            //Console.WriteLine(st.Pop());
            //st.Push("shahd");
            //st.Push("omar");
            //st.Push("aMohamed");
            //Console.WriteLine(st.Pop());
            //st.Push("Men3m");
            //st.Push("Saleh");
            //st.Push("DEPI");
            //st.Push("ITI");

            //MyGenericStack<decimal> st = new();
            //st.Push(3.2m);
            //st.Push(-19.52m);
            //st.Push(48.12m);
            //st.Push(10.67m);
            //st.Push(21.93m);
            //Console.WriteLine(st.Pop());
            //st.Push(10.67m);
            //st.Push(21.93m); // 


            //IGenericRepository<Student> genericRepository = new GenericRepository<Student>();
            //genericRepository.Add(new Student(1, "men3m"));


            HashSet<string> vipGuessts = new HashSet<string>();
            vipGuessts.Add("ahmed");
            vipGuessts.Add("Ahmed");
            vipGuessts.Add("ahmed");
            foreach(string vipGuest in vipGuessts)
            {
                Console.WriteLine(vipGuest);
            }
        }
    }
}
