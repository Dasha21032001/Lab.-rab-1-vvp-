using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите число а:");
            a = Convert.ToInt32(Console.ReadLine());//Ввод числа a
            Console.WriteLine("Введите число b:");
            b = Convert.ToInt32(Console.ReadLine());//Ввод числа b
            double S = (a+b)/2;//Среднее арифметическое
            Console.WriteLine("Среднее арифметическое:" + S);// Вывод среднего арифметического
            Console.ReadLine();
        }
    }
}
