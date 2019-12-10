using System;

namespace Klasser
{
    public class Triangle
    {
        //Using Point from our Point struct.
        private Point[] Coordinates = new Point[2];

        public Triangle() {

        }
        public Triangle(float length, float height)
        {
            Coordinates[0] = new Point(0, length);
            Coordinates[1] = new Point(0, height);
        }

        public double GetHypotenuse() 
        {
            var hyp = Math.Sqrt(Coordinates[0].y * Coordinates[0].y + Coordinates[1].y * Coordinates[1].y);
            return hyp;
        }

        public double GetArea() {
            return (Coordinates[0].y * Coordinates[1].y) / 2;
        }

        //We're overriding the ToString method to present information of the triangle
        //when we print out the object of this class.
        public override string ToString() 
        {
            string retValue = "\nThe triangles base is " + Coordinates[0].y + " and the height is " + Coordinates[1].y;
            retValue += "\nThe hypotenuse is " + GetHypotenuse();
            retValue += "\nAnd the area is " + GetArea();
            return retValue;
        }
    }
}