using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Array
    {
        private int ManualCreateElement()
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("(Виклик методу \"ManualCreateElement\") ");
                Console.ResetColor();
            }
            int newEl = Convert.ToInt32(Console.ReadLine());
            Element El = new Element(newEl);
            int el = El.element;
            return el;
        }

        private int AutoCreateElement()
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Виклик методу \"AutoCreateElement\"");
                Console.ResetColor();
            }
            Random rnd = new Random();
            int newEl = rnd.Next(-100, 100);
            Element El = new Element(newEl);
            int el = El.element;
            return el;
        }

        public int[] AutoCreateArray(int numberOfElements)
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Виклик методу \"AutoCreateArray\"");
                Console.ResetColor();
            }
            int [] array = new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = AutoCreateElement();
            }
            return array;
        }

        public int[] ManualCreateArray(int numberOfElement)
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Виклик методу \"ManualCreateArray\"");
                Console.ResetColor();
            }
            int [] array = new int[numberOfElement];
            for (int i = 0; i < numberOfElement; i++)
            {
                Console.Write($"Введiть {i + 1}-е значення масиву  ");
                int element = ManualCreateElement(); 
                array[i] = element;
            }
            return array;
        }

        
        
    }
}
