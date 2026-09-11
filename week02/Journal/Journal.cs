public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // You can use the $ and include variables just like with Console.WriteLine
            // string prompt = randomPrompt;
            //     outputFile.WriteLine($"{prompt}");
        }

    }

    public void LoadFromFile(string file)
    {
        // anEntry._date = dateText;
        // anEntry._entryText = "Stressful.";
        // anEntry.Display();

        // string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string entry in lines)
        {
            string[] parts = entry.Split(",");

            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}