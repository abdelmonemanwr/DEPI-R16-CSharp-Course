using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIII
{
    public class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public Complex()
        {
            
        }

        public Complex(int Real, int Imag)
        {
            this.Real = Real;
            this.Imag = Imag;
        }

        public override string ToString()
        {
            char op = Imag >= 0 ? '+' : ' ';
            return $"{Real}{op}{Imag}i";
        }

        // binary operator
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imag + c2.Imag);
        }
        
        public static Complex operator +(Complex c1, int value)
        {
            return new Complex(c1.Real + value, c1.Imag + value);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imag - c2.Imag);
        }

        public static Complex operator -(Complex c1, int value)
        {
            return new Complex(c1.Real - value, c1.Imag - value);
        }

        // unary operator
        public static Complex operator ++(Complex c1)
        {
            c1.Real++;
            c1.Imag++;
            return c1;
        }
        public static Complex operator --(Complex c1)
        {
            c1.Real--;
            c1.Imag--;
            return c1;
        }

        // matching operators [==,!=] [<,>] [<=, >=]
        // c1==c2
        public static bool operator ==(Complex c1, Complex com2)
        {
            return (c1.Real == com2.Real && c1.Imag == com2.Imag);
        }
        
        public static bool operator !=(Complex c1, Complex c2)
        {
            //return !(c1==c2);
            return c1.Real != c2.Real || c1.Imag != c2.Imag;
        }


    }
}
