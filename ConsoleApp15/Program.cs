using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите c");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine(Count(a, b, c));
    }

    static string Count(double a, double b, double c)
    {
        double d = Math.Sqrt((b * b) - (4 * a * c));
        if (d > 0)
        {
            double x1, x2;
            x1 = (-b + d) / (2 * a);
            x2 = (-b - d) / (2 * a);
            return $"1. Корни уравнения с коэффициентами a={a} b={b} c={c} x1={x1}, x2={x2}";
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            return $"0. Корень уравнения с коэффициентами a={a} b={b} c={c} x1=x2={x}";
        }
        else return $"-1. Корней уравнения с коэффициентами a={a} b={b} c={c} результат нет.";
    }
}