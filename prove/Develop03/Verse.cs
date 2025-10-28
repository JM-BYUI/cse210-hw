using System;

class Verse
{
    private List<Word> _verse;
    public Verse()
    {
        _verse = new List<Word>();

    }
    public void Display()
    {
        foreach (Word w in _verse)
        {
            w.display();
        }

    }
    public Word getWord(int i)
    {
        return _verse[i];
    }
    public int count()
    {
        return _verse.Count;
    }
    public void setWord(string w)
    {
        Word addedWord = new Word(w);
        _verse.Add(addedWord);
    }
   public void hideWord (int w)
    {
        _verse[w].setHidden();
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