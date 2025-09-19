using System;
abstract class shape
{
       public abstract double calculatearea();
         public abstract double calculateperimeter();

}
class Circle:shape
{
    private double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public override double calculatearea()
    {
        return Math.PI * radius * radius;
    }
    public override double calculateperimeter()
    {
        return 2 * Math.PI * radius;
    }
}
class Triangle : shape
{
    private double a, b, c;
    public Triangle (double x, double y, double z)
    {
        a = x;
        b = y;
        c = z;
    }
    public override double calculatearea()
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
    public override double calculateperimeter()
    {
        return a + b + c;
    }
}
class Program
{
    static void Main(string[] args)
    {
        shape s1 = new Circle(5);
        Console.WriteLine("Circle Area: " + s1.calculatearea());
        Console.WriteLine("Circle Perimeter: " + s1.calculateperimeter());
        shape s2 = new Triangle(3, 4, 5);
        Console.WriteLine("Triangle Area: " + s2.calculatearea());
        Console.WriteLine("Triangle Perimeter: " + .calculateperimeter());
    }
}