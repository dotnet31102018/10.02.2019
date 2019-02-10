using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelAviv;

namespace Hertzeliya
{
    class Program
    {
        static void Main(string[] args)
        {
            //Papa p = new Papa();
            Papa p = new Papa("papa hertzeliya", 1.77f);

            HerzelyaSon hs = new HerzelyaSon("son hertzeliya", 1.77f);

            ProtectedInternalClass c1 = new ProtectedInternalClass();
            
        }
    }
}
