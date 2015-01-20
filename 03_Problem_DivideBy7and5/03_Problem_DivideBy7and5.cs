using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Please type an integer: ");
        int a = int.Parse(Console.ReadLine());
        bool divisionTest = ((a % 5 == 0) && (a % 7 == 0));
        Console.WriteLine(divisionTest);
    }
}

