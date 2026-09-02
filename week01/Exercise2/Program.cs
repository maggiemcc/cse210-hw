using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        string letterGrade = "";

        if (percent >= 90)
        {
            letterGrade = "A";
        }
        else if (percent >= 80)
        {
            letterGrade = "B";
        }
        else if (percent >= 70)
        {
            letterGrade = "C";
        }
        else if (percent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is {letterGrade}");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Better luck next time!");
        }
    }
}