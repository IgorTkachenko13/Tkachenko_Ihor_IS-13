using System;
using Newtonsoft.Json;
using System.Collections.Generic;

/*
 * Порахувати кількість букв у рядку і створити словник у вигляді {‘літера’: ‘кількість літер у рядку’}.
 * Назви ключів в словнику записати у алфавітному порядку. Вхідний рядок : 'helloworld'. 
 * Вихідний результат: {'e': 1, 'd': 1, 'e': 1, 'h': 1, 'l': 3, 'o': 2, 'r': 1, 'w': 1}
*/

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "helloworld";
            Dictionary<char, int> map = new();
            var sortedMap = new SortedDictionary<char, int>(map);
            foreach (char c in text)
            {
                if (sortedMap.ContainsKey(c))
                    sortedMap[c]++;
                else
                    sortedMap[c] = 1;
            }

            foreach (var pair in sortedMap)
                Console.WriteLine($"{pair.Key}: {pair.Value}");

            //Delay
            Console.ReadKey();
        }
    }
}
