using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    class Penguin : Bird
    {
        /// <summary>
        /// Penugin class implements the Bird abstract class
        /// It overlaods the birdNest method of Bird class
        /// It overrides the abstract method birdCall of the Bird class
        /// It has a global accessor Property Volume which allows this value to be read outside of the class
        /// </summary>
        float volume;       //This variable has class scope
        public override void birdCall()     //Overrides abstract method from parent
        {
            volume = 27.3f;
            float lVolume = 2 * volume;     //Local volume has only got method scope
            Console.WriteLine("Squaaark at " + lVolume);
            //throw new NotImplementedException();      This was put in by VS but not needed
        }
        public void birdNest(float f)       //Overloads the birdNest method from parent class
        {
            Console.WriteLine("zzzzz at " + f);
        }
        public float Volume     //Volume property is encapsulated in Penguin class but has global scope
        {
            get { return volume; }
        }
    }
}
