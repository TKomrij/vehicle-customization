using System;

namespace VehicleCustomization
{
    public class Tesla : Vehicle, IElectric //Electric motor
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            this.CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.Write($"The {MainColor} Tesla drives past. ");
            Console.WriteLine("Zoooooom! Tesssllllaaaa!");
        }

        public override void Stop()
        {
            Console.WriteLine("The Tesla gently rolls to a stop after cutting off a policeman.");
        }



    }
}