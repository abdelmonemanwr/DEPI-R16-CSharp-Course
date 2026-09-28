using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIV.Abtract
{
    class Nurse : User
    {
        public override void Print()
        {
            Console.WriteLine("Nurse Details");
        }
    }
}
