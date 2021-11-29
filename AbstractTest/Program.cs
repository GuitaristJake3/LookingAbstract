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
            Console.WriteLine("The emperor starts with volume " + emperor.Volume);
            emperor.birdCall();
            Console.WriteLine("The emperor now has volume " + emperor.Volume);
            //This implements polymorphism of birdNest function
            emperor.birdNest();     //Calls base version
            emperor.birdNest(10f);      //Calls the overloaded version
            Console.ReadLine();
        }
    }
}
