using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");
        bool run = true;
        Journal j = new Journal();
        Prompts p = new Prompts();
        int eNum = 0;
        while (run == true)
        {
            Console.WriteLine("Select one of the following choices: \n1. Write \n2. Display  \n3. Load  \n4. Save  \n5. Quit\nWhat would you like to do?");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Entry e = new Entry();
                e._prompt = p.GetPrompt();
                Console.WriteLine(e._prompt);
                Console.Write(">");
                e._response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                e._date = dateText;
                eNum++;
                e._entryNum = eNum;
                j._entries.Add(e);
            }
            else if (answer == "2")
            {
                j.Display();

            }
            else if (answer == "3")
            {
                Console.WriteLine("What is the filename?");
                Console.Write(">");
                j._filename = Console.ReadLine();
                j.Load();
            }
            else if (answer == "4")
            {
                Console.WriteLine("What is the filename?");
                Console.Write(">");
                j._filename = Console.ReadLine();
                j.Save();
            }
            else if (answer == "5")
            {
                Console.WriteLine("See you later!");
                run = false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

    }
}