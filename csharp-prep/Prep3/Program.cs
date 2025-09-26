using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        while (play == true)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);
            bool gotIt = false;
            int guessCounter = 0;
            while (gotIt == false)
            {
                Console.WriteLine("What is your guess?");
                string input2 = Console.ReadLine();
                int guessNumber = int.Parse(input2);
                guessCounter += 1;
                if (guessNumber == magicNumber)
                {
                    Console.WriteLine("Just right!");
                    Console.WriteLine($"Took you {guessCounter} guesses.");
                    gotIt = true;
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower!");

                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }

            }
            Console.WriteLine("Do you want to play again?");
            string input3 = Console.ReadLine();
            if (input3.ToLower() != "yes")
            {
                play = false;
            }

        }
    }
}