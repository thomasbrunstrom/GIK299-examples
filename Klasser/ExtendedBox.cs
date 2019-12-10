using System;

namespace Klasser
{
    class ExtendedBox : Box //Class with inheritance from Box
    {
        public ExtendedBox()  //Empty constructor
        {
        }
        public ExtendedBox(double Length, double Height, double Width) //Constructor with three parameters
        {
            length = Length;
            height = Height;
            width = Width;
        }

        public override double GetVolume()
        {
            Console.WriteLine("GetVolume in child");
            return height * width * length;
        }
        public double GetDoubleVolume()
        {
            Console.WriteLine("GetDoubleVolume in child");
            return 2 * (height * width * length);
        }
    }

}