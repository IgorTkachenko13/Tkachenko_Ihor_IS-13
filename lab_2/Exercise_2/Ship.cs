using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Ship
    {
        public string ShipName { get; private set; }
        public int Capacity { get; private set; }
        public int LoadCapacity { get; private set; }
        public int FuelConsumption { get; private set; }
        public int GraduationYear { get; private set; }


        public void EnterName()
        {
            Console.Write("Введiть назву корабля -> ");
            ShipName = Console.ReadLine();
        }
        public void EnterCapacity()
        {
            Console.Write("Введiть мiсткiсть корабля (куб м.) -> ");
            Capacity = Convert.ToInt32(Console.ReadLine());
        }
        public void EnterLoadCapacity()
        {
            Console.Write("Введiть вантажопiдйомнiсть корабля (т) -> ");
            LoadCapacity = Convert.ToInt32(Console.ReadLine());
        }
        public void EnterFuelConsumption()
        {
            Console.Write("Введiть витрати палива корабля за год (л/год) -> ");
            FuelConsumption = Convert.ToInt32(Console.ReadLine());
        }
        public void EnterGraduationYear()
        {
            Console.Write("Введiть рiк випуску корабля -> ");
            GraduationYear = Convert.ToInt32(Console.ReadLine());
        }


        public Ship(string shipName, int capacity, int loadCapacity, int fuelConsumption, int graduationYear)
        {
            ShipName = shipName;
            Capacity = capacity;
            LoadCapacity = loadCapacity;
            FuelConsumption = fuelConsumption;
            GraduationYear = graduationYear;
        }
        public Ship()
        {
        }

        public override string ToString()
        {
            return string.Format($"{ShipName}({GraduationYear}): мiсткiсть {Capacity} куб.м, вантажопiдйомнiсть {LoadCapacity}т, витрати палива {FuelConsumption} л/год ");
        }
    }
}
