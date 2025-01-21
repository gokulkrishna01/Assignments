namespace ConsoleAppAssignment3
{
    using System;

    class SpeedCalculator
    {
        static void Main()
        {
            double distance, time;
            // Taking distance and time as input from the user
            Console.Write("Enter distance in kilometers: ");
            double.TryParse(Console.ReadLine(), out distance);

            Console.Write("Enter time in hours: ");
            double.TryParse(Console.ReadLine(), out time);

            // Calculate speed in kilometers per hour
            double speedInKmPerHour = distance / time;

            // Convert speed to miles per hour (1 km = 0.621371 miles)
            double speedInMilesPerHour = speedInKmPerHour * 0.621371;

            // Display the results
            Console.WriteLine($"Speed: {speedInKmPerHour} km/h");
            Console.WriteLine($"Speed: {speedInMilesPerHour} mph");

            Console.ReadKey();
        }
    }

}

