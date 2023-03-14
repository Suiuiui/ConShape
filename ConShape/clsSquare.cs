using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConShape
{
    internal class clsSquare
    {
        private string name;
        private int sides;
        private double side1;

        public clsSquare()
        {

        }

        public clsSquare(string name, int side, double side1)
        {
            this.name = name;
            this.sides = side;
            this.side1 = side1;
        }

        public double ComputeArea()
        {
            return sides * sides;
        }

        public double ComputePerimeter()
        {
            return 4 * sides;
        }

        public string Name { get => name; set => name = value; }
        public int Sides { get => sides; set => sides = value; }
        public double Side1 { get => side1; set => side1 = value; }

        public override string ToString()
        {
            return "Name: " + this.Name +
                "No. of Sides: " + this.Sides +
                "Side1: ";
        }
    }
}
