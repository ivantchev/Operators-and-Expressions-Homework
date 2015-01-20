using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Please enter integer x: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of x is: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        int p = 3;
        int mask = 1 << p;
        Console.WriteLine((number & mask) == mask ? "The third bit is: 1 " : "The third bit is: 0");

    }
}

