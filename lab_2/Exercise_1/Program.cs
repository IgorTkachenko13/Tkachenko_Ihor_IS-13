using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDimensionalArray arr = new OneDimensionalArray(); 

            arr.IntroduceNumOfElement();

            Console.WriteLine("Створення першого масиву:");
            int[] array1 = new int[arr.NumberOfElement];
            array1 = arr.CreateArray(arr.NumberOfElement);

            Console.WriteLine("Створення другого масиву:");
            int[] array2 = new int[arr.NumberOfElement];
            array2 = arr.CreateArray(arr.NumberOfElement);


            int[] resArray = new int[arr.NumberOfElement];
            bool needClose = false;
            do
            {
                switch (arr.ChoiceOperation())
                {
                    case 1:
                        arr.ShowArray(array1, arr.NumberOfElement);
                        break;
                    case 2:
                        arr.ShowArray(array2, arr.NumberOfElement);
                        break;
                    case 3:
                        resArray = arr.AddArray(array1, array2, arr.NumberOfElement);
                        Console.WriteLine("\nРезультуючий масив: ");
                        arr.ShowArray(resArray, arr.NumberOfElement);
                        break;
                    case 4:
                        resArray = arr.SubtractArray(array1, array2, arr.NumberOfElement);
                        Console.WriteLine("\nРезультуючий масив: ");
                        arr.ShowArray(resArray, arr.NumberOfElement);
                        break;
                    case 5:
                        resArray = arr.MultArray(array1, array2, arr.NumberOfElement);
                        Console.WriteLine("\nРезультуючий масив: ");
                        arr.ShowArray(resArray, arr.NumberOfElement);
                        break;
                    case 6:
                        needClose = true;
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.WriteLine(new string('-', 70));
            } while (!needClose);
            

        }
    }
}
