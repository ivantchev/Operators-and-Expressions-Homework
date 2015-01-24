using System;
//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
//Examples:

//n	Prime?
//1	false
//2	true
//3	true
//4	false
//9	false
//97	true
//51	false
//-3	false
//0	false
class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int n = int.Parse(Console.ReadLine());
        double a = Math.Sqrt(n);
        bool primeTest = true;
        for (int i = 2; i <= a; i++)
        {

            if (n % i == 0)
            {
                primeTest = false;
            }

        }
        if (n == 1 || n <= 0)
        {
            primeTest = false;
        }
        Console.WriteLine("{0} is prime - {1}", n, primeTest);
    }
}

