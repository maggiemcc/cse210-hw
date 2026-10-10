using System;

// Exceeding Requirements: I added a method called GetLevel. It's for levels for points user's earn for their goals. Each level has a range of points and the user's current level (1-5) is displayed based on their total score. 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }

}