using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.Other
{

    public class Shape
    {

        public Color SurfaceColor { get; set; }

        public string Name { get; set; }

        public virtual double Surface(double dimension)
        {

            double surface = 0;
            surface = dimension * dimension;

            return surface;
        }

        public virtual double Surface(double x, double y)
        {

            double surface = 0;

            // do ...

            return surface;
        }
    }

    public class Circle : Shape
    {

        public Circle()
        {
            Name = "Circle";
        }

        public override double Surface(double dimension)
        {

            double surface = 0;
            surface = Math.Pow(dimension, 2) * Math.PI;

            return surface;
        }
    }

    public class Square : Shape
    {

        public Square()
        {
            Name = "Square";
        }

        public override double Surface(double dimension)
        {
            return base.Surface(dimension);
        }

    }

    public class Triangle : Shape
    {

        public Triangle()
        {
            Name = "Triangle";
        }

        public override double Surface(double dimension)
        {

            double surface = 0;
            surface = dimension * dimension / 2;

            return surface;
        }
    }
}
