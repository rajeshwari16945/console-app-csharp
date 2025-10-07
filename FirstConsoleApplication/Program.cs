using System;

class Program
{
    static void Main(string[] args)
    {
        double num1 = ReadNumber("Enter the first number: ");
        double num2 = ReadNumber("Enter the second number: ");

        double result = num1 + num2;

        Console.WriteLine($"The result of adding {num1} and {num2} is {result}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Method to read a valid number from the console
    static double ReadNumber(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            // Try parsing the input
            if (double.TryParse(input, out number))
            {
                return number; // valid number entered
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }
        }
    }
}
