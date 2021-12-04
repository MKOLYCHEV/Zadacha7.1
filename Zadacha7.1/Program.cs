using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой стороны первого треугольника:");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны первого треугольника:");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны первого треугольника:");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину первой стороны второго треугольника:");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны второго треугольника:");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны второго треугольника:");
            double c2 = Convert.ToDouble(Console.ReadLine());

            if ((a1 + b1) <= c1 || (a1 + c1) <= b1 || (c1 + b1) <= a1)
            {
                Console.WriteLine("Ошибка! Неверно заданы длины сторон первого треугольника.");
                if ((a2 + b2) <= c2 || (a2 + c2) <= b2 || (c2 + b2) <= a2) Console.WriteLine("Ошибка! Неверно заданы длины сторон второго треугольника.");
            }
            else if ((a2 + b2) <= c2 || (a2 + c2) <= b2 || (c2 + b2) <= a2) Console.WriteLine("Ошибка! Неверно заданы длины сторон второго треугольника.");
            else
            {
                double S1 = GetS(a1, b1, c1);
                double S2 = GetS(a2, b2, c2);

                if (S1 > S2) Console.WriteLine("Площадь первого треульника ({0:f2}) больше площади второго треугольника ({1:f2}).", S1, S2);
                else if (S1 == S2) Console.WriteLine("Площади треугольников равны ({0:f2}).", S1);
                else Console.WriteLine("Площадь второго треульника ({1:f2}) больше площади первого треугольника ({0:f2}).", S1, S2);
            }
            Console.ReadKey();
        }
        static double GetS(double a, double b, double c)
        {
            double P = a + b + c;
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}
