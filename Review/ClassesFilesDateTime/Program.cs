//Ed Louie
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ClassesFilesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.height = 10;
            rect1.width = 20;

            Rectangle rect2 = new Rectangle(5, 2);

            Console.WriteLine($"The area of rect1 is {rect1.area()}.");
            Console.WriteLine($"The area of rect2 is {rect2.area()}.");

            List<Rectangle> rectangles = new List<Rectangle>();
            //add eexisting rectangles to the list
            rectangles.Add(rect1);
            rectangles.Add(rect2);

            //Ad a rectangle that is not yet added
            rectangles.Add(new Rectangle(7, 7));

            foreach (var rect in rectangles)
            {
                Console.WriteLine(rect);
                //Console.WriteLine(rect.ToString());
                //Console.WriteLine($"The rectangle has a width of {rect.width} and height of {rect.height}.");
                //Console.WriteLine($"The area of the rectangle is {rect.area()}.");
            }

            Console.ReadKey();
        }
    }
}
