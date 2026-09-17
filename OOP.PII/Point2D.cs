using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PII
{
    struct Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string GetString()
        {
            return $"({X}, {Y})";
        }
    }
}
