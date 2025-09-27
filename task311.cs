using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1
            Console.WriteLine("=== Задача 1: Прямоугольный треугольник ===");
            double[,] triangles1 = { { 3, 3.5, -2.1 }, { 21, 6.55, 0.1 }, { -9, -3.7, -0.1 } };
            for (int i = 0; i < triangles1.GetLength(0); i++)
            {
                double a = Math.Abs(triangles1[i, 0]); 
                double b = Math.Abs(triangles1[i, 1]);
                double c = Math.Abs(triangles1[i, 2]);

                double[] sides = { a, b, c };
                Array.Sort(sides);
                a = sides[0]; b = sides[1]; c = sides[2]; 

                if (Math.Abs((a * a + b * b) - c * c) < 0.0001)
                    Console.WriteLine($"Треугольник {i + 1} прямоугольный");
                else
                    Console.WriteLine($"Треугольник {i + 1} не прямоугольный");
            }
            Console.WriteLine();

            // Задача 2
            Console.WriteLine("=== Задача 2: Определение сезона ===");
            Console.WriteLine("Введите номер месяца (1-12):");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Сезон: Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Сезон: Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Сезон: Осень");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Сезон: Зима");
                    break;
                default:
                    Console.WriteLine("Некорректный номер месяца");
                    break;
            }
            Console.WriteLine();

            // Задача 3
            Console.WriteLine("=== Задача 3: Увеличение чисел или обнуление ===");
            double[,] sets3 = { { -3, 3.5, 0.1 }, { 58, 27, -87 }, { -8, -35, -42 } };
            for (int i = 0; i < sets3.GetLength(0); i++)
            {
                double A = sets3[i, 0], B = sets3[i, 1], C = sets3[i, 2];
                Console.WriteLine($"Набор {i + 1}: A={A}, B={B}, C={C}");
                if (A + B + C > 0)
                {
                    A *= 2; B *= 2; C *= 2;
                    Console.WriteLine($"Сумма > 0, новые значения: A={A}, B={B}, C={C}");
                }
                else
                {
                    A = 0; B = 0; C = 0;
                    Console.WriteLine($"Сумма <= 0, новые значения: A={A}, B={B}, C={C}");
                }
            }
            Console.WriteLine();

            // Задача 4
            Console.WriteLine("=== Задача 4: Ближайшая точка к началу координат ===");
            double[,] points = { { 2, 2, -4, 0 }, { 8, 9, 12, 1 }, { -3.5, 0.9, 2, 3 } };
            for (int i = 0; i < points.GetLength(0); i++)
            {
                double x0 = points[i, 0], y0 = points[i, 1], x1 = points[i, 2], y1 = points[i, 3];
                double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
                double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);

                Console.WriteLine($"Набор {i + 1}:");
                Console.WriteLine($"Расстояние от A({x0},{y0}) до O(0,0): {distanceA:F4}");
                Console.WriteLine($"Расстояние от B({x1},{y1}) до O(0,0): {distanceB:F4}");
                if (Math.Abs(distanceA - distanceB) < 0.0001)
                    Console.WriteLine("Точки A и B на одинаковом расстоянии от начала координат");
                else if (distanceA < distanceB)
                    Console.WriteLine("Точка A ближе к началу координат");
                else
                    Console.WriteLine("Точка B ближе к началу координат");
            }
            Console.WriteLine();

            // Задача 5
            Console.WriteLine("=== Задача 5: Равнобедренный треугольник ===");
            double[,] triangles5 = { { 3, 3.5, 1.1 }, { 3, 6.55, 6.55 }, { 0.9, 0.9, 0.9 } };
            for (int i = 0; i < triangles5.GetLength(0); i++)
            {
                double a = triangles5[i, 0], b = triangles5[i, 1], c = triangles5[i, 2];
                if (Math.Abs(a - b) < 0.0001 || Math.Abs(b - c) < 0.0001 || Math.Abs(a - c) < 0.0001)
                    Console.WriteLine($"Треугольник {i + 1} равнобедренный");
                else
                    Console.WriteLine($"Треугольник {i + 1} не равнобедренный");
            }
            Console.WriteLine();

            // Задача 6: 
            Console.WriteLine("=== Задача 6: Стоимость разговоров ===");
            double[,] operators = { { 50, 10 }, { 45, 8 }, { 55, 12 } };
            Console.WriteLine("Введите время разговоров в будни (минуты):");
            double weekdayTime = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите время разговоров в выходные (минуты):");
            double weekendTime = double.Parse(Console.ReadLine());
            for (int i = 0; i < operators.GetLength(0); i++)
            {
                double costPerMinute = operators[i, 0] / 100;
                double discount = operators[i, 1] / 100;
                double weekdayCost = weekdayTime * costPerMinute;
                double weekendCost = weekendTime * costPerMinute * (1 - discount);
                double totalCost = weekdayCost + weekendCost;
                Console.WriteLine($"Оператор {i + 1}: Стоимость = {totalCost:F2} руб.");
            }
            Console.WriteLine();

            // Задача 7
            Console.WriteLine("=== Задача 7: Поздравительная открытка ===");
            string[] themes = { "Новогодние", "С днем рождения", "С днем защитника отечества" };
            Console.WriteLine("Введите номер темы (1-3):");
            int theme = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вариант (a, b, c):");
            char variant = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (theme >= 1 && theme <= 3 && (variant == 'a' || variant == 'b' || variant == 'c'))
                Console.WriteLine($"Открытка: {themes[theme - 1]}, вариант {variant}");
            else
                Console.WriteLine("Некорректный номер темы или варианта");
            Console.WriteLine();

            // Задача 8
            Console.WriteLine("=== Задача 8: Изменение знаков чисел ===");
            double[,] sets8 = { { -3, 3.5 }, { 5.8, 2.7 }, { 8, -3.5 } };
            for (int i = 0; i < sets8.GetLength(0); i++)
            {
                double a = sets8[i, 0], b = sets8[i, 1];
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

            // Задача 9: Поиск наименьшего числа
            Console.WriteLine("=== Задача 9: Наименьшее число ===");
            double[,] sets9 = { { 45, 13, -23 }, { -31, 65, 12 }, { 52, -1, -33 } };
            for (int i = 0; i < sets9.GetLength(0); i++)
            {
                double a = sets9[i, 0], b = sets9[i, 1], c = sets9[i, 2];
                double min = Math.Min(Math.Min(a, b), c);
                Console.WriteLine($"Набор {i + 1}: a={a}, b={b}, c={c}, Минимальное: {min}");
            }
            Console.WriteLine();

            // Задача 10
            Console.WriteLine("=== Задача 10: Число больше среднего по модулю ===");
            double[,] sets10 = { { 3.2, 7, 0.5 }, { 2.3, 3, 2.5 }, { 23, -34, 89.5 } };
            for (int i = 0; i < sets10.GetLength(0); i++)
            {
                double x = sets10[i, 0], y = sets10[i, 1], z = sets10[i, 2];
                double avg = (Math.Abs(x) + Math.Abs(y) + Math.Abs(z)) / 3;
                Console.WriteLine($"Набор {i + 1}: x={x}, y={y}, z={z}, Среднее арифметическое модулей: {avg:F4}");
                if (Math.Abs(x) > avg)
                    Console.WriteLine($"Число x={x} (модуль {Math.Abs(x):F4}) больше среднего");
                else if (Math.Abs(y) > avg)
                    Console.WriteLine($"Число y={y} (модуль {Math.Abs(y):F4}) больше среднего");
                else if (Math.Abs(z) > avg)
                    Console.WriteLine($"Число z={z} (модуль {Math.Abs(z):F4}) больше среднего");
                else
                    Console.WriteLine("Нет числа, модуль которого больше среднего");
            }

            Console.ReadKey();
        }
    }
}
