using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Random random = new Random();

        string userInput = "";

        while (userInput != "quit")
        {
            // Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Press enter or hide random words or type 'quit' to quit: ");
            string userEnter = Console.ReadLine();
            userInput = userEnter;

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations! All words in the scripture has been hidden!");
                return;
            }
            else if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                return;
            }

            scripture.HideRandomWords(random.Next(1, 3));
        }
    }
}