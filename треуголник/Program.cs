using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace треуголник
{
    internal class Program
    {

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите длины трех сторон треугольника:");

            Console.Write("Сторона A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (IsIsoscelesTriangle(a, b, c))
            {
                Console.WriteLine("Этот треугольник равнобедренный.");
            }
            else
            {
                Console.WriteLine("Этот треугольник не является равнобедренным.");
            }

            //Это я сделал для того чтобы консоль не закрывалась и было возможно прочитать ответ консоли
            Console.WriteLine("Нажмите пожалуйста любую клавишу для закрытия консоли!");


            Console.ReadLine();

        }

        static bool IsIsoscelesTriangle(double a, double b, double c)
        {
            return a == b || b == c || a == c;
        }
    }
}