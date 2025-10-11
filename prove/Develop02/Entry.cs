using System;
using System.IO; 

class Entry
{
    public string _response;
    public string _prompt;
    public string _date;
    public Entry()
    {

    }
    public string getEntry()
    {
        return $"Date: {_date} - Prompt: {_prompt} \n{_response}";
    }
    public void Display()
    {
        string e = $"Date: {_date} - Prompt: {_prompt} \n{_response}";
        Console.WriteLine(e);
    }   
        
}