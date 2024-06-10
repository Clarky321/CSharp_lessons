using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 3. Написать простой конвертер валют
 *    (без возможности динамического выбора валюты пользователем).
 *    Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.
*/

namespace _1._3.homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double UsdToRub = 66.29;
            double UsdToUah = 27.24;
            double USD;

            Console.WriteLine("Введите сумму в USD");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD в RUB = " + USD * UsdToRub);
            Console.WriteLine(USD + " USD в UAH = " + USD * UsdToUah);

            Console.ReadLine();
        }
    }
}
