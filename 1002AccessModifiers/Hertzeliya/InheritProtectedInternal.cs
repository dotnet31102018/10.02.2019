using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hertzeliya
{
    class InheritProtectedInternal : ProtectedInternalClass
    {
        public void foo()
        {
            Console.WriteLine(base.protectedInternalNumber);
        }
    }
}
