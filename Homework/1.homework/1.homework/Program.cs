using System;

/*
 * 1. Написать программу, вычисляющую среднее арифметическое двух чисел.
*/

namespace _1.homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Введите первое число:");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            secondValue = double.Parse(Console.ReadLine());


            double result = (firstValue + secondValue) / 2;

            Console.WriteLine("Среднее арифметическое двух числе = " + result);

            Console.ReadLine();
        }
    }
}