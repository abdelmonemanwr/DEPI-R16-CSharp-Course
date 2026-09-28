using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIV.IS_A
{
    class SubChild : Child
    {
        public int A { get; set; }
        public SubChild():base(12)
        {
            
        }

        public SubChild(int A):base(12)
        {
            this.A = A;
        }

        // method hidden
        public new void Show()
        {
            // extend
            base.Show();
            Console.WriteLine($"A = {A}");

            // add new behaviour
            // ...
        }

        //public override void Show()
        //{
        //    // extend
        //    base.Show();
        //    Console.WriteLine($"A = {A}");

        //    // add new behaviour
        //    // ...
        //}
    }
}
