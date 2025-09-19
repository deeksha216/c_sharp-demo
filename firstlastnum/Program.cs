using System;
 class Program
{
    static void Main()
    {
        Console.WriteLine("enter the number");
        int num=int.Parse(Console.ReadLine());
        int lastdigit =num % 10;
        int firstdigit = num;
        while(firstdigit>=10)
        {
            firstdigit /= 10;

        }
        Console.WriteLine("first digit is:" + firstdigit);
        Console.WriteLine("last digit is:" + lastdigit);
    }
}