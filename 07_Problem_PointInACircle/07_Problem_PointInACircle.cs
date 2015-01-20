using System;

class PointInACircle
{
    static void Main()
    {
        //(x - center_x)^2 + (y - center_y)^2 < radius^2 - Pythagorean theorem
        Console.Write("Type a number for X: ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Type a number for Y: ");
        double pointY = double.Parse(Console.ReadLine());
        int radius = 2;
        bool check = (((pointX * pointX) + (pointY * pointY)) <= radius * radius);
        Console.WriteLine(check);
    }
}

