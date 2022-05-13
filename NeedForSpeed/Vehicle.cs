using System;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public virtual double FuelConsumption => DefaultFuelConsumption;
        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption;
            Console.WriteLine($"{this.GetType().Name} is driven {kilometers} km with {this.Fuel} fuel.");
        }
    }
}