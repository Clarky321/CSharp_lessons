using System;

/*
 * Переменные C#
 * 
 * Объявление (создание) переменных
 * 
 * Инициализация переменных
 * 
 * Присвоение значения переменной (помещение данных)
*/

namespace _3.variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Тип данных имя_переменной;

            //int a, b;

            int a = 5;
            //a = 5;

            int b = 6;
            //b = 6;

            bool variable = false;
            bool variable2 = true;

            double variable3 = 1.33;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(variable);
            Console.WriteLine(variable2);

            Console.WriteLine(variable3);

            char variable4 = '#';
            Console.WriteLine(variable4);

            string variable5 = "какой то текст";
            Console.WriteLine(variable5);

            Console.ReadLine();
        }
    }
}