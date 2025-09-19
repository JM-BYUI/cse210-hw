using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string letter = "F";
        string sign = "";
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        if (letter != "F")
        {
            if (number % 10 >= 7 && letter !="A")
            {
                sign = "+";

            }
            else if (number % 10 < 3)
            {
                sign = "-";

            }
        }
        Console.WriteLine($"Your grade is {letter}{sign}.");


    }
}