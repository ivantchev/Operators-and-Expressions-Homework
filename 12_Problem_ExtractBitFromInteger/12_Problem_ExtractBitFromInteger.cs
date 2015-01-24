using System;
//Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.
//Examples:

//n	binary representation	p	bit @ p
//5	00000000 00000101	2	1
//0	00000000 00000000	9	0
//15	00000000 00001111	1	1
//5343	00010100 11011111	7	1
//62241	11110011 00100001	11	0
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

