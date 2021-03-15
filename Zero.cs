using System;

namespace VehicleCustomization
{
    public class Zero : Vehicle, IElectric  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            this.CurrentChargePercentage = 100;
        }

        public int CurrentChargePercentage { get; set; }

        public override void Drive()
        {
            Console.Write($"The {MainColor} Zero drives past. ");
            Console.WriteLine("Zoooooom! Zeeerrrooooo!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero turns {direction} and heads down the road.");
        }
    }
}