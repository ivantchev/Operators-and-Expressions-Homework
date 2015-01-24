using System;
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
//Examples:

//x	y	inside
//0	1	true
//-2	0	true
//-1	2	false
//1.5	-1	true
//-1.5	-1.5	false
//100	-30	false
//0	0	true
//0.2	-0.8	true
//0.9	-1.93	false
//1	1.655	true
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

