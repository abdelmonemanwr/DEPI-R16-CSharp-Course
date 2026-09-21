using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PIII.CONSIST_OF
{
    internal class Processor
    {
        public int Core { get; set; }
        public int Gen { get; set; }
        public int X { get; set; }
        public Processor(int core, int gen, int x)
        {
            Core = core;
            Gen = gen;
            X = x;
        }
        public override string ToString()
        {
            return $"Core = {Core}, Generation = {Gen}, X = {X}";
        }
    }
}
