using System.Collections.Generic;

namespace planets1
{
    class Planet
    {
        static List<Planet> planets = new List<Planet>();      //creates a static list of planet class


        private string name;                                   //property of name

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double mass;                                   //property of mass

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        private double diameter;                              //property of diameter

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        private double dencity;                               //property of dencity

        public double Dencity
        {
            get { return dencity; }
            set { dencity = value; }
        }

        private double gravity;                              // property of gravity

        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }

        private double rotationperiod;                      //property of rotation period

        public double RotationPeriod                        
        {
            get { return rotationperiod; }
            set { rotationperiod = value; }
        }

        private double lengthOfDay;                         //property of length of day

        public double LengthOfDay
        {
            get { return lengthOfDay; }
            set { lengthOfDay = value; }
        }

        private double distanceFromSun;                     //property of distance from sun

        public double DistanceFromSun
        {
            get { return distanceFromSun; }
            set { distanceFromSun = value; }
        }

        private double orbitalPeriod;                       //property orbital period

        public double OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }

        private double orbitalVelocity;                     //property of orbital velocity

        public double OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }

        private double meanTemperature;

        public double MeanTemperature                       //property of mean temperature
        {
            get { return meanTemperature; }
            set { meanTemperature = value; }
        }

        private double numberofMoons;                       // property of number of moons

        public double NumberOfMoons             
        {
            get { return numberofMoons; }
            set { numberofMoons = value; }
        }

        private string ringSystem;                          // property of ring system

        public string RingSysytem
        {
            get { return ringSystem; }
            set { ringSystem = value; }
        }

        internal static List<Planet> Planets { get => planets; set => planets = value; } // internal static property of planets allows me to create a list


        // here is my constructor taking all values with it upon creation of a planet item

        public Planet(string name, double mass, double diameter, double dencity, double gravity, double rotationperiod, double lengthofday, double distancefromsun, double orbitalperiod, double orbitalvelocity, double meantemperature, double numberofmoons, string ringsystem)
        {
            this.name = name;
            this.mass = mass;
            this.diameter = diameter;
            this.dencity = dencity;
            this.gravity = gravity;
            this.rotationperiod = rotationperiod;
            this.lengthOfDay = lengthofday;
            this.distanceFromSun = distancefromsun;
            this.orbitalPeriod = orbitalperiod;
            this.orbitalVelocity = orbitalvelocity;
            this.meanTemperature = meantemperature;
            this.numberofMoons = numberofmoons;
            this.ringSystem = ringsystem;

            planets.Add(this);

        }


        
    }
}