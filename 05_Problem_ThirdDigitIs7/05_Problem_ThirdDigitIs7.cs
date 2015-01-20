using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Type a number: ");
        int number = int.Parse(Console.ReadLine());

        bool checkNumber = ((number / 100) % 10 == 7);
        Console.WriteLine("Is the third number 7?: ---> {0}", checkNumber);
    }
}

