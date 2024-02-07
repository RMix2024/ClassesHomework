using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    public class Animal
    {
        public string Species { get; set; } = "unknown";

        public bool IsSitting { get; protected set; } = false;

        public int Age { get; protected set; } = 1;


        public Animal()
        {

        }

        public string Speak(string theDogSays)
        {
            return theDogSays;
        }

        virtual public string Speak()
        {
            string theCatSays = "meow!";
            string theDogSays = "woof!";
            string unkown = "What am I?";

            if (this.Species == "dog")
            {
                return theDogSays;
            }
            else if (this.Species == "cat")
            {
                return theCatSays;

            }
            else
            {
                return unkown;
            }                   
        }

        virtual public void Sit()
        {
            IsSitting = true;

        }

        virtual public void Stand()
        {
            IsSitting = false;
        }

        virtual public void CelebrateBirthday()
        {
            Age++;
        }

      
    }
}
