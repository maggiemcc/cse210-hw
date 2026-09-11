using System;
public class Entry
{

    public string _date;
    public string _promptText;
    public string _entryText;
    // public string _newEntry;
    
    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();

        Console.WriteLine($"{_date} - {_promptText}: {_entryText}");

        // _newEntry = $"{_date} - {_promptText}: {_entryText}";
    }
}