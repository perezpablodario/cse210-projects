using System;
using System.Collections.Generic;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 4);

        //string colorSqu = square.GetColor();
        //double areaSqu = square.GetArea();
        shapes.Add(square);
        //Console.WriteLine(colorSqu);
        //Console.WriteLine(areaSqu);

        Rectangle rectangle = new Rectangle("Blue", 4, 6);

        //string colorRec = rectangle.GetColor();
        //double areaRec = rectangle.GetArea();
        shapes.Add(rectangle);
        //Console.WriteLine(colorRec);
        //Console.WriteLine(areaRec);

        Circle circle = new Circle("Green", 5);

        //string colorCir = circle.GetColor();
        //double areaCir = circle.GetArea();
        shapes.Add(circle);
        //Console.WriteLine(colorCir);
        //Console.WriteLine(areaCir);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape as an area of {area}");
        }
    }
}