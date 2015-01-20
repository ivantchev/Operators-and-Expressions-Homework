using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Rectangles width: ");
        double widht = double.Parse(Console.ReadLine());

        Console.Write("Rectangles height: ");
        double height = double.Parse(Console.ReadLine());

        double rectanglesPerimeter = 2 * (widht + height);
        Console.WriteLine("The rectangle Perimeter is: {0}", rectanglesPerimeter);

        double rectanglesArea = (widht * height);
        Console.WriteLine("The rectangle Area is: {0}", rectanglesArea);
    }
}

