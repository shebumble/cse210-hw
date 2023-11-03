using System.Threading.Tasks.Dataflow;

public class ReflectingActivity : Activity
{

private List<string> _prompts = new List<string>()
{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
};
private List<string> _questions = new List<string>()
{
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
};

public ReflectingActivity(string name, string description) : base(name, description)
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
    Console.WriteLine("Consider the Following prompt: \n");
    string write = GetPrompt();
    Console.WriteLine($"--- {write} --- \n");
}

private string GetQuestion()
{
    var ran = new Random();
    int index = ran.Next(_questions.Count);

    return _questions[index];

}


private void DisplayQuestion()
{
        string write = $"> {GetQuestion()}";
        Console.Write(write);
        ShowSpinner();
        ShowSpinner();


}

public void RunReflecting()
{
    DisplayStart();
    int duration = GetDuration();

    DisplayPrompt();
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();

    Console.WriteLine("Now ponder on each of the follow questions as they related to this experience.");
    Console.Write("You may begin in: ");
    ShowCountdown(5);
    Console.Clear();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    while (DateTime.Now < endTime)
    {
        DisplayQuestion();
    }

    DisplayFinish();

}
}