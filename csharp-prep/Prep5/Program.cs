using System;
using System.Globalization;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");

        
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        string numInput = Console.ReadLine();
        int favNum = int.Parse(numInput);
        return favNum;
        
    }
    static int PromptUserBirthYear()
    {
        Console.WriteLine("Please enter the year you were born:");
        string numInput = Console.ReadLine();
        int birthNum = int.Parse(numInput);
        return birthNum;
        
    }
    static int SquareNumber(int num)
    {
        return num *= num;   
    }
    static void DisplayResult(string n, int b, int s)
    {
        int age = 2025 - b;
        Console.WriteLine($"{n}, the square of your number is {s}.");
        Console.WriteLine($"{n}, you will turn {age} this year.");

        
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int userNum = PromptUserNumber();
        int birthNum = PromptUserBirthYear();
        int square = SquareNumber(userNum);
        DisplayResult(name, birthNum, square);

    }
}