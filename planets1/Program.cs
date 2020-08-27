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
        public static void planetSearchOptionsHandling(Gui menu, List<Planet> planets, int type)
        {
            Console.Clear();
            menu.printPlanetSearchOptions();


            int userInputPlanetSearch = int.Parse(Console.ReadLine());

            switch (userInputPlanetSearch)                                              // switch on PlanetSearchOptions Greater, Lower or Equal
            {

                case 1:
                    userInputPlanetSearch = int.Parse(Console.ReadLine());
                    for (int i = 0; i < planets.Count; i++)
                    {
                        switch (type)
                        {
                            case Planet.MASS:
                                if (planets[i].Mass > userInputPlanetSearch)
                                {
                                    Console.WriteLine(planets[i].toString());

                                }

                                break;

                            case Planet.DIAMETER:
                                if (planets[i].Diameter > userInputPlanetSearch)
                                {
                                    Console.WriteLine(planets[i].toString());

                                }

                                break;
                        }
                      
                    }

                    break;

            }
        }
        public static void planetSearchHandling(Gui menu, List<Planet> planets)
        {
            Console.Clear();

            menu.printPlanetSearch();

            int userInputPlanetSearch = int.Parse(Console.ReadLine());

            planetSearchOptionsHandling(menu, planets, userInputPlanetSearch);



            Thread.Sleep(2000);
            Console.Clear();
            menu.printMenu();
        }

        public static void initPlanets(List<Planet> planets)
        {
            Planet Mercury = new Planet("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, "No");
            planets.Add(Mercury);
            Planet Venus = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, "No");
            planets.Add(Venus);
            Planet Earth = new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, "No");
            planets.Add(Earth);
            Planet Mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, "No");
            planets.Add(Mars);
            Planet Jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, "Yes");
            planets.Add(Jupiter);
            Planet Saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, "Yes");
            planets.Add(Saturn);
            Planet Uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, "Yes");
            planets.Add(Uranus);
            Planet Neptune = new Planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, "Yes");
            planets.Add(Neptune);
            Planet Pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -255, 5, "No");
            planets.Add(Pluto);
        }

        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>();
            Gui menu = new Gui();

            initPlanets(planets);

            menu.printMenu();


            bool start = false;

            while (!start)
            {
                int userInput = int.Parse(Console.ReadLine());


                switch (userInput) // swtich show planets, search criteria for planets and exit
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
                        planetSearchHandling(menu, planets);

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
