using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsShape shape1 = new clsShape();
            shape1.Name = "\tTrapezoid";
            Console.WriteLine("Shape: " + shape1.Name);
            shape1.Sides = 4;
            Console.WriteLine("No. of Sides: " + shape1.Sides);
            Console.WriteLine("Area: " + shape1.ComputeArea());
            Console.WriteLine("Perimeter: " +shape1.ComputePerimeter());

            clsShape shape2 = new clsShape();
            shape2.Name = "\tRhombus";
            Console.WriteLine("Shape: " + shape2.Name);
            shape2.Sides = 4;
            Console.WriteLine("No. of Sides: " + shape2.Sides);
            Console.WriteLine("Area: " + shape2.ComputeArea());
            Console.WriteLine("Perimeter: " + shape2.ComputePerimeter());

            clsSquare shape3 = new clsSquare();
            shape3.Name = "\tSquare";
            Console.WriteLine("Shape: " + shape3.Name);
            shape3.Sides = 4;
            shape3.Side1 = 4;
            Console.WriteLine("No. of Sides: " + shape3.Sides);
            Console.WriteLine("Area: " + shape3.ComputeArea());
            Console.WriteLine("Perimeter: " + shape3.ComputePerimeter());
        }
    }
}
