using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1002
{
    class Citizen
    {
        public string name;
        public Citizen[] children = new Citizen[0];

        public readonly int fatherID;
        public readonly int id;

        public static Random r = new Random();

        public static int _numberOfCurrentCitizens = 0;
        public const int MAXIMUM_NUMBER_OF_CITIZENS = 50_000;

        public static int idAlgorithm = RANDOM_NUMBER; // 1.auto-increment 2.Random
        public const int AUTO_INCREMENT = 1;
        public const int RANDOM_NUMBER = 2;

        public static bool[] ids = new bool[MAXIMUM_NUMBER_OF_CITIZENS];

        public Citizen(string name, int fatherID)
        {
            
            this.name = name;
            this.fatherID = fatherID;

            // this inmcrease the number of citizens [static]
            _numberOfCurrentCitizens++;

            // this is etgar, here we give id according to the algorithm
            // if the algorithm is 1, then the id will be the current number of citizens
            // if the algorithm is 2, then the id will be a random number
            // in order not to use 1, 2 we created a 2 consts (see above):
            //    public const int AUTO_INCREMENT = 1;
            //    public const int RANDOM_NUMBER = 2;
            switch (idAlgorithm)
            {
                case AUTO_INCREMENT:
                    this.id = _numberOfCurrentCitizens;
                    break;
                case RANDOM_NUMBER:
                    // this is etgar** we do not want to give 2 different citizens the same random id
                    // to do so, we created an array (see above)
                    // public static bool[] ids = new bool[MAXIMUM_NUMBER_OF_CITIZENS];
                    // each time a citizedn is given an id, the array in the id index is being set to true (the default value is always false)
                    // the next time the same random number will be generated the array in the same place will be true there for a new number will be generated
                    // this is why we have a do{} while() here. while the index is taken a new random number is being generated 
                    int newId = 0;
                    do
                    {
                        newId = r.Next(MAXIMUM_NUMBER_OF_CITIZENS + 1);
                    }
                    while (ids[newId] == true);
                    ids[newId] = true;
                    this.id = newId;
                    break;
            }
            
        }

        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine($"Number of citizens : {_numberOfCurrentCitizens}");
        }

        public static bool hasReachedHalfNumberOfMaximumSize()
        {
            //bool result = _numberOfCurrentCitizens *2 >= MAXIMUM_NUMBER_OF_CITIZENS;
            //return result;

            return _numberOfCurrentCitizens * 2 >= MAXIMUM_NUMBER_OF_CITIZENS;
        }

        public void PrintID()
        {
            Console.WriteLine($"ID : {this.id}");
        }

        public void PrintGapBetweenMyIDAndPapa()
        {
            Console.WriteLine($"Gap between me and papa = {this.id - this.fatherID}");
        }

        public void SetChildren(Citizen[] children)
        {
            this.children = children;
        }

        public override string ToString()
        {
            return $"name : {this.name} id : {this.id} father-id : {this.fatherID}";
            // TO-DO add children
        }
    }
}
