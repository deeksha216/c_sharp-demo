using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> s = new Queue<int>();
        s.Enqueue(1);
        s.Enqueue(2);
        s.Enqueue(3);

        Console.WriteLine("list of numbers:");
        foreach (int num in s)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("removed num is");
        {
            Console.WriteLine(s.Dequeue());

        }
    }
}
