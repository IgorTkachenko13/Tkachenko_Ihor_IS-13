using System;
using System.Collections.Generic;
using System.IO;

/*
 * Написати програму, яка обчислює число голосних і приголосних букв у файлі. 
 * Шлях до файлу передавати як аргумент у функцію ReadFile(). Вміст текстового файлу заноситься в список символів.
 * Кількість голосних і приголосних букв визначається проходом по списку. Передбачити метод, вхідним параметром якого є список символів.
 * Метод обчислює кількість голосних і приголосних букв.
*/

namespace Exercise1
{
    internal class Program
    {
        public static string ReadFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }

        static void Main(string[] args)
        {
            string str = ReadFile("D:\\2 семестр\\Програмування\\Лаби\\лаба №3\\Ex1.TXT");
            string stringOfSymbol = str.Replace(" ", "");
            char[] charArray = stringOfSymbol.ToCharArray();

            List<char> list = new List<char>();
            foreach (char ch in charArray)
                list.Add(ch);

            int numOfVowelLetter = 0;
            int numOfConsonantLetter = 0;
            int numOfSymbol = 0;
            for (int i = 0; i < list.Count; i++)
            {
                bool isVowelLetter;
                {
                    isVowelLetter = list[i] == 'e' || list[i] == 'y' || list[i] == 'u' || list[i] == 'i' || list[i] == 'o' || list[i] == 'a' ||
                    list[i] == 'E' || list[i] == 'Y' || list[i] == 'U' || list[i] == 'I' || list[i] == 'O' || list[i] == 'A';
                }
                bool isConsonantLetter;
                {
                    isConsonantLetter = list[i] == 'q' || list[i] == 'w' || list[i] == 'r' || list[i] == 't' || list[i] == 'p' || list[i] == 's' ||
                        list[i] == 'd' || list[i] == 'f' || list[i] == 'g' || list[i] == 'h' || list[i] == 'j' || list[i] == 'k' || list[i] == 'l' ||
                        list[i] == 'z' || list[i] == 'x' || list[i] == 'c' || list[i] == 'v' || list[i] == 'b' || list[i] == 'n' || list[i] == 'm' ||
                        list[i] == 'Q' || list[i] == 'W' || list[i] == 'R' || list[i] == 'T' || list[i] == 'P' || list[i] == 'S' ||
                        list[i] == 'D' || list[i] == 'F' || list[i] == 'G' || list[i] == 'H' || list[i] == 'J' || list[i] == 'K' || list[i] == 'L' ||
                        list[i] == 'Z' || list[i] == 'X' || list[i] == 'C' || list[i] == 'V' || list[i] == 'B' || list[i] == 'N' || list[i] == 'M';
                }
                if (isVowelLetter)
                    numOfVowelLetter++;
                else if (isConsonantLetter)
                    numOfConsonantLetter++;
                else
                    numOfSymbol++;
            }

            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");

            Console.WriteLine();
            Console.WriteLine($"Кiлькiсть голосних: {numOfVowelLetter} букв");
            Console.WriteLine($"Кiлькicть приголосних: {numOfConsonantLetter} букв");
            Console.WriteLine($"Кiлькiсть символiв: {numOfSymbol}");

            //Delay
            Console.ReadKey();
        }
    }
}
