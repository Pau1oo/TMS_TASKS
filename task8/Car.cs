using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    abstract class Car : IVehicle
    {
        public int FuelValue;
        public int FuelRate;

        public Car(int initialFuel, int fuelRate)
        {
            FuelValue = initialFuel;
            FuelRate = fuelRate;
        }

        public void Drive(int distance)
        {
            while (distance > 0)
            {
                if(FuelValue == 0)
                {
                    Console.WriteLine("Введите кол-во литров для заправки: ");
                    int.TryParse(Console.ReadLine(), out int fuel);
                    Refuel(fuel);
                    Console.Clear();
                }
                Console.WriteLine($"Расстояние: {distance} км | Кол-во топлива: {FuelValue} л");
                distance -= 100 / FuelRate;
                FuelValue--;
                Thread.Sleep(700);
                Console.Clear();
            }
            Console.WriteLine("Вы прибыли до пункта назначения.");
            Console.ReadKey();
        }

        public bool Refuel(int fuelValue)
        {
            FuelValue += fuelValue;
            return true;
        }
    }
}
