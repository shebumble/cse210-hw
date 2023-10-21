using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Word
{

private string _word;
private bool _visible;

public Word(string word)
{
    _word = word;
    Show();
}

public void Hide()
{
    _visible = false;
}

public void Show()
{
    _visible = true;
}

public bool IsHidden()
{
    return _visible;
}

public string GetRenderedText()
{
    if (_visible == false)
    {
        string blank = "";
        foreach (char x in _word)
        {
            blank += "_";
        }
        _word = blank;
    }

    return _word;
}

}