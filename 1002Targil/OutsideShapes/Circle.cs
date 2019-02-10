using _1002Targil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideShapes
{
    class Circle : Shape
    {

        protected double radius;

        protected const double PIE = 3.14415926;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return this.radius * this.radius * PIE;
        }

        public static double GetPie()
        {
            return PIE;
        }

    }
}
