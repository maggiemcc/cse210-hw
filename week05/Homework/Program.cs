using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment Assign1 = new Assignment("Samuel Bennett", "Muyltiplication");
        Console.WriteLine(Assign1.GetSummary());


        MathAssignments Assign2 = new MathAssignments("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(Assign2.GetSummary());
        Console.WriteLine(Assign2.GetHomeworkList());


        WritingAssignments Assign3 = new WritingAssignments("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(Assign3.GetSummary());
        Console.WriteLine(Assign3.GetWritingInformation());
    }
}