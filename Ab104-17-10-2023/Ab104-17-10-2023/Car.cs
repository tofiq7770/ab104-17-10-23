using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_17_10_2023
{
    public class Car : IDrivable, IRefuellable
    {
        public double MileAge { get; private set; }
        public double Fuel { get; private set; }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }

        public Car(double fuel = 20, double tankCapacity = 40, double fuelConsumption = 10)
        {
            Fuel = fuel;
            TankCapacity = tankCapacity;
            FuelConsumption = fuelConsumption;
        }

        public bool Drive(double distance)
        {
            double fuelNeeded = distance / FuelConsumption;
            if (fuelNeeded <= Fuel)
            {
                MileAge += distance;
                Fuel -= fuelNeeded;
                return true;
            }
            return false;
        }

        public bool Refuel(double amount)
        {
            if (Fuel + amount <= TankCapacity)
            {
                Fuel += amount;
                return true;
            }
            return false;
        }
    }

}
