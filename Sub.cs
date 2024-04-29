using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables to store the numbers
        int num1, num2, difference;

        // Ask the user to enter the first number
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        // Ask the user to enter the second number
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Subtract the second number from the first one
        difference = num1 - num2;

        // Display the result
        Console.WriteLine($"The difference between {num1} and {num2} is: {difference}");
    }
}
