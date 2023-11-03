public class ListingActivity : Activity
{

private List<string> _prompts = new List<string>()
{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
};
private List<string> _answers = new List<string>();

public ListingActivity(string name, string description) : base(name, description)
{

}

private string GetPrompt()
{
    var random = new Random();
    int index = random.Next(_prompts.Count);
    return (_prompts[index]);
}

private void DisplayPrompt()
{
    Console.WriteLine("List as many responses as you can to the following prompt: \n");
    string write = GetPrompt();
    Console.WriteLine($"--- {write} --- \n");
}

private void AddToAnswerList()
{
    Console.Write("> ");
    _answers.Add(Console.ReadLine());
}

private void DisplayAnswerNumber()
{
    int amount = _answers.Count();
    string a = amount.ToString();
    string message = $"You listed {a} items!";
    Console.Write(message);
}

public void RunListing()
{
    DisplayStart();
    int duration = GetDuration();

    DisplayPrompt();
    Console.Write("You may begin in: ");
    ShowCountdown(5);
    Console.WriteLine("");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    while (DateTime.Now < endTime)
    {
        AddToAnswerList();
    }

    DisplayAnswerNumber();

    DisplayFinish();

}

}