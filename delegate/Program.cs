using System;
delegate void Greet();
 class Program
{
    static void Sayhello()
    {
        Console.WriteLine("hello,guys !");

    }
    static void Sayhii()
    {
        Console.WriteLine(" hi im fine");
    }
    static void Main()
    {
        Greet g = Sayhello;
        g+=Sayhii;
        g();

    }
}