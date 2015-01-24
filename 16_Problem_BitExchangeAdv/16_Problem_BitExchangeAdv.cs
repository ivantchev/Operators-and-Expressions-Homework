using System;

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
//Examples:

//n	p	q	k	binary representation of n	binary result	result
//1140867093	3	24	3	01000100 00000000 01000000 00010101	01000010 00000000 01000000 00100101	1107312677
//4294901775	24	3	3	11111111 11111111 00000000 00001111	11111001 11111111 00000000 00111111	4194238527
//2369124121	2	22	10	10001101 00110101 11110111 00011001	01110001 10110101 11111000 11010001	1907751121
//987654321	2	8	11	00111010 11011110 01101000 10110001	-	overlapping
//123456789	26	0	7	00000111 01011011 11001101 00010101	-	out of range
//33333333333	-1	0	33	00000111 11000010 11010010 01001101 01010101	-	out of range
class BitExchangeAdv
{
    static void Main()
    {
        uint number = 0u;
        byte close = 0;
        byte far = 0;
        byte k = 0;

        Console.WriteLine("Enter Unsigned Integer number:");
        number = uint.Parse(Console.ReadLine());
        Console.WriteLine("The binary represantation of the number is: \n{0}"
                            , Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.WriteLine("Enter the first position of the bits, that are going to be exchanged:");
        close = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second position of the bits, that are going to be exchanged:");
        far = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of the bits, that are going to be exchanged:");
        k = byte.Parse(Console.ReadLine());

        if (Math.Min(close, far) + k > Math.Max(close, far))
        {
            Console.WriteLine("Overlapping");
        }
        else if (!(((close + k) <= 32) && ((far + k) <= 32)))
        {
            Console.WriteLine("Out of range");
        }
        else
        {
            uint mask = (1u << k) - 1u;
            uint maskClose = mask << close;
            uint maskFar = mask << far;

            uint closeBits = number & maskClose;
            uint farBits = number & maskFar;

            closeBits = closeBits >> close;
            farBits = farBits >> far;

            number = number & (~maskClose);
            number = number & (~maskFar);

            closeBits = closeBits << far;
            farBits = farBits << close;

            number = number | closeBits;
            number = number | farBits;

            Console.WriteLine("Binary result:\n{0}\nResult:{1}"
                           , Convert.ToString(number, 2).PadLeft(32, '0')
                           , number);
        }
    }
}
