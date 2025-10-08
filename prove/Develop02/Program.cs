using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");
        bool run = true;
        while (run == true)
        {
            Prompts p = new Prompts();
            Journal j = new Journal();
            Entry e = new Entry();
            Console.WriteLine("Select one of the following choices: \n1. Write \n2. Display  \n3. Load  \n4. Save  \n5. Quit\nWhat would you like to do?");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                p.Display();
            }
            else if (answer == "2")
            {

            }
            else if (answer == "3")
            {
                j.Load();
            }
            else if (answer == "4")
            {


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