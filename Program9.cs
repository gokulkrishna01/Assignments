namespace ConsoleAppAssign5
{
    using System;

    internal class Program9
    {
        static void Main()
        {
            int choice;
            double area;

            do
            {
                // Display menu
                Console.WriteLine("\n--- Menu Driven Program to Calculate Area of Various Shapes ---");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Square");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                // Ensure valid integer input for choice
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                    Console.Write("Enter your choice (1-5): ");
                }

                switch (choice)
                {
                    case 1: // Circle
                        Console.Write("Enter the radius of the circle: ");
                        double radius;
                        while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number for radius.");
                            Console.Write("Enter the radius of the circle: ");
                        }
                        area = Math.PI * radius * radius;  // Area of circle: πr²
                        Console.WriteLine("Area of the Circle: " + area);
                        break;

                    case 2: // Rectangle
                        Console.Write("Enter the length of the rectangle: ");
                        double length;
                        while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number for length.");
                            Console.Write("Enter the length of the rectangle: ");
                        }

                        Console.Write("Enter the width of the rectangle: ");
                        double width;
                        while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number for width.");
                            Console.Write("Enter the width of the rectangle: ");
                        }

                        area = length * width;  // Area of rectangle: length × width
                        Console.WriteLine("Area of the Rectangle: " + area);
                        break;

                    case 3: // Triangle
                        Console.Write("Enter the base of the triangle: ");
                        double baseLength;
                        while (!double.TryParse(Console.ReadLine(), out baseLength) || baseLength <= 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number for base.");
                            Console.Write("Enter the base of the triangle: ");
                        }

                        Console.Write("Enter the height of the triangle: ");
                        double height;
                        while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number for height.");
                            Console.Write("Enter the height of the triangle: ");
                        }

                        area = 0.5 * baseLength * height;  // Area of triangle: 1/2 × base × height
                        Console.WriteLine("Area of the Triangle: " + area);
                        break;

                    case 4: // Square
                        Console.Write("Enter the side length of the square: ");
                        double side;
                        while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid positive number for side.");
                            Console.Write("Enter the side length of the square: ");
                        }
                        area = side * side;  // Area of square: side²
                        Console.WriteLine("Area of the Square: " + area);
                        break;

                    case 5: // Exit
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }

            } while (choice != 5); // Repeat the menu until user chooses to exit
        }
    }
}

