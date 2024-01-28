using System;

namespace Question01
{
    class Question01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the width");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            Console.WriteLine($"the area of the rectangle is: {area}");
            Console.ReadLine();
        }
    }
}