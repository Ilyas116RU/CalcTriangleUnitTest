using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
        Console.WriteLine("Введите длины сторон треугольника:");

            double a = InputSide("a");
            double b = InputSide("b");
            double c = InputSide("c");

            // Проверка на корректность сторон
            if (!IsValidTriangle(a, b, c))
            {
                Console.WriteLine("Невозможно образовать треугольник с заданными сторонами.");
                return;
            }

            // Определение вида треугольника
            string triangleType = GetTriangleType(a, b, c);
            Console.WriteLine($"Треугольник: {triangleType}");

            // Вычисление площади треугольника
            double area = GetTriangleArea(a, b, c);
            Console.WriteLine($"Площадь треугольника: {area}");

            Console.ReadLine();
        }

        // Ввод стороны треугольника
        static double InputSide(string sideName)
        {
            double side;
            do
            {
                Console.Write($"Введите длину стороны {sideName}: ");
            } while (!double.TryParse(Console.ReadLine(), out side) || side <= 0);

            return side;
        }

        // Проверка корректности сторон треугольника
        static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Определение вида треугольника
        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Равносторонний";
            }
            else if (a == b || b == c || a == c)
            {
                return "Равнобедренный";
            }
            else
            {
                return "Разносторонний";
            }
        }

        // Вычисление площади треугольника по формуле Герона
        static double GetTriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2; // Полупериметр
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

    }

 }
