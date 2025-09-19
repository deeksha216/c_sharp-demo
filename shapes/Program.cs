using System;
class Shapes
{
    public virtual void Draw() => Console.WriteLine("dreaing a shape");
    public virtual void erase() => Console.WriteLine("erasing the shape");
}
class Circle : Shapes
{
    public override void Draw() => Console.WriteLine("drawing the circle");
    public override void erase() => Console.WriteLine("erasing the circle");
}
class Triangle : Shapes
{
    public override void Draw() => Console.WriteLine("drawing the triangle");
    public override void erase() => Console.WriteLine("erasing the triangle"); 
}
class Square: Shapes
{
    public override void Draw() => Console.WriteLine("drawing the square");
    public override void erase() => Console.WriteLine("erasing the square");

}
class Program
{
    public static void Main()
    {
        Shapes[] shapes = { new Circle(), new Triangle(), new Square() };
        foreach (Shapes s in shapes)
        {
            s.Draw();
            s.erase();
        }
    }
}