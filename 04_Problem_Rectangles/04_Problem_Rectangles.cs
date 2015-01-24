using System;
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:

//width	height	perimeter	area
//3	4	14	12
//2.5	3	11	7.5
//5	5	20	25
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

