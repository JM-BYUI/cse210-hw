using System;

class Program
{
    static void Main(string[] args)
    {
        Word word1 = new Word("Jesus");
        Word word2 = new Word("wept.");
        word1.display();
        word2.display();
        word2.setHidden();
        word1.display();
        word2.display();
    }
}