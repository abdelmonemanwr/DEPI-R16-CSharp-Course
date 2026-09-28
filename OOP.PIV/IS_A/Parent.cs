using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIV.IS_A
{
    class Parent
    {
        public int X { get; set; }
        private int Y { get; set; }
        protected int S { get; set; }

        //public Parent():this(X: -1, S:-1)
        //{
        //}

        public Parent(int X) : this(X: X, S: -1)
        {
        }

        public Parent(int X, int S)
        {
            Y = -1;
            this.X = X;
            this.S = S;
        }

        // method
        //public void Show()
        //{
        //    Console.WriteLine($"X = {X}, S = {S}, Y = {Y}");
        //}

        // virtual
        public virtual void Show()
        {
            Console.WriteLine($"X = {X}, S = {S}, Y = {Y}");
        }
    }
}

/*
   parent: virtual
   child: override
   subchild: method hidden

   // parent p = new subchild();
   // p.show();
*/
