using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    class Penguin : Bird, IBirdSong
    {
        /// <summary>
        /// Penugin class implements the Bird abstract class
        /// It overlaods the birdNest method of Bird class
        /// It overrides the abstract method birdCall of the Bird class
        /// It has a global accessor Property Volume which allows this value to be read outside of the class
        /// </summary>
        float m_Volume;       //This variable has class scope
        float m_Frequency;        //Warble frequncy
        public override void BirdCall()     //Overrides abstract method from parent
        {
            m_Volume = 27.3f;
            float lVolume = 2 * m_Volume;     //Local volume has only got method scope
            Console.WriteLine("Squaaark at " + lVolume);
            //throw new NotImplementedException();      This was put in by VS but not needed
        }
        public void BirdNest(float f)       //Overloads the birdNest method from parent class
        {
            Console.WriteLine("zzzzz at " + f);
        }
        /// <summary>
        /// Set the bird warble frequency
        /// </summary>
        /// <param name="f">Is the number of times the call will be repeated when the bird warbles</param>
        public void Frequency(float f)
        {
            m_Frequency = f;
        }
        /// <summary>
        /// Will repeat the bird call for the number of times set by the m_Frequency
        /// </summary>
        public void Warble()
        {
            float f = m_Frequency;
            while(f > 0)
            {
                BirdCall();
                f -= 0.5f;
            }
        }

        public float Volume     //Volume property is encapsulated in Penguin class but has global scope
        {
            get { return m_Volume; }
        }
    }
}
