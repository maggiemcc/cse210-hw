// Showing Creativity and Exceeding Requirements: Created a list of scriptures and a random one will be chosen each time to memorize.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.\n");
        Random random = new Random();

        // List of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Isaiah", 41, 10), "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."),
            new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Proverbs", 3, 25, 26), "Be not afraid of sudden fear, neither of the desolation of the wicked, when it cometh. For the Lord shall be thy confidence, and shall keep thy foot from being taken."),
        };

        // Get random scripture to memorize
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        string userInput = "";

        while (userInput != "quit")
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress enter to hide random words or type 'quit' to quit: ");
            string userEnter = Console.ReadLine();
            userInput = userEnter.ToLower();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations! All words in the scripture have been hidden!");
                return;
            }
            else if (userInput == "quit")
            {
                Console.WriteLine("Goodbye!");
                return;
            }

            scripture.HideRandomWords(random.Next(1, 3));
        }
    }
}