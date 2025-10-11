using System;
using System.IO; 

class Entry
{
    public string _response;
    public string _prompt;
    public string _date;
    public int _entryNum;
    public Entry()
    {

    }
    public string getEntry()
    {
        return $"Entry Number {_entryNum}\nDate: {_date} - Prompt: {_prompt} \n{_response}";
    }
    public void Display()
    {
        string e = $"Entry Number {_entryNum}\nDate: {_date} - Prompt: {_prompt} \n{_response}\n";
        Console.WriteLine(e);
    }   
        
}