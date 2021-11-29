using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    abstract class Bird
    {
        /// <summary>
        /// Bird is an abstract class
        /// When we want to use it we will need to implement the abstract method birdCall
        /// But we will be able to use the non abstract method birdNest
        /// </summary>
        public abstract void birdCall();        //birdCall is an abstract method which does not yet exist
        public void birdNest()
        {
            Console.WriteLine("zzzzz");
        }
    }
}
