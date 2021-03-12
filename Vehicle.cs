using System;

namespace VehicleCustomization
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.Write($"The {MainColor} Ram drives past. ");
            Console.WriteLine("Vrooom!");
        }
    }
}
