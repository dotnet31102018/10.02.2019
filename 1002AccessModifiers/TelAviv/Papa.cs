using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelAviv
{
    public class Papa
    {
        float height;
        public string name;

        private int secretVaultNumber = 777;

        // need c# 7.2
        //private protected int familySameProjectOnly = 4;

        protected int familySecretNumber = 555;

        public Papa(string name, float height)
        {
            //this.height = height;
            SetHeight(height);
            this.name = name;
        }

        // Setter
        public void SetHeight(float newHeight)
        {
            if (newHeight <= 0)
            {
                Console.WriteLine("illegal value!");
            }
            else
            {
                this.height = newHeight;
            }
        }

        // Getter
        public float GetHeight()
        {
            return this.height;
        }

        private static int _static_number = 1;

        void GetNotherVauleCode(Papa otherPapa)
        {
            int stealNumber = otherPapa.secretVaultNumber;
        }

        protected void WalkInFamilyHouse()
        {
            Console.WriteLine("Walking in family house!");
        }

        // TO-Do toString

        internal void WalkInTelAviv()
        {
            Console.WriteLine("Walking in the city Tel Aviv");
        }

        private class privateClass
        {

        }
    }
}
