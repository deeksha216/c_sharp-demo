using System;
class Sum
{
    static void Main()
    {
        int n, sum = 0;
        Console.WriteLine("Enter a positive integer: ");
        n = Convert.ToInt32(Console.ReadLine());
         while(n>0)
        {
            sum = sum + (n % 10);
            n = n / 10;

        }
         Console.WriteLine("sum of digits is: " + sum);
    }
}