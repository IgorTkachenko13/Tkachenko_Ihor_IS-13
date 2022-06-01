using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Port
    {
        List<Carrier> CarrierList = new List<Carrier>();

        public Carrier CreateCarrier(string carrierName)
        {
            Carrier carrier = new Carrier(carrierName);
            CarrierList.Add(carrier);
            return carrier;
        }

        public void SortFuelConsumption(int num)
        {
            CarrierList[num - 1].SortFuelConsumption();
        }
        public int AllLoadCapacity(int num)
        {
            int res = CarrierList[num - 1].AllLoadCapacity();
            Console.WriteLine($"Загальна вантожопiдйомнiсть у перевiзника {CarrierList[num - 1].CarrierName}: {res}т");
            return res;
        }
        public int AllCapacity(int num)
        {
            int res = CarrierList[num - 1].AllCapacity();
            Console.WriteLine($"Загальна вантожопiдйомнiсть перевiзника {CarrierList[num - 1].CarrierName}: {res} куб.м");
            return res;
        }
        public void FindsShip(int num)
        {
            CarrierList[num - 1].FindsShip();
        }

    }
}
