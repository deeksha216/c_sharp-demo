using System;

class SimpleCalculator
{
    static void Main()
    {
        double num1, num2, result = 0;
        char op;

        Console.WriteLine("=== Simple Calculator ===");
        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Error: Division by zero!");
                break;
            default:
                Console.WriteLine("Invalid operator!");
                return;
        }

        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
}
