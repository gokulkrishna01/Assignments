namespace ConsoleAppAssign1
{
    using System;

    class Program5
    {
        static void Main()
        {
            // Prompt the user for their age
            Console.Write("Enter your age: ");

            // Read the input and convert it to an integer
            int age = int.Parse(Console.ReadLine());

            // Check if the age is 18 or greater, which is the eligibility criterion
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to cast your vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to cast your vote.");
            }
        }
    }
}