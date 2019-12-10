using System;

namespace Klasser
{
    class Box
    {
        //Using protected to be able to access them in child class.
        protected double length;
        protected double width;
        protected double height;

        public Box() {

        }
        public Box(double Length, double Height, double Width) 
        {
            length = Length;
            height = Height;
            width = Width;
        }

        public void SetLength(double Length)
        {
            length = Length;
        }
        public void SetHeight(double Height)
        {
            height = Height;
        }
        public void SetWidth(double Width)
        {
            width = Width;
        }
        public virtual double GetVolume()
        {
            Console.WriteLine("GetVolume in parent");
            return height * width * length;
        }
    }
}