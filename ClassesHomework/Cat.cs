using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // Write your Cat class here

    public class Cat : Animal
    {


        public string Breed { get; protected set; }

    

        public Cat()
        {
            this.Species = "cat";
        }

        public Cat(string breedType)
        {
            this.Breed = breedType;
        }

        public Cat(int currentAge)
        {
            this.Age = currentAge;
        }


        public Cat(string breedType, int currentAge)
        {
            this.Breed = breedType;
            this.Age = currentAge;


        }

        public Cat(string breedType, int currentAge, string catsSay)
        {
            this.Breed = breedType;
            this.Age = currentAge;
        }

      

        public string Speak(string theCatSays)
        {

            return theCatSays;
        }      

     








    }
}
