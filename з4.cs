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
            if (a!=0)
                if (b!=0)
                  {
                    Console.WriteLine("Подлежит выводу");
                  }
                  else
                  {
                    Console.WriteLine(" Не подлежит выводу");
                  }
            double S = Math.Pow(a, 2) + Math.Pow(b, 2);//Сумма квадратов первого и второго числа
            double L = Math.Pow(a, 2) - Math.Pow(b, 2);//Разность квадратов первого и второго числа
            double H = Math.Pow(a, 2) * Math.Pow(b, 2);//Произведение квадратов первого и второго числа
            double D = Math.Pow(a, 2) / Math.Pow(b, 2);//Частное квадратов первого и второго числа
            Console.WriteLine("Сумма квадратов первого и второго числа:" + S);// Вывод суммы квадратов первого и второго числа
            Console.WriteLine("Разность квадратов первого и второго числа:" + L);// Вывод разности квадратов первого и второго числа
            Console.WriteLine("Произведение квадратов первого и второго числа:" + H);// Вывод произведения квадратов первого и второго числа
            Console.WriteLine("Частное квадратов первого и второго числа:" + D);// Вывод частного квадратов первого и второго числа
            Console.ReadLine();
        }

    }
}
