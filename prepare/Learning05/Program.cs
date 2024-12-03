using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape>shapes = new();
        Square s1 = new Square("Red", 2.5);
        shapes.Add(s1);

        Rectangle r1 = new ("Green", 1.75, 20.2);
        shapes.Add(r1);

        Circle c1 = new ("Orange", 4.56);
        shapes.Add(c1);

        foreach(Shape shapeItem in shapes){
            Console.WriteLine($"Color: {shapeItem.GetColor()}, Area: = {shapeItem.GetArea()}");
        }


    }
}