using System;

class Program
{
    static void Main(string[] args)
    {
        Profile profile = new Profile();
        Console.Clear();
        Console.Write("\n 1. New Profile \n 2. Load Profile\n\nEnter: ");
        string input = Console.ReadLine();
        int option = 0;
        try
        {
            option = int.Parse(input);
        }
        catch (FormatException)
        {
            option = 0;
        }
        if (option == 2)
        {
            profile.LoadProfile();
        }
        else
        {
            Console.Write("What is the name of your profile: ");
            string nameInput = Console.ReadLine();
            profile.SetProfileName(nameInput);
        }
        Console.Clear();
        Console.WriteLine($"Hello {profile.GetProfileName()}! You currently have a total of {profile.GetScore()} points. \n");
        Menu m = new Menu();
        GoalMenu gm = new GoalMenu();
        int choice = 0;
        while (choice != 7)
        {
            Console.WriteLine();
            choice = m.Choice();
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    int gInput = 0;
                    while (gInput != 5)
                    {
                        gInput = gm.GoalChoice();
                        switch (gInput)
                        {
                            case 1:
                                Console.Write("What is the name of your goal? ");
                                string sName = Console.ReadLine();
                                Console.Write("How many points is this goal worth? ");
                                int sPoints = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal", sName, sPoints);
                                profile.AddGoal(sGoal);
                                break;
                            case 2:
                                Console.Write("What is the name of your goal? ");
                                string eName = Console.ReadLine();
                                Console.Write("How many points is this goal worth? ");
                                int ePoints = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal", eName, ePoints);
                                profile.AddGoal(eGoal);
                                break;
                            case 3:
                                Console.Write("What is the name of your goal? ");
                                string cName = Console.ReadLine();
                                Console.Write("How many points is this goal worth? ");
                                int cPoints = int.Parse(Console.ReadLine());
                                Console.Write("How many times do you need to complete this goal? ");
                                int goalNum = int.Parse(Console.ReadLine());
                                Console.Write("How many bonus points are received when the checklist is finished? ");
                                int bonus = int.Parse(Console.ReadLine());
                                ChecklistGoal cGoal = new ChecklistGoal("Eternal Goal", cName, cPoints, goalNum, bonus);
                                profile.AddGoal(cGoal);
                                break;
                            case 4:
                                Console.Write("What is the name of your goal? ");
                                string evName = Console.ReadLine();
                                Console.Write("How many points is this goal worth? ");
                                int evPoints = int.Parse(Console.ReadLine());
                                EternalGoal evGoal = new EternalGoal("Eternal Goal", evName, evPoints);
                                profile.AddGoal(evGoal);
                                break;
                            case 5:
                                break;
                            default:
                                Console.WriteLine("\nInvalid option.");
                                break;
                        }
                    }
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    profile.ListGoals();
                    break;
                case 3:
                    profile.SaveProfile();
                    break;
                case 4:
                    Console.Clear();
                    profile.LoadProfile();
                    break;
                case 5:
                    Console.Clear();
                    profile.RecordEvent();
                    break;
                case 6:
                    Console.Clear();
                    Console.Write($"\nProfile Name: {profile.GetProfileName()}\nCurrent Level: {profile.GetLevels().GetLevel()} ({profile.GetLevels().GetCurrentXP()}/{profile.GetLevels().GetThresh()} XP) \nTotal Points: {profile.GetScore()}\n\n");
                    break;
                case 7:
                    Console.WriteLine("Thanks for using this program!");
                    break;
                default:
                    Console.WriteLine($"\nInvalid  option.");
                    break;
            }
        }

    }
}