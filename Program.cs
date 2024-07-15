// See https://aka.ms/new-console-template for more information
using System;

// Define a class MathOperations
public class MathOperations
{
    // Define a void method that takes two integers as parameters
    public void PerformOperation(int num1, int num2)
    {
        // Perform a math operation (for example, addition)
        int result = num1 + num2;

        // Display the second integer to the screen
        Console.WriteLine($"Second integer: {num2}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathObj = new MathOperations();

        // Call the PerformOperation method, passing in two numbers 
        mathObj.PerformOperation(5, 10);

        // Call the PerformOperation method, specifying the parameters by name 
        mathObj.PerformOperation(num1: 7, num2: 15);

        // Keeps the console window open until a key is pressed
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

