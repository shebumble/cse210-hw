using System.IO;

public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    public void Display()                                                                                                   
    {
        foreach (Entry x in _entries)
        {
            x.DisplayEntry();
        }
    }

    public void SaveJournal()
    {
        Console.WriteLine("What is the filename?");
        string _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry x in _entries)
            {
                outputFile.WriteLine(x.SaveEntry());
            }
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("What is the filename?");
        string _fileName = Console.ReadLine();
        string[] _lines = System.IO.File.ReadAllLines(_fileName);

        if (File.Exists(_fileName))
        {
            _entries.Clear();
            foreach (string line in _lines)
            {
                Entry _entry = new Entry();
                string[] _parts = line.Split(",");
                _entry._date = _parts[0];
                _entry._time = _parts[1];
                _entry._prompt = _parts[2];
                _entry._entry = _parts[3];
                _entries.Add(_entry);
            }
        }
        else
        {
            Console.WriteLine("This file does not exist.");
        }
    }
} 