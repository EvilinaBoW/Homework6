using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1.1
            double a = 3, b = 3.5, c = 2.1;
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный.");
            }

            // task 1.2
            a = 21; b = 6.55; c = 0.1;
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный.");
            }

            // task 1.3
            a = 9; b = 3.7; c = 0.1;
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный.");
            }

            // task 2
            Console.WriteLine("Введите номер месяца ");
            string number = Console.ReadLine();
            string season;
            switch (number)
            {
                case "1":
                case "12":
                case "2":
                    season = "Зима";
                    break;
                case "3":
                case "4":
                case "5":
                    season = "Весна";
                    break;
                case "6":
                case "7":
                case "8":
                    season = "Лето";
                    break;
                case "9":
                case "10":
                case "11":
                    season = "Осень";
                    break;
                default:
                    season = "неверный ввод";
                    break;
            }
            Console.WriteLine(season);

            // task 3.1
            a = -3; b = 3.5; c = 0.1;
            if (a + b + c > 0)
            {
                a *= 2; b *= 2; c *= 2;
                Console.WriteLine($"Сумма > 0, новые значения: a={a}, b={b}, c={c}");
            }
            else
            {
                a = 0; b = 0; c = 0;
                Console.WriteLine($"Сумма <= 0, новые значения: a={a}, b={b}, c={c}");
            }

            // task 3.2
            a = 58; b = 27; c = -87;
            if (a + b + c > 0)
            {
                a *= 2; b *= 2; c *= 2;
                Console.WriteLine($"Сумма > 0, новые значения: a={a}, b={b}, c={c}");
            }
            else
            {
                a = 0; b = 0; c = 0;
                Console.WriteLine($"Сумма <= 0, новые значения: a={a}, b={b}, c={c}");
            }

            // task 3.3
            a = -8; b = -35; c = -42;
            if (a + b + c > 0)
            {
                a *= 2; b *= 2; c *= 2;
                Console.WriteLine($"Сумма > 0, новые значения: a={a}, b={b}, c={c}");
            }
            else
            {
                a = 0; b = 0; c = 0;
                Console.WriteLine($"Сумма <= 0, новые значения: a={a}, b={b}, c={c}");
            }

            // task 4.1
            double x0 = 2, y0 = 2, x1 = -4, y1 = 0;
            double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);
            if (Math.Abs(distanceA - distanceB) < 0.0001)
            {
                Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат");
            }
            else if (distanceA < distanceB)
            {
                Console.WriteLine("Точка A ближе к началу координат");
            }
            else
            {
                Console.WriteLine("Точка B ближе к началу координат");
            }
            Console.WriteLine($"Расстояние от A(0,0) до точки A({x0},{y0}): {distanceA:F4}");
            Console.WriteLine($"Расстояние от A(0,0) до точки B({x1},{y1}): {distanceB:F4}");

            // task 4.2
            x0 = 8; y0 = 9; x1 = 12; y1 = 1;
            distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            distanceB = Math.Sqrt(x1 * x1 + y1 * y1);
            if (Math.Abs(distanceA - distanceB) < 0.0001)
            {
                Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат");
            }
            else if (distanceA < distanceB)
            {
                Console.WriteLine("Точка A ближе к началу координат");
            }
            else
            {
                Console.WriteLine("Точка B ближе к началу координат");
            }
            Console.WriteLine($"Расстояние от A(0,0) до точки A({x0},{y0}): {distanceA:F4}");
            Console.WriteLine($"Расстояние от A(0,0) до точки B({x1},{y1}): {distanceB:F4}");

            // task 4.3
            x0 = -3.5; y0 = 0.9; x1 = 2; y1 = 3;
            distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            distanceB = Math.Sqrt(x1 * x1 + y1 * y1);
            if (Math.Abs(distanceA - distanceB) < 0.0001)
            {
                Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат");
            }
            else if (distanceA < distanceB)
            {
                Console.WriteLine("Точка A ближе к началу координат");
            }
            else
            {
                Console.WriteLine("Точка B ближе к началу координат");
            }
            Console.WriteLine($"Расстояние от A(0,0) до точки A({x0},{y0}): {distanceA:F4}");
            Console.WriteLine($"Расстояние от A(0,0) до точки B({x1},{y1}): {distanceB:F4}");

            // task 5.1
            a = 3; b = 3.5; c = 1.1;
            if (Math.Abs(a - b) < 0.0001 || Math.Abs(b - c) < 0.0001 || Math.Abs(a - c) < 0.0001)
                Console.WriteLine("Треугольник равнобедренный");
            else
                Console.WriteLine("Треугольник не равнобедренный");

            // task 5.2
            a = 3; b = 6.55; c = 6.55;
            if (Math.Abs(a - b) < 0.0001 || Math.Abs(b - c) < 0.0001 || Math.Abs(a - c) < 0.0001)
                Console.WriteLine("Треугольник равнобедренный");
            else
                Console.WriteLine("Треугольник не равнобедренный");

            // task 5.3
            a = 0.9; b = 0.9; c = 0.9;
            if (Math.Abs(a - b) < 0.0001 || Math.Abs(b - c) < 0.0001 || Math.Abs(a - c) < 0.0001)
                Console.WriteLine("Треугольник равнобедренный");
            else
                Console.WriteLine("Треугольник не равнобедренный");

            // task 6.1
            double costPerMinute = 0.50, discount = 0.10;
            Console.WriteLine("Введите время разговоров в будни (минуты):");
            double weekdayTime = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите время разговоров в выходные (минуты):");
            double weekendTime = double.Parse(Console.ReadLine());
            double weekdayCost = weekdayTime * costPerMinute;
            double weekendCost = weekendTime * costPerMinute * (1 - discount);
            double totalCost = weekdayCost + weekendCost;
            Console.WriteLine($"Оператор 1: Стоимость = {totalCost:F2} руб.");

            // task 6.2
            costPerMinute = 0.45; discount = 0.08;
            weekdayCost = weekdayTime * costPerMinute;
            weekendCost = weekendTime * costPerMinute * (1 - discount);
            totalCost = weekdayCost + weekendCost;
            Console.WriteLine($"Оператор 2: Стоимость = {totalCost:F2} руб.");

            // task 6.3
            costPerMinute = 0.55; discount = 0.12;
            weekdayCost = weekdayTime * costPerMinute;
            weekendCost = weekendTime * costPerMinute * (1 - discount);
            totalCost = weekdayCost + weekendCost;
            Console.WriteLine($"Оператор 3: Стоимость = {totalCost:F2} руб.");

            // task 7
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

            // task 8.1
            a = -3; b = 3.5;
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

            // task 8.2
            a = 5.8; b = 2.7;
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

            // task 8.3
            a = 8; b = -3.5;
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

            // task 9.1
            a = 45; b = 13; c = -23;
            double min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Набор 1: a={a}, b={b}, c={c}, Минимальное: {min}");

            // task 9.2
            a = -31; b = 65; c = 12;
            min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Набор 2: a={a}, b={b}, c={c}, Минимальное: {min}");

            // task 9.3
            a = 52; b = -1; c = -33;
            min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Набор 3: a={a}, b={b}, c={c}, Минимальное: {min}");

            // task 10.1
            a = 3.2; b = 7; c = 0.5;
            double avg = (Math.Abs(a) + Math.Abs(b) + Math.Abs(c)) / 3;
            Console.WriteLine($"Набор 1: a={a}, b={b}, c={c}, Среднее арифметическое модулей: {avg:F4}");
            if (Math.Abs(a) > avg)
                Console.WriteLine($"Число a={a} (модуль {Math.Abs(a):F4}) больше среднего");
            else if (Math.Abs(b) > avg)
                Console.WriteLine($"Число b={b} (модуль {Math.Abs(b):F4}) больше среднего");
            else if (Math.Abs(c) > avg)
                Console.WriteLine($"Число c={c} (модуль {Math.Abs(c):F4}) больше среднего");
            else
                Console.WriteLine("Нет числа, модуль которого больше среднего");

            // task 10.2
            a = 2.3; b = 3; c = 2.5;
            avg = (Math.Abs(a) + Math.Abs(b) + Math.Abs(c)) / 3;
            Console.WriteLine($"Набор 2: a={a}, b={b}, c={c}, Среднее арифметическое модулей: {avg:F4}");
            if (Math.Abs(a) > avg)
                Console.WriteLine($"Число a={a} (модуль {Math.Abs(a):F4}) больше среднего");
            else if (Math.Abs(b) > avg)
                Console.WriteLine($"Число b={b} (модуль {Math.Abs(b):F4}) больше среднего");
            else if (Math.Abs(c) > avg)
                Console.WriteLine($"Число c={c} (модуль {Math.Abs(c):F4}) больше среднего");
            else
                Console.WriteLine("Нет числа, модуль которого больше среднего");

            // task 10.3
            a = 23; b = -34; c = 89.5;
            avg = (Math.Abs(a) + Math.Abs(b) + Math.Abs(c)) / 3;
            Console.WriteLine($"Набор 3: a={a}, b={b}, c={c}, Среднее арифметическое модулей: {avg:F4}");
            if (Math.Abs(a) > avg)
                Console.WriteLine($"Число a={a} (модуль {Math.Abs(a):F4}) больше среднего");
            else if (Math.Abs(b) > avg)
                Console.WriteLine($"Число b={b} (модуль {Math.Abs(b):F4}) больше среднего");
            else if (Math.Abs(c) > avg)
                Console.WriteLine($"Число c={c} (модуль {Math.Abs(c):F4}) больше среднего");
            else
                Console.WriteLine("Нет числа, модуль которого больше среднего");

            Console.ReadKey();
        }
    }
}
