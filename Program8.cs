namespace ConsoleAppAssign4
{
    internal class Program8
  


    {
        static void Main()
        {
            // Declare variables for marks in subjects
            double mathsMarks, phyMarks, chemMarks;
            double totalMarks;

            // Read marks for Maths, Physics, and Chemistry
            Console.Write("Enter Marks in Mathematics: ");
            while (!double.TryParse(Console.ReadLine(), out mathsMarks) || mathsMarks < 0 || mathsMarks > 100)
            {
                Console.WriteLine("Invalid input! Please enter marks between 0 and 100 for Mathematics.");
                Console.Write("Enter Marks in Mathematics: ");
            }

            Console.Write("Enter Marks in Physics: ");
            while (!double.TryParse(Console.ReadLine(), out phyMarks) || phyMarks < 0 || phyMarks > 100)
            {
                Console.WriteLine("Invalid input! Please enter marks between 0 and 100 for Physics.");
                Console.Write("Enter Marks in Physics: ");
            }

            Console.Write("Enter Marks in Chemistry: ");
            while (!double.TryParse(Console.ReadLine(), out chemMarks) || chemMarks < 0 || chemMarks > 100)
            {
                Console.WriteLine("Invalid input! Please enter marks between 0 and 100 for Chemistry.");
                Console.Write("Enter Marks in Chemistry: ");
            }

            // Calculate total marks in all subjects
            totalMarks = mathsMarks + phyMarks + chemMarks;

            // Check eligibility based on the criteria
            if ((mathsMarks >= 65 && phyMarks >= 55 && chemMarks >= 50 && totalMarks >= 180) || (mathsMarks + totalMarks >= 140))
            {
                Console.WriteLine("\nYou are eligible for admission to the professional course.");
            }
            else
            {
                Console.WriteLine("\nYou are not eligible for admission to the professional course.");
            }
        }
    }
}
