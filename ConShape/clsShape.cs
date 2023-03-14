using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConShape
{
    internal class clsShape
    {
        private string name;
        private int sides;

        public clsShape()
        {

        }

        public clsShape(string name, int sides)
        {
            this.name = name;
            this.sides = sides;
        }

        public string Name { get => name; set => name = value; }
        public int Sides { get => sides; set => sides = value; }

        public double ComputeArea()
        {
            return 0.0;
        }

        public double ComputePerimeter()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return "Name: " + this.Name +
                "No. of Sides: " + this.Sides;
        }
    }
}
