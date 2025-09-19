using System;
using System.Globalization;
abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}
class Circle : Shape
{
    private double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
 class  Triangle : Shape
{
    private double a, b, c;
    public Triangle(double x, double y, double z)
    {
        a = x;
        b = y;
        c = z;
    }
    public override double CalculateArea()
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
    public override double CalculatePerimeter()
    {
        return a + b + c;
    }
}
class Program
{
   public  static void Main()
    {
        Shape s1 = new Circle(5);
        Console.WriteLine("circle area:" + s1.CalculateArea());

        Console.WriteLine("circle perimeter :" + s1.CalculatePerimeter());

        Shape s2 = new Triangle(3, 4, 5);
        Console.WriteLine("triangle area:" + s2.CalculateArea());
        Console.WriteLine("triangle perimeter :" + s2.CalculatePerimeter());
    }
}
  
