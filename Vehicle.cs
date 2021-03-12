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

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} vehicle turns {direction}");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop");
        }
    }
}
