using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
           Console.WriteLine("Enter Number:");
           string input = Console.ReadLine(); 
           userNumber = int.Parse(input);

           if (userNumber != 0)
           {
            numbers.Add(userNumber);
           }

        }

        int listSum = 0;

        foreach (int number in numbers)
        {
            listSum += number;
        }

        Console.WriteLine($"The sum is: {listSum}");

        float average = ((float)listSum) / numbers.Count;
        Console.WriteLine($"The average is: {average}"); 

        int large = 0;
        int small = numbers.First();

        foreach (int number in numbers)
        {
            if (number > large)
            {
                large = number;
            }
            if (number < small && number > 0)
            {
                small = number;
            }
        }
        Console.WriteLine($"The largest number is: {large}");
        Console.WriteLine($"The smallest positive number is: {small}");


    }
}