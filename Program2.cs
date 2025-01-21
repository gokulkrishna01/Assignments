namespace ConsoleAppAssignment2
{
    class Program
    {
        static void Main()
        {
            int number, width;
            Console.WriteLine("Enter the num to display traingle: ");
            int.TryParse(Console.ReadLine(),out number);
            Console.WriteLine("Enter the width to display traingle: ");
            int.TryParse(Console.ReadLine(), out width);
            Console.WriteLine(width);
            if (width <= 0)
            {
                Console.WriteLine("width must be a positive integer: ");

                return;

            }
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}