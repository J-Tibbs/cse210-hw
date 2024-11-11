using System;
using System.Runtime.CompilerServices;

class Program
{
    class Circle{
        private double radius;

        public Circle(double radius){
            this.radius = radius;
        }

        public double GetArea(){
            return Math.PI * radius * radius;
        }
        public double GetDiameter(){
            return radius * 2;
        }
        public double GetCircumference(){
            return Math.PI * 2 * radius;
        }
        public double GetRadius(){
            return radius;
        }
        public void SetRadius(double radius){
            this.radius = radius;
        }
        public void Diplay(){
        Console.WriteLine($"Area: {GetArea()}");
        Console.WriteLine($"Circumference: {GetCircumference()}");
        Console.WriteLine($"Diameter: {GetDiameter()}");
        Console.WriteLine($"Radius: {GetRadius()}");
        }
    }
    static void Main(string[] args)
    {
    int x = 10;

    Circle myCircle = new Circle(x);

    
    }


}
