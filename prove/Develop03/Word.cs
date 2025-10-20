using System;
class Word
{
    private string _word;
    private bool _hidden;
    public Word (string w)
    {
        _word = w;
        _hidden = false;
    }
    public void setHidden()
    {
        _hidden = true;
    }
    public bool getHidden()
    {
        return _hidden;
    }
    public string getWord()
    {
        return _word;
    }
    public void display()
    {
        if (_hidden == false)
        {
            Console.Write(_word + " ");
        }
        else
        {
            Console.Write(" ");
        }
    }
}