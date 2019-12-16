using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());//Ввод первого числа
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());//Ввод второго числа
            if (a != 0)
                if (b != 0)
                {
                    Console.WriteLine("Подлежит выводу");
                }
                else
                {
                    Console.WriteLine(" Не подлежит выводу");
                }
            double S = Math.Abs(a * a )+Math.Abs(b * b);//Сумма квадратов  модулей первого и второго числа
            double L = Math.Abs(a * a)-Math.Abs(b * b);//Разность квадратов модулей первого и второго числа
            double H = Math.Abs(a * a) * Math.Abs(b * b);//Произведение квадратов модулей первого и второго числа
            double D = Math.Abs(a * a) / Math.Abs(b * b);//Частное квадратов модулей первого и второго числа
            Console.WriteLine("Сумма квадратов модулей первого и второго числа:" + S);// Вывод суммы квадратов модулей первого и второго числа
            Console.WriteLine("Разность квадратов модулей первого и второго числа:" + L);// Вывод разности квадратов модулей первого и второго числа
            Console.WriteLine("Произведение квадратов модулей первого и второго числа:" + H);// Вывод произведения квадратов модулей первого и второго числа
            Console.WriteLine("Частное квадратов модулей первого и второго числа:" + D);// Вывод частного квадратов модулей первого и второго числа
            Console.ReadLine();
        }

    }
}
