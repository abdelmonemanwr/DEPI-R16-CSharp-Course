namespace OOP.PI
{
    // Encapsulation
    // access modifiers = 6
    // public , private, protected
    struct Complex
    {
        // fields
        int real;
        int imag=-1;

        //public int numericValue;
        //public int age;

        // behaviors
        // parameterless ctor
        public Complex()
        {
            real = 1;
            imag = 1;
            Console.WriteLine("def ctor is called\n");
        }

        // parameterized ctor
        public Complex(int _real, int _imag)
        {
            real = _real;
            imag = _imag;
            Console.WriteLine("parameterized ctor is called\n");
        }

        public Complex(int _real)
        {
            real = _real;
            imag = 1;
            Console.WriteLine("parameterized ctor is called\n");
        }


        // setters
        public void SetReal(int _real)
        {
            if (_real > 0 && _real <= 100)
                real = _real;
            else
                throw new Exception("invalid value");
        }

        public int GetReal()
        {
            if (real > 0 && real <= 100)
                return real;
            else
                throw new Exception("invalid value");
        }

        public int GetImag()
        {
            return imag;
        }
        
        public void SetImag(int _imag)
        {
            if (_imag > 0 && _imag <= 100)
                imag = _imag;
            else
                throw new Exception("invalid data");
        }

        public string GetData()
        {
            return $"Real = {real}, Imag = {imag}i";
        }
    };
    
    struct NewComplex
    {
        // fields
        //int real;
        int imag;

        // behaviors

        #region constructors
        // parameterless ctor
        public NewComplex()
        {
            real = 1;
            imag = 1;
            Console.WriteLine("def ctor is called\n");
        }

        // parameterized ctor
        public NewComplex(int _real, int _imag)
        {
            real = _real;
            imag = _imag;
            Console.WriteLine("parameterized ctor is called\n");
        }

        public NewComplex(int _real)
        {
            real = _real;
            imag = 1;
            Console.WriteLine("parameterized ctor is called\n");
        } 
        #endregion


        // setters
        //public void SetReal(int _real)
        //{
        //    if (_real > 0 && _real <= 100)
        //        real = _real;
        //    else
        //        throw new Exception("invalid value");
        //}

        //public int GetReal()
        //{
        //    if (real > 0 && real <= 100)
        //        return real;
        //    else
        //        throw new Exception("invalid value");
        //}

        //public int GetImag()
        //{
        //    return imag;
        //}
        
        //public void SetImag(int _imag)
        //{
        //    if (_imag > 0 && _imag <= 100)
        //        imag = _imag;
        //    else
        //        throw new Exception("invalid data");
        //}


        // property = setter + getter + can be like a varible
        // x = 5
        // Console.WriteLine(x)
        int real;
        public int Real
        {
            set
            {
                if (value > 0 && value <= 100)
                    real = value;
                else
                    throw new Exception("invalid value");
            }

            get
            {
                if (real > 0 && real <= 100)
                    return real;
                else
                    throw new Exception("invalid value");
            }
        }

        public int Imag 
        {
            get
            {
                if (imag > 0 && imag <= 100)
                    return imag;
                else
                    throw new Exception("invalid value");
            }
            set 
            {
                if (value > 0 && value <= 100)
                    imag = value;
                else
                    throw new Exception("invalid value");
            } 
        }

        public string GetData()
        {
            return $"Real = {Real}, Imag = {Imag}i";
        }
    };

    struct MyComplex
    {
        // Automatic Properties = 
        public int Real { get; set; }
        public int Imag { get; set; }

        #region constructors
        // parameterless ctor
        public MyComplex()
        {
            Real = 1;
            Imag = 1;
            Console.WriteLine("def ctor is called\n");
        }

        // parameterized ctor
        public MyComplex(int _real, int _imag)
        {
            Real = _real;
            Imag = _imag;
            Console.WriteLine("parameterized ctor is called\n");
        }

        public MyComplex(int _real)
        {
            Real = _real;
            Imag = 1;
            Console.WriteLine("parameterized ctor is called\n");
        }
        #endregion

        // behaviours
        public string GetData()
        {
            return $"Real = {Real}, Imag = {Imag}i";
        }
    };

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //Complex c = new Complex();
            //c.Real = 12;
            //c.Imag = 23;


            //// -2e9 : 2e9
            //c.numericValue = 10;
            //c.numericValue = -10;
            //c.numericValue = 1000000;

            //c.age = -20000;
            //c.age = 1000;
            //c.age = 10;

            //Console.WriteLine(c.GetData());


            //Complex c1 = new Complex();
            //c1.SetReal(-10000);
            //c1.SetImag(20000);
            //Console.WriteLine(c1.GetData());

            //Complex c2 = new Complex();
            //c2.SetReal(100);
            //c2.SetImag(20);
            //Console.WriteLine(c2.GetData());
            //Console.WriteLine(c2.GetReal());
            //Console.WriteLine(c2.GetImag());



            //// paramterless ctor
            //Complex c3 = new Complex();
            //Console.WriteLine(c3.GetData());

            //// parameterized ctor
            //Complex c4 = new Complex(12, 4);
            //Console.WriteLine(c4.GetData());

            //// parameterized ctor
            //Complex c5 = new Complex(14);
            //Console.WriteLine(c5.GetData());

            #endregion

            #region Properties & Automatic Properties
            //Complex c6 = new Complex(12, 13); // 12 + 13i
            ////x+=3;
            //int x = 3;
            //int real = c6.GetReal()+x;
            //c6.SetReal(real);
            //Console.WriteLine(c6.GetData());

            //NewComplex c7 = new(-3,7); // sugar syntax
            //Console.WriteLine(c7.GetData());


            //NewComplex c8 = new(3, -7); // sugar syntax
            //Console.WriteLine(c8.GetData());

            //NewComplex c9 = new(3, 7); // sugar syntax
            //c9.Real -= 2;
            //c9.Imag -= 2;
            //Console.WriteLine(c9.GetData());

            MyComplex c10 = new MyComplex(3, 33);
            c10.Real += 15;
            c10.Imag -= 15;
            Console.WriteLine(c10.GetData());

            #endregion
        }
    }
}
