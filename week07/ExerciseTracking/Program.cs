using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.\n");

        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToString("dd MMMM yyyy");

        List<Activity> activities = new List<Activity>()
        {
            new Running(date, "Running", 30.0, 3.0),
            new Cycling(date, "Cycling", 30.0, 20.0),
            new Swimming(date, "Swimming", 30.0, 60.0)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}