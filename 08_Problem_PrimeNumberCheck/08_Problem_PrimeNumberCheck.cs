using System;

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

