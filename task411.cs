using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sumOfSquares = num1 * num1 + num2 * num2;
            double squareOfSum = Math.Pow(num1 + num2, 2);
            if (sumOfSquares > squareOfSum)
                Console.WriteLine("Сумма квадратов больше");
            else if (sumOfSquares < squareOfSum)
                Console.WriteLine("Квадрат суммы больше");
            else
                Console.WriteLine("Сумма квадратов равна квадрату суммы");

            // Задание 2
            double salary = Convert.ToDouble(Console.ReadLine());
            int years = Convert.ToInt32(Console.ReadLine());
            double bonus = 0;
            if (years >= 2 && years < 5)
                bonus = salary * 0.02;
            else if (years >= 5 && years < 10)
                bonus = salary * 0.05;
            Console.WriteLine($"Премия: {bonus:F2}");
            Console.WriteLine($"Общая зарплата с премией: {(salary + bonus):F2}");

            // Задание 3
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B (x1, y1)");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);
            if (Math.Abs(distanceA - distanceB) < 0.0001)
                Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат");
            else if (distanceA > distanceB)
                Console.WriteLine("Точка A дальше от начала координат");
            else
                Console.WriteLine("Точка B дальше от начала координат");

            // Задание 4
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2))) < 0.0001 ||
                Math.Abs(Math.Pow(a, 2) - (Math.Pow(b, 2) + Math.Pow(c, 2))) < 0.0001 ||
                Math.Abs(Math.Pow(b, 2) - (Math.Pow(a, 2) + Math.Pow(c, 2))) < 0.0001)
                Console.WriteLine("Треугольник является прямоугольным");
            else
                Console.WriteLine("Треугольник не является прямоугольным");

            // Задание 5
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(n1 >= 0 ? Math.Pow(n1, 2) : n1);
            Console.WriteLine(n2 >= 0 ? Math.Pow(n2, 2) : n2);
            Console.WriteLine(n3 >= 0 ? Math.Pow(n3, 2) : n3);

            // Задание 6
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("Точка A находится в первой четверти");
            else if (x < 0 && y > 0)
                Console.WriteLine("Точка A находится во второй четверти");
            else if (x < 0 && y < 0)
                Console.WriteLine("Точка A находится в третьей четверти");
            else if (x > 0 && y < 0)
                Console.WriteLine("Точка A находится в четвёртой четверти");
            else
                Console.WriteLine("Точка A лежит на оси координат");

            // Задание 7
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            double R = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            if (distance <= R)
                Console.WriteLine("Точка A лежит внутри круга");
            else
                Console.WriteLine("Точка A лежит вне круга");

            // Задание 8
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника (a2, b2, c2)");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s1 = (a1 + b1 + c1) / 2;
            double s2 = (a2 + b2 + c2) / 2;
            double area1 = Math.Sqrt(s1 * (s1 - a1) * (s1 - b1) * (s1 - c1));
            double area2 = Math.Sqrt(s2 * (s2 - a2) * (s2 - b2) * (s2 - c2));
            if (area1 > area2)
                Console.WriteLine("Первый треугольник имеет большую площадь");
            else if (area2 > area1)
                Console.WriteLine("Второй треугольник имеет большую площадь");
            else
                Console.WriteLine("Треугольники имеют одинаковые площади");

            // Задание 9
            double squareSide = Convert.ToDouble(Console.ReadLine());
            double radius = Convert.ToDouble(Console.ReadLine());
            double squareArea = squareSide * squareSide;
            double circleArea = Math.PI * radius * radius;
            if (squareArea > circleArea)
                Console.WriteLine("Площадь квадрата больше");
            else if (circleArea > squareArea)
                Console.WriteLine("Площадь круга больше");
            else
                Console.WriteLine("Площади квадрата и круга равны");

            // Задание 10
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(n1 >= 0 ? Math.Pow(n1, 3) : 0);
            Console.WriteLine(n2 >= 0 ? Math.Pow(n2, 3) : 0);
            Console.WriteLine(n3 >= 0 ? Math.Pow(n3, 3) : 0);

            // Задание 11
            int naturalNum = Convert.ToInt32(Console.ReadLine());
            if (naturalNum % 2 == 0 || naturalNum % 10 == 3)
                Console.WriteLine("Число чётное или оканчивается на 3");
            else
                Console.WriteLine("Число не является чётным и не оканчивается на 3");

            // Задание 12
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("Точка A лежит в первой четверти");
            else
                Console.WriteLine("Точка A не лежит в первой четверти");

            // Задание 13
            double deposit = Convert.ToDouble(Console.ReadLine());
            int term = Convert.ToInt32(Console.ReadLine());
            double monthlyInterest = 0;
            if (term == 6)
                monthlyInterest = deposit * (0.06 / 12) * 6;
            else if (term == 12)
                monthlyInterest = deposit * (0.08 / 12) * 12;
            else
                Console.WriteLine("Некорректный срок");
            if (term == 6 || term == 12)
                Console.WriteLine($"Общая сумма процентов: {monthlyInterest:F2}");

            // Задание 14
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            double diffOfSquares = num1 * num1 - num2 * num2;
            double squareOfDiff = Math.Pow(num1 - num2, 2);
            if (diffOfSquares > squareOfDiff)
                Console.WriteLine("Разность квадратов больше");
            else if (squareOfDiff > diffOfSquares)
                Console.WriteLine("Квадрат разности больше");
            else
                Console.WriteLine("Разность квадратов равна квадрату разности");

            // Задание 15
            x0 = Convert.ToDouble(Console.ReadLine());
            y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B (x1, y1)");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            distanceB = Math.Sqrt(x1 * x1 + y1 * y1);
            if (Math.Abs(distanceA - distanceB) < 0.0001)
                Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат");
            else if (distanceA < distanceB)
                Console.WriteLine("Точка A ближе к началу координат");
            else
                Console.WriteLine("Точка B ближе к началу координат");

            Console.ReadKey();
        }
    }
}
