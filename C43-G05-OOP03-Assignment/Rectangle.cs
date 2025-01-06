using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP03_Assignment
{
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area => Width * Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with Width: {Width}, Height: {Height}, Area: {Area}");
        }
    }
}
