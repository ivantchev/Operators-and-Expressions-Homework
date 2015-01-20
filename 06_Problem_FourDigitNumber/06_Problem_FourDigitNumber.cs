using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Type four digit number: ");
        int number = int.Parse(Console.ReadLine());

        int a = (number / 1000) % 10;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;
        Console.WriteLine("The sum of the digits is: {0}", (a + b + c + d));
        Console.WriteLine("Number in reversed order: {0}, {1}, {2}, {3}", d, c, b, a);
        Console.WriteLine("Last digits in first position: {0}, {1}, {2}, {3}", d, a, b, c);
        Console.WriteLine("Exchange the second and third digit: {0}, {1}, {2}, {3}", a, c, b, d);


    }
}

