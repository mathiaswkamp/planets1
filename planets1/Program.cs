using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planets1
{

    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();

            menu.printMenu();

            Planet Mercury = new Planet("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, "No");     // create a planet object of the class planet 
            Planet Venus = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, "No");      // create a planet object of the class planet 
            Planet Earth = new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, "No");            // create a planet object of the class planet
            Planet Mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, "No");             // create a planet object of the class planet
            Planet Jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, "Yes");     // create a planet object of the class planet
            Planet Saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10.747, 9.7, -140, 62, "Yes");      // create a planet object of the class planet
            Planet Uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.589, 6.8, -195, 27, "Yes");    // create a planet object of the class planet    
            Planet Neptune = new Planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, "Yes");     // create a planet object of the class planet
            Planet Pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -255, 5, "No");      // create a planet object of the class planet

            List<Planet> Planets = new List<Planet>();                                                          // creates a list 
            Planets =  Planet.Planets;                                                                          // puts the planets into the list

            
           
            //Planets.ForEach(o => Console.WriteLine($"{o.Name} : mass : {o.Mass}(1024kg) diameter : {o.Diameter}(km) dencity : {o.Dencity}(kg/m3) gravity {o.Gravity}(m/s2) rotation period :{o.RotationPeriod}hrs length of day : {o.LengthOfDay}hrs distance from sun : {o.DistanceFromSun}(106km) orbital period : {o.OrbitalPeriod}days orbital velocity : {o.OrbitalVelocity}(km/s) mean temperature : {o.MeanTemperature}celcius  number of moons : {o.NumberOfMoons} ring system : {o.RingSysytem}"));    //prints out the list of Planets

            //int count = Planets.Count();                                                                        // creates an int that counts how many planets that are in the list
            //Console.WriteLine($"There is : {count} Planets");

            //Console.WriteLine("press any key to see list of planets with a Mean Temperature below 0");
            //Console.ReadKey();
            //Console.Clear();

            //List<Planet> temperatureBelowZero = new List<Planet>();                                             // creates a new list 

            //temperatureBelowZero.Add(Mars);                                                                     // adds the following planets to it
            //temperatureBelowZero.Add(Jupiter);
            //temperatureBelowZero.Add(Saturn);
            //temperatureBelowZero.Add(Uranus);
            //temperatureBelowZero.Add(Neptune);
            //temperatureBelowZero.Add(Pluto);

            //temperatureBelowZero.ForEach(o => Console.WriteLine($"{o.Name} : mass : {o.Mass}(1024kg) diameter : {o.Diameter}(km) dencity : {o.Dencity}(kg/m3) gravity {o.Gravity}(m/s2) rotation period :{o.RotationPeriod}hrs length of day : {o.LengthOfDay}hrs distance from sun : {o.DistanceFromSun}(106km) orbital period : {o.OrbitalPeriod}days orbital velocity : {o.OrbitalVelocity}(km/s) mean temperature : {o.MeanTemperature}celcius  number of moons : {o.NumberOfMoons} ring system : {o.RingSysytem}"));


            //Console.WriteLine("press any key to see list of planets with a diameter between 10000km and 50000km");
            //Console.ReadKey();
            //Console.Clear();
            //List<Planet> diameterBetween10kto50k = new List<Planet>();                                           // creates a new list
            //diameterBetween10kto50k.Add(Venus);                                                                  // add plantes to list
            //diameterBetween10kto50k.Add(Earth);

            //diameterBetween10kto50k.ForEach(o => Console.WriteLine($"{o.Name} : mass : {o.Mass}(1024kg) diameter : {o.Diameter}(km) dencity : {o.Dencity}(kg/m3) gravity {o.Gravity}(m/s2) rotation period :{o.RotationPeriod}hrs length of day : {o.LengthOfDay}hrs distance from sun : {o.DistanceFromSun}(106km) orbital period : {o.OrbitalPeriod}days orbital velocity : {o.OrbitalVelocity}(km/s) mean temperature : {o.MeanTemperature}celcius  number of moons : {o.NumberOfMoons} ring system : {o.RingSysytem}"));


            //Console.WriteLine("press any key to remove all planets from the list ");
            //Console.Clear();
            //Console.ReadKey();

            //Planets.Clear();                                                                                     // clear all 3 lists of planets
            //temperatureBelowZero.Clear();
            //diameterBetween10kto50k.Clear();

            //Console.WriteLine("the 3 lists of planets has been cleared ");

            //diameterBetween10kto50k.ForEach(o => Console.WriteLine($"{o.Name} : mass : {o.Mass}(1024kg) diameter : {o.Diameter}(km) dencity : {o.Dencity}(kg/m3) gravity {o.Gravity}(m/s2) rotation period :{o.RotationPeriod}hrs length of day : {o.LengthOfDay}hrs distance from sun : {o.DistanceFromSun}(106km) orbital period : {o.OrbitalPeriod}days orbital velocity : {o.OrbitalVelocity}(km/s) mean temperature : {o.MeanTemperature}celcius  number of moons : {o.NumberOfMoons} ring system : {o.RingSysytem}"));   // this line is to check if the lists is cleared
        }
    }
}
