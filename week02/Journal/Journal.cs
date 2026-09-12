using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

        // foreach (Entry item in _entries)
        // {
        //     Console.WriteLine($">> {item._entryText}");
        // }
    }

    public void DisplayAll()
    {

        if (_entries.Count == 0)
        {
            Console.WriteLine("Whoops! Looks like your journal is empty. Time to write something!");
            return;
        }
        else if (_entries.Count > 0)
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }

            Console.WriteLine("Your journal has been saved!");
        }

    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("Sorry, we could not find that file. Please try another name.");
        }
        else
        {
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string entry in lines)
            {
                string[] parts = entry.Split("|");

                if (parts.Length == 3)
                {
                    Entry anEntry = new Entry();
                    anEntry._date = parts[0];
                    anEntry._promptText = parts[1];
                    anEntry._entryText = parts[2];

                    _entries.Add(anEntry);
                }
            }
        }
    }
}