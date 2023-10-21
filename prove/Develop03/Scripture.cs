using System.Runtime.CompilerServices;

class Scripture
{

private Reference _reference;
private List<Word> _scripture = new List<Word> {};

public Scripture(Reference reference, string scriptureText)
{
    _reference = reference;
    IntoList(scriptureText);
}

private void IntoList(string scriptureText)
{
    List<string> temp = scriptureText.Split(' ').ToList();
    foreach (string str in temp)
    {
        Word x = new Word(str);
        _scripture.Add(x);
    }


}

public void HideWords()
{
    var ran = new Random();
    int hide = ran.Next(5,20);
    while(hide != 0)
    {
        var random = new Random();
        int index = random.Next(_scripture.Count);
        _scripture[index].Hide();
        hide -= 1;
    }
}

public void GetRenderedText()
{
    string str = "";
    foreach(Word w in _scripture)
    {
        string x = w.GetRenderedText();
        str = str + x + " ";
    }

    Console.WriteLine(_reference.GetReference());
    Console.WriteLine(str);
}

public bool IsCompletelyHidden()
{
    bool r = true;

    foreach (Word w in _scripture)
    {
        bool hid = w.IsHidden();
        if (hid == true)
        {
            r = false;
        }
    }
    return r;
    }


}