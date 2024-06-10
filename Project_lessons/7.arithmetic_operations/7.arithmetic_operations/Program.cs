using System;

/*
 * ОПЕРАТОРЫ
 * 
 * Арифметические операции с числами
 * 
 * Операнд
 * делится на:
 * - унарные
 * - бинарные
 * - тернарные
*/

namespace _7.arithmetic_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            int c = 5;

            //int result = a + b;
            //int result = a - b;
            //int result = a * b;
            //double result = (double)a / b; // приведение типов

            //int result = a % b; // остаток по модулю

            int result = a + b * c;

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
