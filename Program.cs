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
            Console.WriteLine("Hello World!");
        }
        
    }
}
