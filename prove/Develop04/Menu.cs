using System;

class Menu
{
    private int _breatheCount = 0;
    private int _refCount = 0;
    private int _listCount = 0;
    public void run()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options: \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                _breatheCount++;
                Breathing b = new Breathing("Breathing", 0);
                b.run();

            }
            else if (input == "2")
            {
                _refCount++;
                Reflection r = new Reflection("Reflection", 0);
                r.run();

            }
            else if (input == "3")
            {
                _listCount++;
                Listing l = new Listing("Reflection", 0);
                l.run();
            }
            else if (input == "4")
            {
                Console.WriteLine($"You used the breathing activity {_breatheCount} times.");
                Console.WriteLine($"You used the reflection activity {_refCount} times.");
                Console.WriteLine($"You used the listing activity {_listCount} times.");
                running = false;
            }
        }
    }
}