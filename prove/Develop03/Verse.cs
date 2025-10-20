using System;

class Verse
{
    private List<Word> _verse;
    public Verse()
    {

    }
    public void Display()
    {

    }
    public void setWord(string w)
    {
        Word addedWord = new Word(w);
        _verse.Add(addedWord);


    }
    public bool allHidden()
    {
        int hidden = 0;
        foreach (Word w in _verse)
        {
            if (w.getHidden() == true)
            {
                hidden += 1;
            }
        }
        if (hidden >= _verse.Count)
        {
            return true;
        }
        else
        {
            return false;
        }   
    }
    
}