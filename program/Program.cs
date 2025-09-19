using System;
class Program
{
    static void Main()
    {
        try
        {

            Console.WriteLine("enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine(" result is : " + result);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("error:cannot divide by zero");

        }
        catch(FormatException)
        {
            Console.WriteLine("error:please enter the valid number only");
        }
        finally
        {
            Console.WriteLine("thank you for using the division program");
        }

    }
}