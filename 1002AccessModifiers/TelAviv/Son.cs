using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelAviv
{
    class Son : Papa
    {
        public Son(string name, float height) : base(name, height)
        {
        }

        public void OpenPapaValue()
        {
            // cannot!!
        }

        public void WalkInHouse()
        {
            base.WalkInFamilyHouse();
        }

        protected void WhatIsProtectedNumber()
        {
            Console.WriteLine(base.familySecretNumber);
        }
    }
}
