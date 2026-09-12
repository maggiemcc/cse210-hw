using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
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
        // If entries list is empty, file won't be created.
        if (_entries.Count == 0)
        {
            Console.WriteLine("Sorry, file not created. Your journal is empty, so there was nothing to save.");
        }

        else
        {
            // Check if file doesn't have an extension and add one
            if (!Path.HasExtension(file))
            {
                file = $"{file}.txt";
            }

            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}||{entry._promptText}||{entry._entryText}");
                }

                Console.WriteLine("Your journal has been saved!");
            }

        }
    }

    public void LoadFromFile(string file)
    {
        // Notify user if file doesn't exist
        if (!File.Exists(file))
        {
            Console.WriteLine($"Sorry, we could not find {file}. Please try another name.");
        }
        else
        {
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string entry in lines)
            {
                string[] parts = entry.Split("||");

                if (parts.Length == 3)
                {
                    Entry anEntry = new Entry();
                    anEntry._date = parts[0];
                    anEntry._promptText = parts[1];
                    anEntry._entryText = parts[2];

                    _entries.Add(anEntry);
                }
                else
                {
                    // Notify user of entries that couldn't be added due to incorrect parts
                    Console.WriteLine($"Could not add entry: {entry}");
                }
            }

            Console.WriteLine("\nJournal has successfully loaded!");
        }
    }
}