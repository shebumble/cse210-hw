using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s = new Square("Orange", 4);
        shapes.Add(s);

        Rectangle r = new Rectangle("Yellow", 2, 5);
        shapes.Add(r);

        Circle c = new Circle("Red", 8);
        shapes.Add(c);

        foreach (Shape x in shapes)

        {
            string color = x.GetColor();

            double area = x.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}