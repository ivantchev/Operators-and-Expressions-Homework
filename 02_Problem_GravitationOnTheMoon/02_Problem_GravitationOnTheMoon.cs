using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter weight: ");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnTheMoon = (weightOnEarth * 0.17);
        Console.WriteLine("Weight on Moon: {0}", weightOnTheMoon);
    }
}

