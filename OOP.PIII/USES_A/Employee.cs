using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIII.USES_A
{
    internal class Employee
    {
        // Employee uses printer
        public void PrintPaper(Printer printer, string text)
        {
            printer.Print(text);
        }
    }
}
