using System;

namespace VehicleCustomization
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "blue",
                MaximumOccupancy = "2",
                BatteryKWh = 1300.45
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "silver",
                MaximumOccupancy = "4",
                BatteryKWh = 9000.99
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "red",
                MaximumOccupancy = "6",
                FuelCapacity = 30.3
            };
            Ram model1500 = new Ram()
            {
                MainColor = "black",
                MaximumOccupancy = "5",
                FuelCapacity = 10
            };

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            mx410.Drive();
            mx410.Turn("around");
            mx410.Stop();
            model1500.Drive();
            model1500.Turn("upside-down");
            model1500.Stop();
        }
    }
}
