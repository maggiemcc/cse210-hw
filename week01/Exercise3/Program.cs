using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Get random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        // Assign guess a value
        int guess = -1;

        // while guess is wrong hint wether they need to guess a higher or lower number.
        while (guess != magicNumber)
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Whoops, guess higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Whoops, guess lower!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }

    }
}