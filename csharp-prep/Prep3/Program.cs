using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != magicNumber) 
        {
            Console.WriteLine("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("Your guessed it!");
            }
        }
    }
}