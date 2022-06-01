using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Carrier
    {
        public string CarrierName { get; private set; }
        public void EnterName(string carrierName)
        {
            Console.Write("Введiть назву корабля -> ");
            CarrierName = carrierName;
        }

        public List<Ship> ships = new List<Ship>();

        public Ship CreateShip()
        {
            Ship ship = new Ship();
            ships.Add(ship);
            ship.EnterName();
            ship.EnterCapacity();
            ship.EnterLoadCapacity();
            ship.EnterFuelConsumption();
            ship.EnterGraduationYear();
            return ship;
        }
        public Ship CreateShip(string shipName, int capacity, int loadCapacity, int fuelConsumption, int graduationYear)
        {
            Ship ship = new Ship(shipName, capacity, loadCapacity, fuelConsumption, graduationYear);
            ships.Add(ship);
            return ship;

        }


        public void SortFuelConsumption()
        {
            ships.Sort(delegate (Ship ship1, Ship ship2)
            { return ship1.FuelConsumption.CompareTo(ship2.FuelConsumption); });

            for (int i = 0; i < ships.Count; i++)
                Console.WriteLine(ships[i].ToString());
        }
        public int AllLoadCapacity()
        {
            int res = 0;
            for (int i = 0; i < ships.Count; i++)
                res += ships[i].LoadCapacity;
            return res;
        }
        public int AllCapacity()
        {
            int res = 0;
            for (int i = 0; i < ships.Count; i++)
            {
                res += ships[i].Capacity;
            }
            return res;
        }
        public void FindsShip()
        {
            Console.Write("Введiть мiнiмальний рiк: ");
            int minYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть максимальний рiк: ");
            int maxYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат пошуку: ");
            bool isSearchSuccessful = false;
            for (int i = 0; i < ships.Count; i++)
            {
                if ((minYear <= ships[i].GraduationYear) && (maxYear >= ships[i].GraduationYear))
                {
                    Console.WriteLine(ships[i].ToString());
                    isSearchSuccessful = true;
                }
            }
            if (!isSearchSuccessful)
            {
                Console.WriteLine("Корабля не знайдено!!!");
            }
        }

        public Carrier(string carrierName)
        {
            CarrierName = carrierName;
        }
        public Carrier()
        {

        }

        public override string ToString()
        {
            return string.Format($"Iм'я: {CarrierName}, к-сть кораблiв: {ships.Count}");
        }
    }
}
