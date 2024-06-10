using System;
using System.Globalization;

/*
 * конвертация строки
 * parse и tryparse
*/

namespace _6.conversion_parse_and_tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = "5,9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = double.Parse(str);
            */

            /*
            string str = "5dawfawf";

            try
            {
                //double d = Convert.ToDouble(str);
                int a = int.Parse(str);
                Console.WriteLine("Усмешная конвертация");
            }
            catch  (Exception)
            {
                Console.WriteLine("Ошибка при конвертации");
            }
            */

            string str = "6323 dawgaws";

            int a;

            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }

            Console.ReadLine();
        }
    }
}