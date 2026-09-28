using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIV.IS_A
{
    class Child : Parent
    {
        // ctor, dctor, private member
        public int Z { get; set; }
        //public int Z { get; set; } // error
        public new string S { get; set; } = string.Empty;


        //public Child():base(15,25)
        //{
            
        //}

        public Child(int Z):base(15,25)
        {
            this.Z = Z;
        }

        // Polymorphism (Overriding, Overloading, MethodHidden)
        // method hidden
        //public new void Show()
        //{
        //    // extend behavior
        //    base.Show();
        //    Console.WriteLine($"Z = {Z}");

        //    // add new behaviour
        //    // ...
        //}

        // overrided
        //public override void Show()
        //{
        //    // extend
        //    base.Show();
        //    Console.WriteLine($"Z = {Z}");

        //    // add new behaviour
        //    // ...
        //}

        // sealed overrided
        public sealed override void Show()
        {
            // extend
            base.Show();
            Console.WriteLine($"Z = {Z}");

            // add new behaviour
            // ...
        }

        //public void Display()
        //{
        //    Console.WriteLine(Y); // error: inaccessible
        //}
    }
}
