using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        int choice;
        choice = 0;

        Journal theJournal = new Journal();
        // Entry anEntry = new Entry();
        Journal loadFile = new Journal();
        Journal saveFile = new Journal();

        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");

            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            PromptGenerator thePrompt = new PromptGenerator();

            if (choice == 1)
            {
                Entry anEntry = new Entry();

                string randomPrompt = thePrompt.GetRandomPrompt();
                Console.Write($"{randomPrompt} \n> ");
                string userResponse = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();

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
                Console.Write("Please write a filename name you would like to view (ex: journal, trips): ");
                string filename = Console.ReadLine();
                loadFile.LoadFromFile(filename);
            }

            else if (choice == 4)
            {
                Console.Write("Please write a filename: ");
                string filename = Console.ReadLine();
                saveFile.SaveToFile(filename);
            }
        }

        if (choice == 5)
        {
            Console.WriteLine("Have a good day!");
        }
    }
}