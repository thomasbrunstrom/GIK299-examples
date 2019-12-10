using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klasser");

            // SimplePoint();

            // SimpleBox();

            // ParameterBox();

            // ExtendedSimpleBox();

            // ExtendedSimpleBoxWithTypeCast();

            TriangleExample();
            
            Console.ReadLine();
        }

        static void SimplePoint()
        {
            Console.WriteLine("SimplePoint");
            Point point1 = new Point();
            point1.x = 20;
            point1.y = 20;
            point1.PrintPoint();
            
            Point point2 = new Point { x = 10, y = 10 }; //"Faster" constructor
            point2.PrintPoint();

            point1.x = 30;
            point1.y = 30;
            point1.PrintPoint();
        }
        static void SimpleBox() 
        {
            Console.WriteLine("SimpleBox");
            Box box = new Box();
            box.SetHeight(10);
            box.SetWidth(10);
            box.SetLength(10);
            Console.WriteLine("The box has a volume of {0}", box.GetVolume());
        }

        static void ParameterBox()
        {
            Console.WriteLine("ParameterBox");
            Box box = new Box(20, 20, 20);
            Console.WriteLine("The box has a volume of {0}", box.GetVolume());
        }

        static void ExtendedSimpleBox()
        {
            Console.WriteLine("InheritedBox");
            ExtendedBox box = new ExtendedBox();
            Console.WriteLine("The inherited has a volume of {0}", box.GetVolume());
        }
        static void ExtendedSimpleBoxWithTypeCast()
        {
            Console.WriteLine("InheritedBox");
            ExtendedBox box = new ExtendedBox(10, 10, 10);
            Console.WriteLine("The inherited has a volume of {0}", box.GetVolume());
            Console.WriteLine("The ExtendedBox has a double volume of {0}", box.GetDoubleVolume());
            Box newBox = box as Box;
            Console.WriteLine("The Box newBox, casted from box ExtendedBox has a volume of {0}", newBox.GetVolume());
        }


        static void TriangleExample() 
        {
            Console.WriteLine("TriangleExample");
            Triangle tri = new Triangle(10, 20);
            Console.WriteLine("The hypotenuse for the triangle is {0} and area is {1}", tri.GetHypotenuse(), tri.GetArea());
            Console.WriteLine(tri);
        }
    }
}