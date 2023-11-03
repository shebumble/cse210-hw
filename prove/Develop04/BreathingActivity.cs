using System.Reflection.Metadata;

public class BreathingActivity : Activity
{

public BreathingActivity(string name, string description) : base(name, description)
{

}

private void BreathingIn()
{

    List<string> breathIn = new List<string>()
    {
        ".",
        "o",
        "O",
        "0"
    };

    Console.Write("Breathe In...");
    foreach (string o in breathIn)
    {
        Console.Write(o);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }


}

private void BreathingOut()
{

    List<string> breathOut = new List<string>()
    {
        "0",
        "O",
        "o",
        "."
    };

    Console.Write("Breathe Out...");
    foreach (string o in breathOut)
    {
        Console.Write(o);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

}

public void RunBreathing()
{
    DisplayStart();
    int duration = GetDuration();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    while (DateTime.Now < endTime)
    {
        Console.WriteLine("");
        BreathingIn();
        Console.WriteLine("");
        BreathingOut();
        Console.WriteLine("");
    }
    
    DisplayFinish();
}

}