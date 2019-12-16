using System;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pi = Math.PI;
            double d,L;
            Console.WriteLine("Введите диаметр");
           
            d = Convert.ToInt32(Console.ReadLine());//Ввод диаметра
            L = pi * d;// Длина окружности
            Console.WriteLine("Длина окружности:" + L);//Вывод длины окружности
            Console.ReadLine();
        }
    }
}
