using System;

class Program
{
    static void Main(string[] args)
    {
        Verse v = new Verse();
        v.setWord("Jesus");
        v.setWord("wept.");
        v.hideWord(1);
        v.Display();
        
    }
}