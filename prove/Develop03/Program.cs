using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture();
        Console.WriteLine("Would you like to add your own scripture or use the default? (type 'add' to add your own)");
        string input = Console.ReadLine();
        if (input == "add")
        {
            s.prompt();
        }
        else
        {
            s.set_reference("Genesis 1:1-3");
            s.add_verse("In the beginning God created the heaven and the earth.");
            s.add_verse("And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters.");
            s.add_verse("And God said, Let there be light: and there was light.");
        }
        Console.Clear();
        s.display();

        
    }
}