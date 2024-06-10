using System;

// Ввод данных в консоль

namespace _4.data_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;

            data = Console.ReadLine();
            Console.WriteLine("Привет " + data + "," + " как ваши дела?");

            Console.ReadLine();
        }
    }
}