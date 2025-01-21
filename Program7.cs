namespace ConsoleAppAssign3
{
    using System;




    internal class Program7
    {
        static void Main()
        {
            // Declare variables to store student's details and marks
            int rollNo;
            string name;
            double marks1, marks2, marks3;
            double total, percentage;
            string division;

            // Read student's roll number and name
            Console.Write("Enter Roll No: ");
            while (!int.TryParse(Console.ReadLine(), out rollNo))
            {
                Console.WriteLine("Invalid input! Please enter a valid roll number.");
                Console.Write("Enter Roll No: ");
            }

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            // Read marks for three subjects with validation
            Console.Write("Enter marks for Subject 1: ");
            while (!double.TryParse(Console.ReadLine(), out marks1) || marks1 < 0 || marks1 > 100)
            {
                Console.WriteLine("Invalid input! Please enter marks between 0 and 100.");
                Console.Write("Enter marks for Subject 1: ");
            }

            Console.Write("Enter marks for Subject 2: ");
            while (!double.TryParse(Console.ReadLine(), out marks2) || marks2 < 0 || marks2 > 100)
            {
                Console.WriteLine("Invalid input! Please enter marks between 0 and 100.");
                Console.Write("Enter marks for Subject 2: ");
            }

            Console.Write("Enter marks for Subject 3: ");
            while (!double.TryParse(Console.ReadLine(), out marks3) || marks3 < 0 || marks3 > 100)
            {
                Console.WriteLine("Invalid input! Please enter marks between 0 and 100.");
                Console.Write("Enter marks for Subject 3: ");
            }

            // Calculate total marks
            total = marks1 + marks2 + marks3;

            // Calculate percentage
            percentage = (total / 300) * 100;

            // Determine the division based on percentage
            if (percentage >= 60)
            {
                division = "First Division";
            }
            else if (percentage >= 50)
            {
                division = "Second Division";
            }
            else if (percentage >= 40)
            {
                division = "Third Division";
            }
            else
            {
                division = "Fail";
            }

            // Display the results
            Console.WriteLine("\n--- Student Report ---");
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total Marks: " + total + " / 300");
            Console.WriteLine("Percentage: " + percentage + " %");
            Console.WriteLine("Division: " + division);
        }
    }
}
