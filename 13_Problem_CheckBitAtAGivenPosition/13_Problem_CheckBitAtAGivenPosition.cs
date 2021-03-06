﻿using System;
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
//Examples:

//n	binary representation of n	p	bit @ p == 1
//5	00000000 00000101	2	true
//0	00000000 00000000	9	false
//15	00000000 00001111	1	true
//5343	00010100 11011111	7	true
//62241	11110011 00100001	11	false
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

