using System;
using System.Linq;

/* 
 * Дана послідовність непустих рядків A. 
 * Отримати послідовність символів, кожен елемент якої є початковим символом відповідного рядка з A.
 * Порядок символів повинен бути зворотним по відношенню до порядку елементів вихідної послідовності.
 */

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "future", "teaching", "student", "hello", "world" };
            var firstSymbol = (from str in A select str[0]).Reverse();
            foreach (char ch in firstSymbol)
                Console.Write(ch + " ");

            //Delay
            Console.ReadKey();
        }
    }
}
