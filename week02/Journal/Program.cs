using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        // Get date and format

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine($"{dateText}");

        int choice;
        choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");

            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            Journal theJournal = new Journal();
            Entry anEntry = new Entry();
            PromptGenerator thePrompt = new PromptGenerator();
            

            if (choice == 1)
            {
                string randomPrompt = thePrompt.GetRandomPrompt();
                Console.Write($"{randomPrompt} ");
                string userResponse = Console.ReadLine(); 
            }

            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {
                anEntry._date = dateText;
                anEntry._entryText = "Stressful.";
                anEntry.Display();

            }
            else if (choice == 4)
            {

            }
        }

        if (choice == 5)
        {
            Console.WriteLine("Have a good day!");
        }
    }
}