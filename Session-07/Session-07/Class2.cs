using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {

    // enumeration
    public enum ShapeType { 
        Circle,
        Square,
        Triangle
    }

    public class Shape {

        public double Surface(ShapeType shapeType, double radius, double side) {

            double surface = 0;

            switch (shapeType) {
                case ShapeType.Circle:
                    surface = SurfaceCircle(radius);
                    break;

                case ShapeType.Square:
                    surface = SurfaceSquare(side);
                    break;

                case ShapeType.Triangle:
                    surface = SurfaceTriangle(side);
                    break;

                default:
                    Console.WriteLine("please select another type");
                    break;
            }

            return surface;

        }


        public double SurfaceCircle(double radius) {

            double surface = 0;

            surface = radius * (double)2 * Math.PI;

            return surface;
        }

        public double SurfaceSquare(double side) {
            double surface = 0;

            surface = side * side;

            return surface;
        }

        public double SurfaceTriangle(double side) {
            double surface = 0;

            surface = (side * side) / 2;

            return surface;
        }


    }

 

}
