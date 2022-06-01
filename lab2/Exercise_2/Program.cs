using System;

namespace Exercise_2
{
   
    class Program
    {
        public static int CarrierChoise()
        {
            Console.WriteLine("Виберіть перевізника:" +
                "\n1)Перевiзник 1 -> Tom" +
                "\n2)Перевiзник 2 -> Bob");
            int res = Convert.ToInt32(Console.ReadLine());
            return res;
        }

        static void Main(string[] args)
        {
            Port port = new Port();

            Carrier carrierOne = port.CreateCarrier("Tom");
            #region Створення кораблів
            Ship ship11 = carrierOne.CreateShip("Ship11", 2000, 400, 100, 1995);
            Ship ship12 = carrierOne.CreateShip("Ship12", 3000, 600, 140, 1999);
            Ship ship13 = carrierOne.CreateShip("Ship13", 1000, 200, 60, 1987);
            Ship ship14 = carrierOne.CreateShip("Ship14", 4000, 800, 170, 2008);
            #endregion

            Carrier carrierTwo = port.CreateCarrier("Bob");
            #region Створення кораблів
            Ship ship21 = carrierTwo.CreateShip("Ship21", 4000, 800, 200, 1998);
            Ship ship22 = carrierTwo.CreateShip("Ship22", 6000, 1200, 280, 2002);
            Ship ship23 = carrierTwo.CreateShip("Ship23", 2000, 400, 120, 1990);
            Ship ship24 = carrierTwo.CreateShip("Ship24", 8000, 1600, 340, 2014);
            #endregion


            int numOfCarrier = CarrierChoise();
            Console.WriteLine("Введiть бажану операцiю:" +
                    "\n1) Вiдсортувати за витратами палива" +
                    "\n2) Загальна вантажопiдйомнiсть" +
                    "\n3) Загальна мiсткiсть" +
                    "\n4) Пошук корабля за роком" +
                    "\n5) Вихiд");
            bool bl = true;
            do
            {
                Console.WriteLine();
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1: port.SortFuelConsumption(numOfCarrier); break;
                    case 2: port.AllLoadCapacity(numOfCarrier); break;
                    case 3: port.AllCapacity(numOfCarrier); break;
                    case 4: port.FindsShip(numOfCarrier); break;
                    case 5: bl = false; break;
                    default:
                        Console.WriteLine("Операція введена невiрно!!!");
                        break;
                }
            }
            while (bl);
            Console.ReadKey();
        }
    }
}
