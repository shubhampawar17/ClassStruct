using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruct.model
{
    internal struct Point
    {
        // Fields
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method to display point coordinates
        public void DisplayPoint()
        {
            Console.WriteLine($"Point coordinates: ({X}, {Y})");
        }
    }
}
