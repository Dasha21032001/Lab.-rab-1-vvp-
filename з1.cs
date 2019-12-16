using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите первую сторону :");
            a = Convert.ToInt32(Console.ReadLine());//Ввод первой стороны
            Console.WriteLine("Введите вторую сторону :");
            b = Convert.ToInt32(Console.ReadLine());//Ввод второй стороны
            double S = a * b;//Площадь прямоугольника
            double P = 2*(a + b);//Периметр
            Console.WriteLine("Площадь прямоугольника:" + S);// Вывод площади прямоугольника
            Console.WriteLine("Периметр прямоугольника:" + P);// Вывод периметра прямоугольника
            Console.ReadLine();
        }
    }
}


