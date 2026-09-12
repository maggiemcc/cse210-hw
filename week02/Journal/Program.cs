using System;
using System.IO;

// Exceeding requirements: 
// For saving files: added an if statement to check if the journal entries list is empty. If it is empty then a file will not be saved and user will be notified in the console.
// If user doesn't add a file extension to the name then an if statement will check and add .txt to the name before saving.

// For loading files: I added an if statement to check if the file exists. If it doesn't exist it will let the user know and return to the menu so the program won't crash.
// Added a validation for file entries that are loaded. If a journal entry has an incorrect length/number of parts and cannot be saved then console will let users know which entries could not be added to the journal.


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal theJournal = new Journal();

        int choice;
        choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");

            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            PromptGenerator thePrompt = new PromptGenerator();

            if (choice == 1)
            {
                string randomPrompt = thePrompt.GetRandomPrompt();
                Console.Write($"{randomPrompt} \n> ");
                string userResponse = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();

                Entry anEntry = new Entry();
                anEntry._date = date;
                anEntry._promptText = randomPrompt;
                anEntry._entryText = userResponse;

                theJournal.AddEntry(anEntry);
            }

            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Please write a filename name you would like to view (ex: journal.txt): ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }

            else if (choice == 4)
            {
                Console.Write("To save, please write a filename (ex: journal.txt): ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }

            else if (choice >= 0 || choice <= 6)
            {
                Console.WriteLine("Sorry, that was not a valid choice. Please try again!");
            }
        }

        if (choice == 5)
        {
            Console.WriteLine("Have a good day!");
        }
    }
}