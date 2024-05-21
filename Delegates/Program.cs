using Delegates;
using System;
class Program
{
    static void Main(string[] args)
    {
        MathOperation mathOperation = DelegateExample.Add;

        int result = mathOperation(10, 5);
        Console.WriteLine($"Addition result = {result}");

        mathOperation = DelegateExample.Subtract;
        result = mathOperation(10, 5);
        Console.WriteLine($"Subtraction result = {result}");


        mathOperation += DelegateExample.Add;
        mathOperation += DelegateExample.Subtract;
        result = mathOperation(10, 7);
        Console.WriteLine($"Addition and Subtraction result = {result}");

    }
}

