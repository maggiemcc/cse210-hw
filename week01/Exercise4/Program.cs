using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create a list called numbers
        List<int> numbers = new List<int>();
        int number = -1;

        // Get number from user and verify it's not 0
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            // Add number to list
            if (number != 0)
            {
                numbers.Add(number);
            }

        }


        // Calculate the sum of the list of numbers
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        Console.WriteLine($"The sum is: {sum}");


        // Calculate the average of the list of numbers
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // Find the largest number in the list of numbers
        int largest = numbers[0];
        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }
        }
        Console.WriteLine($"The largest number is {largest}");

    }
}