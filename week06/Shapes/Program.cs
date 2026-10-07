using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>()
        {
            new Square("Red", 2),
            new Rectangle("Blue", 5, 6),
            new Circle("Green", 8)
        };

        // Other option to add shapes to list:
        // List<Shape> shapes = new List<Shape>();

        // Square shape1 = new Square("Red", 4);
        // shapes.Add(shape1);

        // Rectangle shape2 = new Rectangle("Blue", 5, 6);
        // shapes.Add(shape2);

        // Circle shape3 = new Circle("Green", 7);
        // shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color}, Area: {area}");
        }
    }
}