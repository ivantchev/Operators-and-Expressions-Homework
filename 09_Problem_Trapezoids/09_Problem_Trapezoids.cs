using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Type trapezoids side: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Type trapezoids other side: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Type trapezoids height: ");
        double h = double.Parse(Console.ReadLine());

        double trapezoidsArea = (((a + b) * h) / 2);
        Console.WriteLine("\nTrapezoidsArea is: {0}", trapezoidsArea);
    }
}

