using System.Collections.Generic;

namespace planets1
{
    class Planet
    {
        //static List<Planet> planets = new List<Planet>();    

         public const int  MASS = 1;
        public  const int DIAMETER = 2;

        private string name;                               
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double mass;        
        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        private double diameter;                        

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        private double dencity;                              
        public double Dencity
        {
            get { return dencity; }
            set { dencity = value; }
        }

        private double gravity;                             

        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }

        private double rotationperiod;                     

        public double RotationPeriod                        
        {
            get { return rotationperiod; }
            set { rotationperiod = value; }
        }

        private double lengthOfDay;                        
        public double LengthOfDay
        {
            get { return lengthOfDay; }
            set { lengthOfDay = value; }
        }

        private double distanceFromSun;                    

        public double DistanceFromSun
        {
            get { return distanceFromSun; }
            set { distanceFromSun = value; }
        }

        private double orbitalPeriod;                      
        public double OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }

        private double orbitalVelocity;                     

        public double OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }

        private double meanTemperature;

        public double MeanTemperature                     
        {
            get { return meanTemperature; }
            set { meanTemperature = value; }
        }

        private double numberofMoons;                      

        public double NumberOfMoons             
        {
            get { return numberofMoons; }
            set { numberofMoons = value; }
        }

        private string ringSystem;                        
        public string RingSysytem
        {
            get { return ringSystem; }
            set { ringSystem = value; }
        }

        //internal static List<Planet> Planets { get => planets; set => planets = value; } 

       

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


        }

        public string toString()
        {
            return Name + "\n\t" + 
                   mass + "\n\t" +
                   diameter + "\n\t";
        }

        public static string toStringPlanetSearch()
        {
            return MASS +": mass\n" +
                   DIAMETER+ ": diameter\n";
        }

        //todo public string toString
    }
}