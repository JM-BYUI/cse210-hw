using System;

class Scripture
{
    private string _reference;
    private List<Verse> _scripture;
    public Scripture()
    {
        _scripture = new List<Verse>();
    }
    public void prompt()
    {
        Console.WriteLine("Please enter the book and chapter number for your scripture:");
        _reference = Console.ReadLine();
        Console.WriteLine("Please enter the first verse:");
        bool scripture_done = false;
        while (scripture_done == false)
        {
            string input = Console.ReadLine();
            if (input == "x")
            {
                scripture_done = true;
            }
            else
            {
                add_verse(input);
                Console.WriteLine("Please enter the next verse or type 'x' to finsish:");
            }
        }


    }
    public void display()
    {
        bool running = true;
        while (running == true)
        {
            int hidden_verse = 0;
            foreach (Verse v in _scripture)
            {
                if (v.allHidden() == true)
                {
                    hidden_verse += 1;
                }
            }
            if (hidden_verse >= _scripture.Count)
            {
                Console.Clear();
                running = false;
            }
            Console.WriteLine(_reference);
            foreach (Verse v in _scripture)
            {
                v.Display();
                Console.WriteLine();
            }
            Console.WriteLine("Press the enter key to continue to type 'quit'.");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                running = false;
            }
            else
            {
                bool hidden = true;
                Verse v2 = new Verse();
                while (hidden == true)
                {
                    Random v_ran = new Random();
                    int v_num = v_ran.Next(0, _scripture.Count);
                    v2 = _scripture[v_num];
                    if (v2.allHidden() == false)
                    {
                        hidden = false;
                    }
                }
                bool word_hidden = false;
                Word w = new Word("");
                while (word_hidden == false)
                {
                    Random w_ran = new Random();
                    int w_num = w_ran.Next(0, v2.count());
                    w = v2.getWord(w_num);
                    if (w.getHidden() == false)
                    {
                        word_hidden = true;
                        v2.hideWord(w_num);
                    }
                }
                Console.Clear();
            }
        }
    }
    public void add_verse(string s)
    {
        string[] words = s.Split(' ');
        Verse v = new Verse();
        foreach (string w in words)
        {
            v.setWord(w);
        }
        _scripture.Add(v);
    }
}
