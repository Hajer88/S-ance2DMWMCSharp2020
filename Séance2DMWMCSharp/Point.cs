using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Séance2DMWMCSharp
{
    enum PointColors
    { LightBlue, BloodRed, Gold }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColors colors { get; set; }
        public Point()
        {
                
        }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Point(int X, int Y, PointColors colors)
        {
            this.X = X;
            this.Y = Y;
            this.colors = colors;
        }
        public void Display()
        {
            Console.WriteLine("{0},{1}", X, Y);
        }
    }
}
