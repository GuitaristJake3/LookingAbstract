using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    class Program
    {

        static void Main(string[] args)
        {
            //Bird emperor = new Bird();      Bird is abstract so it can't exist
            Penguin emperor = new Penguin();
            emperor.birdCall();
            //This implements polymorphism of birdNest function
            emperor.birdNest();     //Calls base version
            emperor.birdNest(10f);      //Calls the overloaded version
            Console.ReadLine();
        }
    }
}
