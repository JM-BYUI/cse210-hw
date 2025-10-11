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
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] entries = line.Split(", ");
            Entry entry = new Entry();
            entry._date = entries[0];
            entry._prompt = entries[1];
            entry._response = entries[2];
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
                outputFile.WriteLine($"{entry._date}, {entry._prompt}, {entry._response}");
            }
        }
    
    }

}
