using System;

class ModifyABitAtAGivenPosition
{
    static void Main()
    {
        Console.Write("Type N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Type P: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Type V: ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of number {0} is : {1}", n, Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine("Before: {0}", n);

        if (v == 0)
        {
            n = n & ~(1 << p);
        }

        else
        {
            n = n | (1 << p);
        }
        Console.WriteLine("Binary representation of number {0} is : {1}", n, Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine("Result: {0}", n);
    }
}

