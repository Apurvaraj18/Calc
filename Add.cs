using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables to store the numbers
        int num1, num2, sum;

        // Ask the user to enter the first number
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        // Ask the user to enter the second number
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Add the two numbers
        sum = num1 + num2;

        // Display the result
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
    }
}
