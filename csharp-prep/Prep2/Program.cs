using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80) 
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations on passing!");
        }
        else
        {
            Console.WriteLine("You did not pass, but you can do better next time!");
        }
    }
}