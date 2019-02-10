using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelAviv
{
    class Program
    {
        static void Main(string[] args)
        {
            Papa p = new Papa("John", 1.97f);
            p.SetHeight(-1.7f);
            p.SetHeight(1.7f);
            Console.WriteLine(p.GetHeight());
            Son s = new Son("motti", 1.55f);
            p.WalkInTelAviv();

        }

    }
}
