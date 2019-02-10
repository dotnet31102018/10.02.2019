using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen noah = new Citizen("Noah", 0); // id = 1
            Citizen shem = new Citizen("Shem", 1);
            Citizen ham = new Citizen("Ham", 1);
            Citizen.idAlgorithm = Citizen.RANDOM_NUMBER;
            Citizen yefet = new Citizen("Yefet", 1);
            Citizen[] kids =
            {
                shem, ham, yefet
            };
            noah.SetChildren(kids);

            Citizen nokids = new Citizen("", 1);

            nokids.SetChildren(new Citizen[0]);

            Console.WriteLine(HasChildren(nokids));
            Console.WriteLine(HasChildren( noah ));

        }

        static bool HasChildren(Citizen c)
        {
            return c.children.Length > 0;
        }

        static bool IsValid(Citizen c)
        {
            for (int i = 0; i < c.children.Length; i++)
            {
                if (c.children[i].fatherID != c.id)
                    return false;
            }

            // foreach
            // this is a nicer way to replace the for-loop
            // we do not need index here, we just run foreach item in the array(also supports List)
            foreach (Citizen kid in c.children)
            {
                if (kid.fatherID != c.id)
                    return false;
            }

            return true;
        }
    }
}
