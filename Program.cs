using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение радиуса: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значенрие x0 и x1: ");
            double x0 = Convert.ToDouble(Console.ReadLine()), x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение для y0 и y1: ");
            double y0 = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine());

            double resultLength = Circle.GetLength(radius), resultSquare = Circle.GetSquare(radius);
            bool resultBeLong = Circle.GetBelong(radius, x0, x, y0, y);

            Console.WriteLine("Длина окружности равна: {0:F2}. \nПлощадь окружности равна: {1:F2}. \n", resultLength, resultSquare);
            Console.WriteLine(resultBeLong ? "Nочка принадлежит кругу" : "Точка не принадлежит кругу");

            Console.ReadKey();
        }
    }
}
