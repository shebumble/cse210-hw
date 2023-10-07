public class Prompts

{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private int SelectPrompt()
    {
        var _random = new Random();
        int _index = _random.Next(_prompts.Count);
        return _index;
    }

    public string DisplayPrompt()
    {
        string _promptChoice = _prompts[SelectPrompt()];
        Console.WriteLine(_promptChoice);
        return _promptChoice;
    }
 
    public void DisplayAll()
    {
        foreach (string x in _prompts)
        {
            Console.WriteLine(x);
        }
    }
}