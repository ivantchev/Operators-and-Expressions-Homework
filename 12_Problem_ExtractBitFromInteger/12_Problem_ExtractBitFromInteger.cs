using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Insert the value of an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bits position:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of the {0} is: {1}", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        int extractkBit = 1 << position;
        Console.WriteLine((number & extractkBit) == extractkBit ? "The bit in position {0} is: 1 " : "The bit in position {0} is: 0", position);

    }
}

