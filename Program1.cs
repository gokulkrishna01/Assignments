namespace ConsoleAppAssignment1
{
    class Program1
    {
        static void Main()
        {
            string correctUserId = "admin";
            string correctPassword = "password321";


            int attempts = 0;
            const int maxAttempts = 3;
            while (attempts < maxAttempts)
            {
                Console.Write("Enter User Id: ");
                string UserId = Console.ReadLine();


                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                if (UserId == correctUserId & password == correctPassword)
                {
                    Console.Write("login successful!");
                    return;

                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Invalid attempts. you have{maxAttempts - attempts}attempts left.");
                }

                Console.WriteLine("You have been rejected.Too many attempts.");
                Console.ReadKey();






            }
        }
    }
}

