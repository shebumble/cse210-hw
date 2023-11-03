using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string menu = @"Menu Options: 
        1. Start breathing activity
        2. Start reflecting activity
        3. Start listing activity
        4. Quit
        Select a choice from the menu: ";
        int answer = 0;

        while (answer != 4)
        {
            Console.Write(menu);
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                string n = "Breathing Activity";
                string d = @"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.
                ";
                BreathingActivity breathe = new BreathingActivity(n, d);
                breathe.RunBreathing();
            }
            else if (answer == 2)
            {
                string n = "Reflecting Activity";
                string d = @"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.
                ";
                ReflectingActivity reflect = new ReflectingActivity(n, d);
                reflect.RunReflecting();
            }
            else if (answer == 3)
            {
                string n = "Listing Activity";
                string d = @"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.
                ";
                ListingActivity listing = new ListingActivity(n, d);
                listing.RunListing();
            }
            else if (answer == 4)
            {
                break;
            }
        }
    }
}