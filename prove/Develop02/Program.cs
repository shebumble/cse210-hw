using System;

/*To improve, I added an option to add a new prompt to the prompts list, 
as well as made sure the program checked to see if a file even existed before it deleted the whole journal
and tried to load a new one. As well added a time to the saved entry.
*/

int choice = -1;
Journal journal = new Journal();
Prompts prompts = new Prompts();
string menu = @"Please choose a menu option: 
            0. Quit
            1. Write
            2. Display
            3. Save
            4. Load
            5. Add prompt";

while (choice != 0)
{
    // added an option to add a prompt choice to the prompts list.
    Console.WriteLine(menu);

    string userChoice = Console.ReadLine();
    choice = int.Parse(userChoice);


    if (choice == 1)
    {
        Entry entry = new Entry();

        entry._date = DateTime.Now.ToString("MM/dd/yyyy");

        entry._time = DateTime.Now.ToString("h:mm:ss tt");

        entry._prompt = prompts.DisplayPrompt();

        entry._entry = Console.ReadLine();

        journal._entries.Add(entry);

    }
    else if (choice == 2)
    {
        journal.Display();
    }
    else if (choice == 3)
    {
        journal.SaveJournal();
    }
    else if (choice == 4)
    {
        journal.LoadJournal();
    }
    else if (choice == 5)
    {
        Console.WriteLine("What is the new prompt?");
        prompts._prompts.Add(Console.ReadLine());
    }
    else if (choice == 0)
    {
        Console.WriteLine("Thank you, have a good one!");
    }
}
