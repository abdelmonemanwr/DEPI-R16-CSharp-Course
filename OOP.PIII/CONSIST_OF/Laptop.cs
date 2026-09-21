using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIII.CONSIST_OF
{
    internal class Laptop
    {
        // touchpad, screen, .... , processor

        //public Processor Processor { get; set; } = new Processor(gen: 10, core: 8);// named parameter
        public Processor Processor { get; set; }

        public Laptop(Processor processor)
        {
            Processor = processor;
        }

        // 1. Modification
        // 2. Sharing Data
        // 3. Testing

        // Design Pattern : Dependency Injection : Don't Create but (ask|inject|pass)
    }
}
