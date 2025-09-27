using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1: Проверка, лежит ли точка в четвертой четверти (x > 0, y < 0)
            Console.WriteLine("=== Задача 1: Проверка четвертой четверти ===");
            double[,] points1 = { { -2.2, -6 }, { 5.3, 3 }, { -0.8, -4 } };
            for (int i = 0; i < points1.GetLength(0); i++)
            {
                double x = points1[i, 0], y = points1[i, 1];
                Console.WriteLine($"Точка {i + 1}: A({x}, {y})");
                if (x > 0 && y < 0)
                    Console.WriteLine("Точка лежит в четвертой четверти");
                else
                    Console.WriteLine("Точка НЕ лежит в четвертой четверти");
            }
            Console.WriteLine();

            // Задача 2: Сравнение площади треугольника и квадрата
            Console.WriteLine("=== Задача 2: Сравнение площади треугольника и квадрата ===");
            double[,] triangles2 = { { 3, 5, 4 }, { 3, 8, 11 }, { 9, 9, 9 } };
            for (int i = 0; i < triangles2.GetLength(0); i++)
            {
                double a = triangles2[i, 0], b = triangles2[i, 1], c = triangles2[i, 2];
                double minSide = Math.Min(Math.Min(a, b), c); // Наименьшая сторона
                double squareArea = minSide * minSide; // Площадь квадрата
                double p = (a + b + c) / 2; // Полупериметр
                double triangleArea = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Площадь треугольника
                Console.WriteLine($"Треугольник {i + 1}: a={a}, b={b}, c={c}");
                Console.WriteLine($"Площадь треугольника: {triangleArea:F4}, Площадь квадрата: {squareArea:F4}");
                if (triangleArea > squareArea)
                    Console.WriteLine("Площадь треугольника больше");
                else if (Math.Abs(triangleArea - squareArea) < 0.0001)
                    Console.WriteLine("Площади равны");
                else
                    Console.WriteLine("Площадь квадрата больше");
            }
            Console.WriteLine();

            // Задача 3: Проверка, лежат ли точки в первой четверти (x > 0, y > 0)
            Console.WriteLine("=== Задача 3: Проверка первой четверти ===");
            double[,] points3 = { { 9, 2 }, { 7, 3 }, { 0.1, 4 } };
            for (int i = 0; i < points3.GetLength(0); i++)
            {
                double x = points3[i, 0], y = points3[i, 1];
                Console.WriteLine($"Точка {i + 1}: A({x}, {y})");
                if (x > 0 && y > 0)
                    Console.WriteLine("Точка лежит в первой четверти");
                else
                    Console.WriteLine("Точка НЕ лежит в первой четверти");
            }
            Console.WriteLine();

            // Задача 4: Проверка, лежит ли точка на кривой y = x² при |x| ≤ 2, y = 4 при |x| > 2
            Console.WriteLine("=== Задача 4: Проверка точки на кривой ===");
            double[,] points4 = { { 5, -4 }, { 1, 6 }, { 1, -1 } };
            double eps = 0.001;
            for (int i = 0; i < points4.GetLength(0); i++)
            {
                double x = points4[i, 0], y = points4[i, 1];
                double expectedY = Math.Abs(x) <= 2 ? x * x : 4;
                Console.WriteLine($"Точка {i + 1}: B({x}, {y})");
                if (Math.Abs(expectedY - y) < eps)
                    Console.WriteLine("Точка лежит на кривой");
                else
                    Console.WriteLine("Точка НЕ лежит на кривой");
            }
            Console.WriteLine();

            // Задача 5
            Console.WriteLine("=== Задача 5: Определение полушария ===");
            double[,] coords5 = { { 30, 121 }, { -15, 50 }, { 87, 223 } };
            for (int i = 0; i < coords5.GetLength(0); i++)
            {
                double phi = coords5[i, 0], lambda = coords5[i, 1];
                string hemisphereNS = phi >= 0 ? "Северное" : "Южное";
                string hemisphereEW = lambda >= 0 ? "Восточное" : "Западное";
                Console.WriteLine($"Точка {i + 1}: A(φ={phi}, λ={lambda})");
                Console.WriteLine($"Полушарие: {hemisphereNS}, {hemisphereEW}");
            }
            Console.WriteLine();

            // Задача 6
            Console.WriteLine("=== Задача 6: Вид треугольника ===");
            double[,] triangles6 = { { 3, 3.5, 1.5 }, { 3, 6.55, 6.55 }, { 0.9, 0.9, 0.9 } };
            for (int i = 0; i < triangles6.GetLength(0); i++)
            {
                double a = triangles6[i, 0], b = triangles6[i, 1], c = triangles6[i, 2];
                if (Math.Abs(a - b) < 0.0001 && Math.Abs(b - c) < 0.0001)
                {
                    Console.WriteLine($"Треугольник {i + 1}: равносторонний");
                }
                else
                {
                    double[] sides = { a, b, c };
                    Array.Sort(sides);
                    a = sides[0]; b = sides[1]; c = sides[2];
                    if (Math.Abs((a * a + b * b) - c * c) < 0.0001)
                        Console.WriteLine($"Треугольник {i + 1}: прямоугольный");
                    else
                        Console.WriteLine($"Треугольник {i + 1}: простой");
                }
            }
            Console.WriteLine();

            // Задача 7
            Console.WriteLine("=== Задача 7: Изменение знаков чисел ===");
            double[,] sets7 = { { 13, -3.5 }, { 5.8, 37 }, { 8, -15 } };
            for (int i = 0; i < sets7.GetLength(0); i++)
            {
                double a = sets7[i, 0], b = sets7[i, 1];
                Console.WriteLine($"Набор {i + 1}: a={a}, b={b}");
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
            }
            Console.WriteLine();

            // Задача 8
            Console.WriteLine("=== Задача 8: Наименьшее число ===");
            double[,] sets8 = { { 15, 13, -33 }, { -38, 25, 12 }, { 22, -1, -33 } };
            for (int i = 0; i < sets8.GetLength(0); i++)
            {
                double a = sets8[i, 0], b = sets8[i, 1], c = sets8[i, 2];
                double min = Math.Min(Math.Min(a, b), c);
                Console.WriteLine($"Набор {i + 1}: a={a}, b={b}, c={c}, Минимальное: {min}");
            }
            Console.WriteLine();

            // Задача 9
            Console.WriteLine("=== Задача 9: Сравнение с двоичным числом 1101011 ===");
            int binaryNumber = Convert.ToInt32("1101011", 2); // 107 в десятичной системе
            double[,] sets9 = { { 10, 34, 65 }, { 76, 18, 55 }, { 81, 75, 20 } };
            for (int i = 0; i < sets9.GetLength(0); i++)
            {
                double a = sets9[i, 0], b = sets9[i, 1], c = sets9[i, 2];
                Console.WriteLine($"Набор {i + 1}: a={a}, b={b}, c={c}, Бинарное число: {binaryNumber}");
                if (a > binaryNumber) Console.WriteLine($"a={a} больше {binaryNumber}");
                if (b > binaryNumber) Console.WriteLine($"b={b} больше {binaryNumber}");
                if (c > binaryNumber) Console.WriteLine($"c={c} больше {binaryNumber}");
                if (a <= binaryNumber && b <= binaryNumber && c <= binaryNumber)
                    Console.WriteLine("Нет чисел больше бинарного числа");
            }
            Console.WriteLine();

            // Задача 10
            Console.WriteLine("=== Задача 10: Наибольшее число (восьмеричная система) ===");
            string[,] sets10 = { { "10", "34", "65" }, { "76", "5", "55" }, { "11", "75", "20" } };
            for (int i = 0; i < sets10.GetLength(0); i++)
            {
                int a = Convert.ToInt32(sets10[i, 0], 8);
                int b = Convert.ToInt32(sets10[i, 1], 8);
                int c = Convert.ToInt32(sets10[i, 2], 8);
                int max = Math.Max(Math.Max(a, b), c);
                Console.WriteLine($"Набор {i + 1}: a={a}(10), b={b}(10), c={c}(10), Наибольшее: {max}(10)");
            }
            Console.WriteLine();

            // Задача 11
            Console.WriteLine("=== Задача 11: Наименьшее число (шестнадцатеричная система) ===");
            string[,] sets11 = { { "A", "22", "41" }, { "4C", "5", "37" }, { "B", "4B", "14" } };
            for (int i = 0; i < sets11.GetLength(0); i++)
            {
                int a = Convert.ToInt32(sets11[i, 0], 16);
                int b = Convert.ToInt32(sets11[i, 1], 16);
                int c = Convert.ToInt32(sets11[i, 2], 16);
                int min = Math.Min(Math.Min(a, b), c);
                Console.WriteLine($"Набор {i + 1}: a={a}(10), b={b}(10), c={c}(10), Наименьшее: {min}(10)");
            }

            Console.ReadKey();
        }
    }
}
