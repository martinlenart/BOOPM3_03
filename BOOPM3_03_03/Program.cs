using System;

namespace BOOPM3_03_03
{
    class Program
    {
        record RectangleRecord (double Width, double Height);

        static void Main(string[] args)
        {
            var rr1 = new RectangleRecord (400,100);
            var rr2 = rr1;
            var rr3 = new RectangleRecord(0, 0);
            Console.WriteLine(rr1);
            Console.WriteLine(rr1 == rr2);
            Console.WriteLine(rr1 == rr3);

            (double width, double height) = rr1;
            Console.WriteLine(width);
            Console.WriteLine(height);
        }
    }
}
