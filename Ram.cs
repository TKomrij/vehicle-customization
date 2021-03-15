using System;

namespace VehicleCustomization
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            this.CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.Write($"The {MainColor} Ram drives past. ");
            Console.WriteLine("Zoooooom! Rammmmmmmm!");
        }
    }
}