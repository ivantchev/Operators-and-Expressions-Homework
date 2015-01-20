using System;

class CheckBitAtAGivenPosition
{
    static void Main()
    {
        Console.Write("Please type in an integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please type in bits position: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("The Binary representation of that number is: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        int mask = number >> position;
        bool result = (mask & 1) == 1;
        Console.WriteLine("The value of the integer is: " + result);

    }
}

