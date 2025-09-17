using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string surname = Console.ReadLine();
        Console.Write($"\nYour name is {surname}, {firstname} {surname}.");
    }
}