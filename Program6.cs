namespace ConsoleAppAssign2
{
    using System;

    internal class Program6
    {
        static void Main()
        {
            // Prompt the user to enter the X and Y coordinates
            Console.Write("Enter the X coordinate: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Enter the Y coordinate: ");
            double y = double.Parse(Console.ReadLine());

            // Determine the quadrant
            if (x > 0 & y > 0)
            {
                Console.WriteLine("The point lies in Quadrant 1.");
            }
            else if (x < 0 & y > 0)
            {
                Console.WriteLine("The point lies in Quadrant 2.");
            }
            else if (x < 0 & y < 0)
            {
                Console.WriteLine("The point lies in Quadrant 3.");
            }
            else if (x > 0 & y < 0)
            {
                Console.WriteLine("The point lies in Quadrant 4.");
            }
            else if (x == 0 & y != 0)
            {
                Console.WriteLine("The point lies on the Y-axis.");
            }
            else if (x != 0 & y == 0)
            {
                Console.WriteLine("The point lies on the X-axis.");
            }
            else
            {
                Console.WriteLine("The point lies at the origin.");
            }
        }
    }
}
