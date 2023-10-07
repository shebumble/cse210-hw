public class Entry

{
    public string _date;
    public string _time;
    public string _prompt;
    public string _entry;

    public void DisplayEntry()
    {
        Console.WriteLine($"\nDate: {_date} Time: {_time} - Prompt: {_prompt} \n{_entry}");
    }

    public string SaveEntry()
    {
        return $"{_date},{_time},{_prompt},{_entry}";
    }
}