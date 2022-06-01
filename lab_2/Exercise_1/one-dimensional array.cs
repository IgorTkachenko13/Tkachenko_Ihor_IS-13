using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class OneDimensionalArray
    {
        Array arr = new Array();
        
        public int NumberOfElement { get; private set; }

        public void IntroduceNumOfElement()
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("(Виклик методу \"IntroduceNumOfElement\") ");
                Console.ResetColor();
            }
            Console.Write("\nВведiть кiлькiсть елементiв у масивах -> ");
            NumberOfElement = Convert.ToInt32(Console.ReadLine());
        }

        private bool IsAutoCreate()
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("(Виклик методу \"IsAutoCreate\") ");
                Console.ResetColor();
            }
            Console.WriteLine("\nЧи бажаєте ви заповнити масив автоматично?\n1) Так\n2) Нi");
            bool i = true;
            bool isCorectInput = false;
            do
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    isCorectInput = true;
                    i = true;
                }
                else if (num == 2)
                {
                    isCorectInput = true;
                    i =  false;
                }
            }
            while (!isCorectInput);
            return i;
        }

        public int[] CreateArray(int numberOfElements)
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("(Виклик методу \"CreateAray\") ");
                Console.ResetColor();
            }
            int [] array = new int[numberOfElements];
            if (IsAutoCreate())
                array = arr.AutoCreateArray(numberOfElements);
            else
                array = arr.ManualCreateArray(numberOfElements);

            Console.WriteLine("Створений масив:");
            ShowArray(array, NumberOfElement);
            return array;
        }

        public int ChoiceOperation()
        {
            Console.WriteLine("Виберiть бажану операцiю:" +
                "\n1) Вивести перший масив" +
                "\n2) вивести другий масив" +
                "\n3) Додати масиви." +
                "\n4) Вiдняти масиви." +
                "\n5) Помножити масиви." +
                "\n6) Завершити виконання.");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void ShowArray(int[] array, int numberOfElement)
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Виклик методу \"ShowArray\"");
                Console.ResetColor();
            }
            for (int i = 0; i < numberOfElement; i++)
            {
                if (i + 1 == numberOfElement)
                    Console.WriteLine(array[i] + ".");
                else
                    Console.Write($"{array[i]}, ");
            }
        }

        public int[] AddArray(int[] array1, int[] array2, int numberOfElement)
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("(Виклик методу \"AddArray\") ");
                Console.ResetColor();
            }
            int[] result = new int[numberOfElement];
            for (int i = 0; i < numberOfElement; i++)
            {
                result[i] = array1[i] + array2[i];
            }
            return result;
        }
        public int[] SubtractArray(int[] array1, int[] array2, int numberOfElement)
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("(Виклик методу \"SubtractArray\") ");
                Console.ResetColor();
            }
            int[] result = new int[numberOfElement];
            for (int i = 0; i < numberOfElement; i++)
            {
                result[i] = array1[i] - array2[i];
            }
            return result;
        }
        public int[] MultArray(int[] array1, int[] array2, int numberOfElement)
        {
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("(Виклик методу \"MultArray\") ");
                Console.ResetColor();
            }
            int[] result = new int[numberOfElement];
            for (int i = 0; i < numberOfElement; i++)
            {
                result[i] = array1[i] * array2[i];
            }
            return result;
        }

    }
}
