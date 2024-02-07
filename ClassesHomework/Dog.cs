using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // Write your dog class here.
    public class Dog : Animal
    {
        

        public string Breed { get; protected set; }

    

        public Dog()
        {
            this.Species = "dog";
        }

        public Dog(string breedType)
        {
            this.Breed = breedType;
        }

        public Dog(int currentAge)
        {
            this.Age = currentAge;
        }


        public Dog(string breedType, int currentAge)
        {
            this.Breed = breedType;
            this.Age = currentAge;
          
                                 
        }

        public Dog(string breedType, int currentAge, string dogsSay )
        {
            this.Breed = breedType;
            this.Age = currentAge;       
        }

     

        public string Speak()
        {
            string theDogSays = "woof!";

            return theDogSays;
        }       

     
        

       
           
        

        
    }
}
