using System;
using System.Collections.Generic;

namespace VehicleCustomization
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                BatteryKWh = 10.2,
                MainColor = "red",
                MaximumOccupancy = "5",
                CurrentChargePercentage = 10
            };
            Zero fx = new Zero()
            {
                BatteryKWh = 1000.4,
                MainColor = "silver",
                MaximumOccupancy = "4",
                CurrentChargePercentage = 50
            };
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 5983939.2,
                MainColor = "black",
                MaximumOccupancy = "2",
                CurrentChargePercentage = 80
            };

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram()
            {
                CurrentTankPercentage = 30,
                MainColor = "black",
                MaximumOccupancy = "4",
            };
            Cessna cessna150 = new Cessna()
            {
                CurrentTankPercentage = 10,
                MainColor = "white",
                MaximumOccupancy = "5",
            };

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}
