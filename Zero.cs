using System;

namespace VehicleCustomization
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.Write($"The {MainColor} Zero drives past. ");
            Console.WriteLine("Zoooooom! Zeeerrrooooo!");
        }
    }
}