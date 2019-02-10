using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002Targil
{
    public abstract class Shape
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double GetArea();

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            if (name.Length > 0)
            {
                this.name = name;
            }
        }
        
    }
}
