using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2,"blue");
        square.SetColor("red");
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(3,2,"blue");
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle(3,"green");
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(3,"blue"));
        shapes.Add(new Rectangle(3,2,"red"));
        shapes.Add(new Square(2,"green"));

        foreach(Shape shape in shapes){
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}
