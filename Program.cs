using System.Diagnostics;

namespace ConsoleApp3rdAssign6F
{
    using System;

    class Program
    {
        static void Main()
        {
            // Example array of integers
            int[] arr = { 1, 3, 5, 7, 9, 11, 13 };

            // Display the original array
            Console.WriteLine("Original Array:");
            DisplayArray(arr);

            // Position to delete (zero-based index)
            int position = 3;  // Position of the element to delete (delete the element at index 3, which is 7)

            // Delete the element at the desired position
            arr = DeleteElementAtPosition(arr, position);

            // Display the array after deletion
            Console.WriteLine($"Array after deleting element at position {position}:");
            DisplayArray(arr);

            // Wait for the user to press Enter before closing the console
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();  // This keeps the console open until Enter is pressed
        }

        // Function to delete an element at a desired position in the array
        static int[] DeleteElementAtPosition(int[] arr, int position)
        {
            // Check if the position is valid
            if (position < 0 || position >= arr.Length)
            {
                Console.WriteLine("Invalid position.");
                return arr;  // Return the original array if the position is invalid
            }

            // Create a new array with one less element
            int[] newArray = new int[arr.Length - 1];

            // Copy elements before the position
            for (int i = 0; i < position; i++)
            {
                newArray[i] = arr[i];
            }

            // Copy elements after the position, shifting left
            for (int i = position + 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }

            return newArray; // Return the new array
        }

        // Helper function to display the array
        static void DisplayArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }


}
