using System;
using System.IO; 

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
            Journal loadFile = new Journal();
            Journal saveFile = new Journal();
            
            if (choice == 1)
            {
                string randomPrompt = thePrompt.GetRandomPrompt();
                Console.Write($"{randomPrompt} \n> ");
                string userResponse = Console.ReadLine(); 
                anEntry._date = dateText;
                anEntry._entryText = userResponse;
                anEntry._promptText = randomPrompt;
                anEntry.Display();
            }

            else if (choice == 2)
            {
                anEntry.Display();

            }

            else if (choice == 3)
            {
                string filename = "myFile.txt";
                loadFile.LoadFromFile(filename);  
            }

            else if (choice == 4)
            {
                string filename = "myFile.txt";
                saveFile.SaveToFile(filename);
            }
        }

        if (choice == 5)
        {
            Console.WriteLine("Have a good day!");
        }
    }
}