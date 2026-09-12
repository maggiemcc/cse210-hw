using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        // _entries.userEntry(item => Console.WriteLine($">>{item._entryText}"));
    }

    public void DisplayAll()
    {

        if (_entries.Count == 0)
        {
            Console.WriteLine("Whoops! Look like your journal is empty. Time to write something!");
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
                outputFile.WriteLine($"{entry._date} - {entry._promptText} {entry._entryText}|");
            }

            Console.WriteLine("Journal saved!");
        }

    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string entry in lines)
        {
            string[] parts = entry.Split("|");
            _entries.Add(new Entry());
        }
    }
}