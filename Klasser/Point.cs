using System;

namespace Klasser
{
    public struct Point {
        public float x;
        public float y;
        public Point(float cx, float cy) 
        {
            x = cx;
            y = cy;
        }
        public void PrintPoint() 
        {
            Console.WriteLine("This point has an value of {0} for x and {1} for y", x, y);
        }
    }
}