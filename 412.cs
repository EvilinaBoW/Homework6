using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 16
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            double R = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            if (distance >= r && distance <= R)
                Console.WriteLine("Точка A лежит внутри кольца");
            else
                Console.WriteLine("Точка A лежит вне кольца");

            // Задание 17
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y < 0)
                Console.WriteLine("Точка A находится в четвёртой четверти");
            else
                Console.WriteLine("Точка A не находится в четвёртой четверти");

            // Задание 18
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(a - b) < 0.0001 || Math.Abs(b - c) < 0.0001 || Math.Abs(a - c) < 0.0001)
                Console.WriteLine("Треугольник является равнобедренным");
            else
                Console.WriteLine("Треугольник не является равнобедренным");

            // Задание 19
            int aInt = Convert.ToInt32(Console.ReadLine());
            int bInt = Convert.ToInt32(Console.ReadLine());
            int cInt = Convert.ToInt32(Console.ReadLine());
            if (cInt * cInt == aInt * aInt + bInt * bInt ||
                aInt * aInt == bInt * bInt + cInt * cInt ||
                bInt * bInt == aInt * aInt + cInt * cInt)
                Console.WriteLine("Числа образуют пифагорову тройку");
            else
                Console.WriteLine("Числа не образуют пифагорову тройку");

            // Задание 20
            double flow1 = Convert.ToDouble(Console.ReadLine()); 
            double flow2 = Convert.ToDouble(Console.ReadLine()); 
            double flow2InLitersPerSecond = flow2 * 1000 / 60; 
            if (flow1 > flow2InLitersPerSecond)
                Console.WriteLine("Расход 1 л/с больше");
            else if (flow2InLitersPerSecond > flow1)
                Console.WriteLine("Расход 10⁻³ м³/мин больше");
            else
                Console.WriteLine("Расходы равны");

            // Задание 21
            double circleArea = Convert.ToDouble(Console.ReadLine());
            double squareArea = Convert.ToDouble(Console.ReadLine());
            double circleRadius = Math.Sqrt(circleArea / Math.PI);
            double squareSide = Math.Sqrt(squareArea);
            bool circleFitsInSquare = circleRadius * 2 <= squareSide;
            bool squareFitsInCircle = squareSide * Math.Sqrt(2) <= circleRadius * 2;
            Console.WriteLine(circleFitsInSquare ? "Круг помещается в квадрат" : "Круг не помещается в квадрат");
            Console.WriteLine(squareFitsInCircle ? "Квадрат помещается в круг" : "Квадрат не помещается в круг");

            // Задание 22
            double mass1 = Convert.ToDouble(Console.ReadLine());
            double volume1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите массу и объём второго тела (г, см³)");
            double mass2 = Convert.ToDouble(Console.ReadLine());
            double volume2 = Convert.ToDouble(Console.ReadLine());
            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;
            if (density1 > density2)
                Console.WriteLine("Первое тело имеет большую плотность");
            else if (density2 > density1)
                Console.WriteLine("Второе тело имеет большую плотность");
            else
                Console.WriteLine("Плотности равны");

            // Задание 23
            double speedKmh = Convert.ToDouble(Console.ReadLine());
            double speedMs = Convert.ToDouble(Console.ReadLine());
            double speedKmhToMs = speedKmh * 1000 / 3600; // Перевод км/ч в м/с
            if (speedKmhToMs > speedMs)
                Console.WriteLine("Скорость в км/ч больше");
            else if (speedMs > speedKmhToMs)
                Console.WriteLine("Скорость в м/с больше");
            else
                Console.WriteLine("Скорости равны");

            // Задание 24
            double triangleArea = Convert.ToDouble(Console.ReadLine());
            double circleArea2 = Convert.ToDouble(Console.ReadLine());
            double triangleSide = Math.Sqrt(triangleArea * 4 / Math.Sqrt(3));
            double circleRadius2 = Math.Sqrt(circleArea2 / Math.PI);
            bool circleFitsInTriangle = circleRadius2 <= triangleSide * Math.Sqrt(3) / 6;
            bool triangleFitsInCircle = circleRadius2 >= triangleSide * Math.Sqrt(3) / 3;
            Console.WriteLine(circleFitsInTriangle ? "Круг помещается в треугольник" : "Круг не помещается в треугольник");
            Console.WriteLine(triangleFitsInCircle ? "Треугольник помещается в круг" : "Треугольник не помещается в круг");

            // Задание 25: 
            double resistance1 = Convert.ToDouble(Console.ReadLine());
            double voltage1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сопротивление и напряжение для второй цепи (Ом, В)");
            double resistance2 = Convert.ToDouble(Console.ReadLine());
            double voltage2 = Convert.ToDouble(Console.ReadLine());
            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;
            if (current1 < current2)
                Console.WriteLine("Сила тока в первой цепи меньше");
            else if (current2 < current1)
                Console.WriteLine("Сила тока во второй цепи меньше");
            else
                Console.WriteLine("Силы тока равны");

            // Задание 26
            double G = 6.7e-8; 
            double mVenus = 4.86e27; 
            double rVenus = 6175e5; 
            double mSaturn = 5.68e29;
            double rSaturn = 57750e5; 
            double gVenus = G * mVenus / (rVenus * rVenus);
            double gSaturn = G * mSaturn / (rSaturn * rSaturn);
            if (gVenus > gSaturn)
                Console.WriteLine("Ускорение свободного падения на Венере больше");
            else if (gSaturn > gVenus)
                Console.WriteLine("Ускорение свободного падения на Сатурне больше");
            else
                Console.WriteLine("Ускорения свободного падения равны");

            // Задание 27
            int hours = Convert.ToInt32(Console.ReadLine());
            if (hours >= 0 && hours < 12)
                Console.WriteLine("Время — до полудня (am)");
            else if (hours >= 12 && hours < 24)
                Console.WriteLine("Время — после полудня (pm)");
            else
                Console.WriteLine("Некорректное время");

            // Задание 28
            double longitude = Convert.ToDouble(Console.ReadLine());
            double latitude = Convert.ToDouble(Console.ReadLine());
            string hemisphere = "";
            if (longitude > 0)
                hemisphere += "Восточное ";
            else if (longitude < 0)
                hemisphere += "Западное ";
            if (latitude > 0)
                hemisphere += "Северное";
            else if (latitude < 0)
                hemisphere += "Южное";
            else
                hemisphere += "Экваториальное";
            Console.WriteLine($"Местоположение находится в {hemisphere} полушарии");

            // Задание 29
            double siriusDistance = 8.14e12; 
            double parsecToLightYear = 3.259;
            double arcturusDistance = 103 * parsecToLightYear * 9.461e12; 
            if (siriusDistance > arcturusDistance)
                Console.WriteLine("Сириус дальше");
            else if (arcturusDistance > siriusDistance)
                Console.WriteLine("Арктур дальше");
            else
                Console.WriteLine("Расстояния равны");

            // Задание 30
            int naturalNum = Convert.ToInt32(Console.ReadLine());
            if (naturalNum % 2 == 0 || naturalNum % 10 == 7)
                Console.WriteLine("Число чётное или оканчивается на 7");
            else
                Console.WriteLine("Число не является чётным и не оканчивается на 7");

            Console.ReadKey();
        }
    }
}
```
