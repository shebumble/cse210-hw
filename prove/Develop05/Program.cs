using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string menu = @"Menu Options:
        1. Create New Goal
        2. List Goals
        3. Save Goals
        4. Load Goals
        5. Record Event
        6. Quit
        ";

        string goalMenu = @"The Types of Goals are:
        1. Simple Goal
        2. Eternal Goal
        3. Checklist Goal
        ";

        List<Goal> goals = new List<Goal>();

        int answer = 0;
        int goalAnswer = 0;

        int score = 0;


        while (answer != 6)
        {
            Console.WriteLine($"\nYou have {score} points.\n");
            Console.WriteLine(menu);
            Console.Write("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine(goalMenu);
                Console.Write("Which type of goal would you like to create? ");
                goalAnswer = int.Parse(Console.ReadLine());
                Console.Write("What is the name of your goal? " );
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (goalAnswer == 1)
                {
                    SimpleGoal simple = new SimpleGoal(name, description, points);
                    goals.Add(simple);
                }

                else if(goalAnswer == 2)
                {
                    EternalGoal eternal = new EternalGoal(name, description, points);
                    goals.Add(eternal);
                } 

                else if(goalAnswer == 3)
                {
                    Console.WriteLine("");
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int goalAmount = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal checklist = new ChecklistGoal(name, description, points, goalAmount, bonus);
                    goals.Add(checklist);
                }
            }

            else if (answer == 2)
            {
                Console.WriteLine("The goals are: ");
                foreach (Goal g in goals)
                {
                    g.DisplayGoal();
                }
            }

            else if (answer == 3)
            {
                Console.WriteLine("What is the filename for the goal file?");
                string _fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(_fileName))
                    {
                        outputFile.WriteLine(score);
                        foreach (Goal g in goals)
                        {
                            outputFile.WriteLine(g.SaveGoal());
                        }
                    }
            }

            else if (answer == 4)
            {
                Console.WriteLine("What is the filename for the goal file?");
                string _fileName = Console.ReadLine();
                string[] _lines = System.IO.File.ReadAllLines(_fileName);

                if (File.Exists(_fileName))
                {
                    foreach (string line in _lines)
                    {
                        if (line.StartsWith("s"))
                        {
                            string[] parts = line.Split(",");
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            int done = int.Parse(parts[4]);

                            SimpleGoal simple = new SimpleGoal(name, description, points, done);
                            goals.Add(simple);
                        }

                        else if (line.StartsWith("e"))
                        {   
                            string[] parts = line.Split(",");
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);

                            EternalGoal eternal = new EternalGoal(name, description, points);
                            goals.Add(eternal);
                        }

                        else if (line.StartsWith("c"))
                        {
                            string[] parts = line.Split(",");
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            int done = int.Parse(parts[4]);
                            int toComplete = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);

                            ChecklistGoal checklist = new ChecklistGoal(name, description, points, toComplete, bonus, done);
                            goals.Add(checklist);
                        }
                        else
                        {
                            score = int.Parse(line);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("This file does not exist.");
                }
            }
                
            else if (answer == 5)
            {
                Console.WriteLine("The goals are: ");
                foreach (Goal g in goals)
                {
                    int num = goals.IndexOf(g) + 1;
                    string name = g.GetName();
                    Console.WriteLine($"{num}. {name}");
                }
                Console.Write("Which goal did you accomplish? ");
                int i = int.Parse(Console.ReadLine());

                i = i - 1;
                int points = goals[i].RecordEvent();
                score += points;
                Console.WriteLine($"Congratulations! You have earned {points} points!");
                Console.WriteLine($"You now have {score} points.");
            }

            else if (answer == 6)
            {
                break;
            }

        }

        
    }


}
