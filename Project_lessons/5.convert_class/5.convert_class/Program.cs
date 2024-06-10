using System;

/*
 * конвертация строки
 * класс Convert
*/

namespace _5.convert_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = "5";
            string str2 = "2";
            Console.WriteLine(str + str2);

            int a = 5;
            int b = 2;
            Console.WriteLine(a + b);

            // Класс Convert

            string str3 = "5";
            int variable = Convert.ToInt32(str3); // конвертировали символ со значением 5, в число со значением 5
            */

            string str;

            int a, b;

            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            int result = a + b;

            Console.WriteLine("Сумма чисел = " + result);

            Console.ReadLine();
        }
    }
}
