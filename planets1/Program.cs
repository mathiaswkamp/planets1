using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace planets1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>();
            Gui menu = new Gui();
            SolarSystem.initPlanets(planets);

            menu.printMenu();


            bool start = false;

            while (!start)
            {
                int userInput = int.Parse(Console.ReadLine());


                switch (userInput) // switch show planets, search criteria for planets and exit
                {
                    case 1:
                        Console.Clear();
                        int count = planets.Count();
                        Console.WriteLine($"There is : {count} Planets");
                        Thread.Sleep(2000);
                        Console.Clear();
                        menu.printMenu();

                        break;

                    case 2:
                        Console.Clear();
                        SolarSystem.planetSearchHandling(menu, planets);

                        break;


                    case 3:

                        start = true;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number ");
                        Thread.Sleep(2000);
                        Console.Clear();
                        menu.printMenu();
                        break;
                }
            }
        }
    }
}