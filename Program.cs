using System;

namespace randRectangle
{
    public class Rectangle
    {
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int Length { get; }
        public int Width { get; }
    }

    public class Utility
    {
        public static int calcArea(int length, int width)
        {
            int area = length * width;
            return area;
        }
        public static int calcPerimeter(int length, int width)
        {
            int perimeter = 2 * (length + width);
            return perimeter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int min = 2;
            int max = 10;
            int length;
            int width;

            MakeRectangle(min, max, out length, out width);
            Rectangle theBox = new Rectangle(length, width);

            Console.WriteLine("Length: " + theBox.Length);
            Console.WriteLine("Width: " + theBox.Width);
            Console.WriteLine("Area: " + Utility.calcArea(theBox.Length, theBox.Width));
            Console.WriteLine("Perimeter: " + Utility.calcPerimeter(theBox.Length, theBox.Width));
        }
        
        static void MakeRectangle(int min, int max, out int length, out int width)
        {
            var rand = new Random();
            length = rand.Next(min, max);
            width = rand.Next(min, max);
        }
    }
}
