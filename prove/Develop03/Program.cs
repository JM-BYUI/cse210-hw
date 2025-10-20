using System;

class Program
{
    static void Main(string[] args)
    {
        Word word1 = new Word("Yay");
        Word word2 = new Word("No");
        word1.display();
        word2.display();
        word1.setHidden();
        word1.display();
        word2.display();
    }
}