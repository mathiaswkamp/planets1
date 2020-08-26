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

            Gui menu = new Gui();

            menu.printMenu();

            Planet Mercury = new Planet("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, "No");     
            Planet Venus = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, "No");      
            Planet Earth = new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, "No");           
            Planet Mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, "No");           
            Planet Jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, "Yes");     
            Planet Saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, "Yes");     
            Planet Uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, "Yes");   
            Planet Neptune = new Planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, "Yes");    
            Planet Pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -255, 5, "No");      

            List<Planet> Planets = new List<Planet>();                                                          
            Planets = Planet.Planets;                                                                          

            bool start = false;

            while (!start)
            {
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        int count = Planets.Count();
                        Console.WriteLine($"There is : {count} Planets");
                        Thread.Sleep(2000);
                        Console.Clear();
                        menu.printMenu();

                        break;

                    case 2:
                        Console.Clear();

                        for (int i = 0; i < Planets.Count; i++)
                        {
                            if (Planets[i].MeanTemperature < 0)
                            {
                                Console.WriteLine($"Planet:  { Planets[i].Name}  Temperature: { Planets[i].MeanTemperature} ");
                            }
                        }
                        Thread.Sleep(2000);
                        Console.Clear();
                        menu.printMenu();
                        break;


                    case 3:
                        Console.Clear();

                        for (int i = 0; i < Planets.Count; i++)
                        {
                            if (Planets[i].Diameter > 10000 && Planets[i].Diameter < 50000)
                            {
                                Console.WriteLine($"Planet:  { Planets[i].Name}  Diameter: { Planets[i].Diameter} ");
                            }
                        }
                        Thread.Sleep(2000);
                        Console.Clear();
                        menu.printMenu();

                        break;

                    case 4:

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
