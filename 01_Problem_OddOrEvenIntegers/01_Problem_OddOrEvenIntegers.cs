using System;
////Write an expression that checks if given integer is odd or even.
//Examples:

//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false
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

