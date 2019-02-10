using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelAviv;

namespace Hertzeliya
{
    class HerzelyaSon : Papa
    {
        public HerzelyaSon(string name, float height) : base(name, height)
        {
        }

        public void inTelAviv()
        {
            base.WalkInFamilyHouse();
        }
    }
}
