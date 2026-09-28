using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIV.Abtract
{
    //class Doctor : User, FullEmployee // multible inheritance is disallowed (Diamond Problem){}
    class Doctor : User
    {
        public override void Print()
        {
            Console.WriteLine("Doctor Details");
        }
    }
}
