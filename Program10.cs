namespace ConsoleAppAssign6
{
    using System;

    internal class Program10
    {
        static void Main()
        {
            int choice;
            double num1, num2, result;

            do
            {
                // Display menu
                Console.WriteLine("\n--- Menu-Driven Program for Simple Calculations ---");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                // Ensure valid integer input for choice
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                    Console.Write("Enter your choice (1-5): ");
                }

                if (choice != 5)
                {
                    // Read two numbers for the calculations
                    Console.Write("Enter the first number: ");
                    while (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        Console.Write("Enter the first number: ");
                    }

                    Console.Write("Enter the second number: ");
                    while (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        Console.Write("Enter the second number: ");
                    }

                    // Perform the operation based on user's choice
                    switch (choice)
                    {
                        case 1: // Addition
                            result = num1 + num2;
                            Console.WriteLine("Result of Addition: " + result);
                            break;

                        case 2: // Subtraction
                            result = num1 - num2;
                            Console.WriteLine("Result of Subtraction: " + result);
                            break;

                        case 3: // Multiplication
                            result = num1 * num2;
                            Console.WriteLine("Result of Multiplication: " + result);
                            break;

                        case 4: // Division
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error! Division by zero is not allowed.");
                            }
                            else
                            {
                                result = num1 / num2;
                                Console.WriteLine("Result of Division: " + result);
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please select a valid option.");
                            break;
                    }
                }

            } while (choice != 5); // Repeat the menu until user chooses to exit

            Console.WriteLine("Exiting the program.");
        }
    }
}
