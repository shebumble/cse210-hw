using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Kyron Barrows", "Addition");
        Console.WriteLine(a.GetSummary());

        MathAssignment m = new MathAssignment("Max Niver", "Multiplication", "7.3", "8-15");
        Console.WriteLine(m.GetSummary());
        Console.WriteLine(m.GetHomeworkList());

        WritingAssignment w = new WritingAssignment("Shelby Niver", "Creative Writing", "The Time I Died");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetWritingInformation());
    }
}