using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002Targil
{
    class Triangle : Shape
    {

        protected double a, b, c, h;

        public Triangle(string name, double a, double b, double c, double h) : base(name)
        {
            /*
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
            */

            Setabch(a, b, c, h);
        }

        public override double GetArea()
        {
            return c * h / 2.0;
        }

        public virtual double GetHekef()
        {
            return a + b + c;
        }

        protected internal void Setabch(double a, double b, double c, double h)
        {
            if (a > 0 && b > 0 && c > 0 && h > 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.h = h;
            }
            else
            {
                Console.WriteLine("IllegaL input. must be greater than 0");
            }
        }

        internal double GetA()
        {
            return this.a;
        }

        internal double GetB()
        {
            return this.b;
        }

        internal double GetC()
        {
            return this.c;
        }

        internal double GetH()
        {
            return this.h;
        }
    }
}
