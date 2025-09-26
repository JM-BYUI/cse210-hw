using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        bool list = true;
        List<int> numbers;
        numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (list == true)
        {
            Console.WriteLine("Enter number:");
            string input2 = Console.ReadLine();
            int number = int.Parse(input2);
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }
        float sum = 0;
        int listAmount = 0;
        int biggest = 0;
        int smallPos = 10000000;
        foreach (int num in numbers)
        {
            if (num < smallPos && num > 0)
            {
                smallPos = num;
            }
            if (num > biggest)
            {
                biggest = num;
            }
            sum += num;
            listAmount += 1;
        }
        float avg = sum / listAmount;
        List<int> sorted;
        sorted = numbers;
        foreach (int num in sorted)
        {
            
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is : {avg}");
        Console.WriteLine($"The biggest number is: {biggest}");
        Console.WriteLine($"The smallest positive number is: {smallPos}");





    }
}