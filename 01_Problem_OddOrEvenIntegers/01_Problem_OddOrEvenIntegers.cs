using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Type a number: ");
        int a = int.Parse(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine("the number is: even ", a);
        }
        else
        {
            Console.WriteLine("the number is: odd ", a);
        }
    }
}

