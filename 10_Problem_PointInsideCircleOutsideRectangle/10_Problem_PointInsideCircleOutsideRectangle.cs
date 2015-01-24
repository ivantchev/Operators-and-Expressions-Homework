using System;
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
//Examples:

//x	y	inside K & outside of R
//1	2	yes
//2.5	2	no
//0	1	no
//2.5	1	no
//2	0	no
//4	0	no
//2.5	1.5	no
//2	1.5	yes
//1	2.5	yes
//-100	-100	no
class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (1.5 * 1.5);
        bool isOutOfRect = x > 1 && x <= 5 && y > -1 && y <= 1;
        if (isInCircle == true && isOutOfRect == false)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}

