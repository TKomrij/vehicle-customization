using System;

namespace VehicleCustomization
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            this.CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.Write($"The {MainColor} Cessna drives past. ");
            Console.WriteLine("Zoooooom! Cessssnnnnaaaa!");
        }

        public override void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop after rolling a mile down the runway");
        }
    }
}