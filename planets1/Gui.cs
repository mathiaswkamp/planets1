using System;

namespace planets1
{
    class Gui


    {
        public void printMenu()
        {
            System.Console.WriteLine("1. Show count of Planets");
            System.Console.WriteLine("2. Search for planets");
            System.Console.WriteLine("3. exit");
        }

        public void printPlanetSearch()
        {
            Console.WriteLine(Planet.toStringPlanetSearch());
        }

        public void printPlanetSearchOptions()
        {
            Console.WriteLine("1. Greater than :");
            Console.WriteLine("1. Lower than :");
            Console.WriteLine("1. Equals to :");
        }
    }
}