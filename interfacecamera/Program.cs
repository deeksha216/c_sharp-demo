using System;
    interface Camera
    {
        void capturePhoto();
    }
    interface Printer
    {
        void printDocument();
    } 
class Myclass: Camera ,Printer
{
    public void capturePhoto()
    {
        Console.WriteLine("Photo captured.");
    }
    public void printDocument()
    {
        Console.WriteLine("Document printed.");
    }
}
class Program
{ 
    static void Main(string[] args)
{
    Myclass d = new Myclass();
    d.capturePhoto();
    d.printDocument();
}
}


  

   