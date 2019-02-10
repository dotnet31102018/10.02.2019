using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002Targil
{
    class TriangleEqualSidezs : Triangle
    {
        public TriangleEqualSidezs(string name, double a, double h) : base(name, a, a, a, h)
        {
        }

        public override double GetHekef()
        {
            return this.a * 3;
        }
    }
}
