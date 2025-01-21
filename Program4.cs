namespace ConsoleAppAssignment4
{
    internal class Program4
    {
       

    
        static void Main()
        {
            // Displaying the title
            Console.WriteLine("Displaying values for the function x = y^2 + 2y + 1\n");

            // Loop through integer values of y from -5 to 5
            for (int y = -5; y <= 5; y++)
            {
                // Calculate the value of x for each y using the given formula
                int x = (y * y) + (2 * y) + 1;

                // Display the result for the current value of y
                Console.WriteLine($"For y = {y}, x = {x}");

                Console.ReadKey();
            }
        }
    }

}


