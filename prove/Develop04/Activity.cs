public class Activity

{

private string _name;
private string _description;
private int _duration;
public Activity(string name, string description)
{
    _name = name;
    _description = description;
}

public void DisplayStart()
{
    Console.Clear();
    string welcome = $"Welcome to the {_name} \n";
    Console.WriteLine(welcome);
    Console.WriteLine(_description);
    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());

    Console.Clear();
    Console.Write("Get ready...\n");
    ShowSpinner();
}

public void DisplayFinish()
{
    string finish = "\n\nWell done!!";
    string finish2 = $"\nYou have completed another {_duration} seconds of the {_name}.";

    Console.WriteLine(finish);
    ShowSpinner();
    Console.WriteLine(finish2);
    ShowSpinner();
    Console.Clear();
}

public void ShowSpinner()
{
    List<string> ani = new List<string>();
    ani.Add("|");
    ani.Add("/");
    ani.Add("-");
    ani.Add("\\");
    ani.Add("|");
    ani.Add("/");
    ani.Add("-");
    ani.Add("\\");

    foreach (string s in ani)
    {
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

}

public void ShowCountdown(int x)
{

    for (int i = x; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

}

public int GetDuration()
{
    return(_duration);
}


}