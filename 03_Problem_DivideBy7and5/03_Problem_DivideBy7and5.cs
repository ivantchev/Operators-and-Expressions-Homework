using System;


//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
//Examples:

//n	Divided by 7 and 5?
//3	false
//0	false
//5	false
//7	false
//35	true
//140	true
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

