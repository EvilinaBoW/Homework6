using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1.1
            double x = -2.2, y = -6;
            if (x > 0 && y < 0)
                Console.WriteLine("Точка лежит в четвертой четверти");
            else
                Console.WriteLine("Точка НЕ лежит в четвертой четверти");

            // task 1.2
            x = 5.3; y = 3;
            if (x > 0 && y < 0)
                Console.WriteLine("Точка лежит в четвертой четверти");
            else
                Console.WriteLine("Точка НЕ лежит в четвертой четверти");

            // task 1.3
            x = -0.8; y = -4;
            if (x > 0 && y < 0)
                Console.WriteLine("Точка лежит в четвертой четверти");
            else
                Console.WriteLine("Точка НЕ лежит в четвертой четверти");

            // task 2.1
            double a = 3, b = 5, c = 4;
            double minSide = Math.Min(Math.Min(a, b), c);
            double squareArea = minSide * minSide;
            double p = (a + b + c) / 2;
            double triangleArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника: {triangleArea:F4}, Площадь квадрата: {squareArea:F4}");
            if (triangleArea > squareArea)
                Console.WriteLine("Площадь треугольника больше");
            else if (Math.Abs(triangleArea - squareArea) < 0.0001)
                Console.WriteLine("Площади равны");
            else
                Console.WriteLine("Площадь квадрата больше");

            // task 2.2
            a = 3; b = 8; c = 11;
            minSide = Math.Min(Math.Min(a, b), c);
            squareArea = minSide * minSide;
            p = (a + b + c) / 2;
            triangleArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника: {triangleArea:F4}, Площадь квадрата: {squareArea:F4}");
            if (triangleArea > squareArea)
                Console.WriteLine("Площадь треугольника больше");
            else if (Math.Abs(triangleArea - squareArea) < 0.0001)
                Console.WriteLine("Площади равны");
            else
                Console.WriteLine("Площадь квадрата больше");

            // task 2.3
            a = 9; b = 9; c = 9;
            minSide = Math.Min(Math.Min(a, b), c);
            squareArea = minSide * minSide;
            p = (a + b + c) / 2;
            triangleArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника: {triangleArea:F4}, Площадь квадрата: {squareArea:F4}");
            if (triangleArea > squareArea)
                Console.WriteLine("Площадь треугольника больше");
            else if (Math.Abs(triangleArea - squareArea) < 0.0001)
                Console.WriteLine("Площади равны");
            else
                Console.WriteLine("Площадь квадрата больше");

            // task 3.1
            x = 9; y = 2;
            if (x > 0 && y > 0)
                Console.WriteLine("Точка лежит в первой четверти");
            else
                Console.WriteLine("Точка НЕ лежит в первой четверти");

            // task 3.2
            x = 7; y = 3;
            if (x > 0 && y > 0)
                Console.WriteLine("Точка лежит в первой четверти");
            else
                Console.WriteLine("Точка НЕ лежит в первой четверти");

            // task 3.3
            x = 0.1; y = 4;
            if (x > 0 && y > 0)
                Console.WriteLine("Точка лежит в первой четверти");
            else
                Console.WriteLine("Точка НЕ лежит в первой четверти");

            // task 4.1
            x = 5; y = -4;
            double eps = 0.001;
            double expectedY = Math.Abs(x) <= 2 ? x * x : 4;
            if (Math.Abs(expectedY - y) < eps)
                Console.WriteLine("Точка лежит на кривой");
            else
                Console.WriteLine("Точка НЕ лежит на кривой");

            // task 4.2
            x = 1; y = 6;
            expectedY = Math.Abs(x) <= 2 ? x * x : 4;
            if (Math.Abs(expectedY - y) < eps)
                Console.WriteLine("Точка лежит на кривой");
            else
                Console.WriteLine("Точка НЕ лежит на кривой");

            // task 4.3
            x = 1; y = -1;
            expectedY = Math.Abs(x) <= 2 ? x * x : 4;
            if (Math.Abs(expectedY - y) < eps)
                Console.WriteLine("Точка лежит на кривой");
            else
                Console.WriteLine("Точка НЕ лежит на кривой");

            // task 5.1
            double phi = 30, lambda = 121;
            string hemisphereNS = phi >= 0 ? "Северное" : "Южное";
            string hemisphereEW = lambda >= 0 ? "Восточное" : "Западное";
            Console.WriteLine($"Полушарие: {hemisphereNS}, {hemisphereEW}");

            // task 5.2
            phi = -15; lambda = 50;
            hemisphereNS = phi >= 0 ? "Северное" : "Южное";
            hemisphereEW = lambda >= 0 ? "Восточное" : "Западное";
            Console.WriteLine($"Полушарие: {hemisphereNS}, {hemisphereEW}");

            // task 5.3
            phi = 87; lambda = 223;
            hemisphereNS = phi >= 0 ? "Северное" : "Южное";
            hemisphereEW = lambda >= 0 ? "Восточное" : "Западное";
            Console.WriteLine($"Полушарие: {hemisphereNS}, {hemisphereEW}");

            // task 6.1
            a = 3; b = 3.5; c = 1.5;
            if (Math.Abs(a - b) < 0.0001 && Math.Abs(b - c) < 0.0001)
                Console.WriteLine("Треугольник равносторонний");
            else
            {
                double[] sides = { a, b, c };
                Array.Sort(sides);
                a = sides[0]; b = sides[1]; c = sides[2];
                if (Math.Abs((a * a + b * b) - c * c) < 0.0001)
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник простой");
            }

            // task 6.2
            a = 3; b = 6.55; c = 6.55;
            if (Math.Abs(a - b) < 0.0001 && Math.Abs(b - c) < 0.0001)
                Console.WriteLine("Треугольник равносторонний");
            else
            {
                double[] sides = { a, b, c };
                Array.Sort(sides);
                a = sides[0]; b = sides[1]; c = sides[2];
                if (Math.Abs((a * a + b * b) - c * c) < 0.0001)
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник простой");
            }

            // task 6.3
            a = 0.9; b = 0.9; c = 0.9;
            if (Math.Abs(a - b) < 0.0001 && Math.Abs(b - c) < 0.0001)
                Console.WriteLine("Треугольник равносторонний");
            else
            {
                double[] sides = { a, b, c };
                Array.Sort(sides);
                a = sides[0]; b = sides[1]; c = sides[2];
                if (Math.Abs((a * a + b * b) - c * c) < 0.0001)
                    Console.WriteLine("Треугольник прямоугольный");
                else
                    Console.WriteLine("Треугольник простой");
            }

            // task 7.1
            a = 13; b = -3.5;
            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                a = -a; b = -b;
                Console.WriteLine($"Разные знаки, новые значения: a={a}, b={b}");
            }
            else
            {
                a = 0; b = 0;
                Console.WriteLine($"Одинаковые знаки, новые значения: a={a}, b={b}");
            }

            // task 7.2
            a = 5.8; b = 37;
            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                a = -a; b = -b;
                Console.WriteLine($"Разные знаки, новые значения: a={a}, b={b}");
            }
            else
            {
                a = 0; b = 0;
                Console.WriteLine($"Одинаковые знаки, новые значения: a={a}, b={b}");
            }

            // task 7.3
            a = 8; b = -15;
            if ((a > 0 && b < 0) || (a < 0 && b > 0))
            {
                a = -a; b = -b;
                Console.WriteLine($"Разные знаки, новые значения: a={a}, b={b}");
            }
            else
            {
                a = 0; b = 0;
                Console.WriteLine($"Одинаковые знаки, новые значения: a={a}, b={b}");
            }

            // task 8.1
            a = 15; b = 13; c = -33;
            double min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Набор 1: a={a}, b={b}, c={c}, Минимальное: {min}");

            // task 8.2
            a = -38; b = 25; c = 12;
            min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Набор 2: a={a}, b={b}, c={c}, Минимальное: {min}");

            // task 8.3
            a = 22; b = -1; c = -33;
            min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Набор 3: a={a}, b={b}, c={c}, Минимальное: {min}");

            // task 9.1
            a = 10; b = 34; c = 65;
            int binaryNumber = Convert.ToInt32("1101011", 2);
            Console.WriteLine($"Набор 1: a={a}, b={b}, c={c}, Бинарное число: {binaryNumber}");
            if (a > binaryNumber) Console.WriteLine($"a={a} больше {binaryNumber}");
            if (b > binaryNumber) Console.WriteLine($"b={b} больше {binaryNumber}");
            if (c > binaryNumber) Console.WriteLine($"c={c} больше {binaryNumber}");
            if (a <= binaryNumber && b <= binaryNumber && c <= binaryNumber)
                Console.WriteLine("Нет чисел больше бинарного числа");

            // task 9.2
            a = 76; b = 18; c = 55;
            Console.WriteLine($"Набор 2: a={a}, b={b}, c={c}, Бинарное число: {binaryNumber}");
            if (a > binaryNumber) Console.WriteLine($"a={a} больше {binaryNumber}");
            if (b > binaryNumber) Console.WriteLine($"b={b} больше {binaryNumber}");
            if (c > binaryNumber) Console.WriteLine($"c={c} больше {binaryNumber}");
            if (a <= binaryNumber && b <= binaryNumber && c <= binaryNumber)
                Console.WriteLine("Нет чисел больше бинарного числа");

            // task 9.3
            a = 81; b = 75; c = 20;
            Console.WriteLine($"Набор 3: a={a}, b={b}, c={c}, Бинарное число: {binaryNumber}");
            if (a > binaryNumber) Console.WriteLine($"a={a} больше {binaryNumber}");
            if (b > binaryNumber) Console.WriteLine($"b={b} больше {binaryNumber}");
            if (c > binaryNumber) Console.WriteLine($"c={c} больше {binaryNumber}");
            if (a <= binaryNumber && b <= binaryNumber && c <= binaryNumber)
                Console.WriteLine("Нет чисел больше бинарного числа");

            // task 10.1
            int a10 = Convert.ToInt32("10", 8);
            int b10 = Convert.ToInt32("34", 8);
            int c10 = Convert.ToInt32("65", 8);
            int max = Math.Max(Math.Max(a10, b10), c10);
            Console.WriteLine($"Набор 1: a={a10}(10), b={b10}(10), c={c10}(10), Наибольшее: {max}(10)");

            // task 10.2
            a10 = Convert.ToInt32("76", 8);
            b10 = Convert.ToInt32("5", 8);
            c10 = Convert.ToInt32("55", 8);
            max = Math.Max(Math.Max(a10, b10), c10);
            Console.WriteLine($"Набор 2: a={a10}(10), b={b10}(10), c={c10}(10), Наибольшее: {max}(10)");

            // task 10.3
            a10 = Convert.ToInt32("11", 8);
            b10 = Convert.ToInt32("75", 8);
            c10 = Convert.ToInt32("20", 8);
            max = Math.Max(Math.Max(a10, b10), c10);
            Console.WriteLine($"Набор 3: a={a10}(10), b={b10}(10), c={c10}(10), Наибольшее: {max}(10)");

            // task 11.1
            a10 = Convert.ToInt32("A", 16);
            b10 = Convert.ToInt32("22", 16);
            c10 = Convert.ToInt32("41", 16);
            min = Math.Min(Math.Min(a10, b10), c10);
            Console.WriteLine($"Набор 1: a={a10}(10), b={b10}(10), c={c10}(10), Наименьшее: {min}(10)");

            // task 11.2
            a10 = Convert.ToInt32("4C", 16);
            b10 = Convert.ToInt32("5", 16);
            c10 = Convert.ToInt32("37", 16);
            min = Math.Min(Math.Min(a10, b10), c10);
            Console.WriteLine($"Набор 2: a={a10}(10), b={b10}(10), c={c10}(10), Наименьшее: {min}(10)");

            // task 11.3
            a10 = Convert.ToInt32("B", 16);
            b10 = Convert.ToInt32("4B", 16);
            c10 = Convert.ToInt32("14", 16);
            min = Math.Min(Math.Min(a10, b10), c10);
            Console.WriteLine($"Набор 3: a={a10}(10), b={b10}(10), c={c10}(10), Наименьшее: {min}(10)");

            Console.ReadKey();
        }
    }
}
