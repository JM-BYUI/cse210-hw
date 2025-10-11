using System;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _filename; 
    public Journal()
    {

    }
    public void Display()
    {
        int wordcount = 0;
        foreach (Entry entry in _entries)
        {
            string e1 = entry.getEntry();
            string[] words = e1.Split(' ');
            wordcount += words.Count();
            entry.Display();
        }
        Console.WriteLine($"Total word count of journal: {wordcount}");
    }
    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] entries = line.Split("; ");
            Entry entry = new Entry();
            entry._entryNum = int.Parse(entries[0]);
            entry._date = entries[1];
            entry._prompt = entries[2];
            entry._response = entries[3];
            _entries.Add(entry);
        }
    }
    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._entryNum}; {entry._date}; {entry._prompt}; {entry._response}");
            }
        }
    
    }

}
