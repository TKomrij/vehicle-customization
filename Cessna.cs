using System;

namespace VehicleCustomization
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.Write($"The {MainColor} Cessna drives past. ");
            Console.WriteLine("Zoooooom! Cessssnnnnaaaa!");
        }
    }
}