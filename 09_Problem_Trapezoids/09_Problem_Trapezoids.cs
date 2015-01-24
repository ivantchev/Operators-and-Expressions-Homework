using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//Examples:

//a	b	h	area
//5	7	12	72
//2	1	33	49.5
//8.5	4.3	2.7	17.28
//100	200	300	45000
//0.222	0.333	0.555	0.1540125
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

