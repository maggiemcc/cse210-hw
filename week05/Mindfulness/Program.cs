using System;
// Exceeding Expectations: 
// Added an if-else statement to handle invalid user input for how long the activity sessions should be so the program doesn't crash.

// Keeping a log of how many times activities were performed and is displayed when the user quits the program.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Dictionary<string, int> activityCounter = new Dictionary<string, int>

        {
            { "Breathing Activity", 0 },
            { "Reflecting Activity", 0 },
            { "Listing Activity", 0 },
        };

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                activityCounter["Breathing Activity"]++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                activityCounter["Reflecting Activity"]++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                activityCounter["Listing Activity"]++;
            }
        }

        Console.WriteLine("\nCongrats! You have completed the following:");
        foreach (var item in activityCounter)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        Console.WriteLine("\nGoodbye! Have a great day!");
    }
}