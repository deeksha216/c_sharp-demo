using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> s = new Stack<string>();
        s.Push("cap");
        s.Push("belt");
        s.Push("boots");
        Console.WriteLine(s.Pop()); 

    }
}
    