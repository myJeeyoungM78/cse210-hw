using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.IO;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, Welcome to scripture memorizer!");
        // Console.WriteLine("Press enter to continue or type 'quit' to finish");

        List<Scripture> scriptures = new List<Scripture>();
        // string quote = "Proverbs 3:5-6 Trust in the Lord with all thine bheart; and lean not unto thine cown dunderstanding. In all thy ways aacknowledge him, and he shall bdirect thy cpaths.";

        string filename = "C:\\Users\\jeeyo\\Documents\\Scripture.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] slines = line.Split(null);

            string book = slines[0];
            string[] c_v = slines[1].Split(":");
            int chapter = int.Parse(c_v[0]);
            int verse = int.Parse(c_v[1]);

            ScriptureReference sr = new ScriptureReference(book, chapter, verse);
            
            string text = "";
            for (int i = 2; i < slines.Length; i++)
            {
                text += slines[i] + " ";
            }

            Scripture s1 = new Scripture(sr, text);

            scriptures.Add(s1);
        }

        // string text = "Thus saith the Lord.";

        // ScriptureReference sr1 = new ScriptureReference("Proverbs", 3, 5-6);

        // Scripture s1 = new Scripture(sr1, text);

        // string input = "";

        // while(!s1.IsCompletelyHidden() && !input.Equals("quit"))
        // {
            // System.Console.WriteLine(s1.GetDisplayText());
            // input = Console.ReadLine();
            // Console.Clear();
            // s1.HideRandomWords(3);
        // }

        

        Scripture s = scriptures[0];
        s.PlayGame();

    }

class Scripture
{
    private ScriptureReference reference;
    List<Word> _words;
    private Stopwatch watch;

    private bool _show = true;
    
    public Scripture(ScriptureReference sr, string text)
    {
        this.reference = sr;
        _words = new List<Word>();
        watch = new Stopwatch();

        string[] strings = text.Split(null);


        foreach (string s in strings)
        {
            Word w = new Word(s);
            _words.Add(w);
        }
    }

    public string GetDisplayText()
    {
        StringBuilder sb = new StringBuilder();

        foreach (Word w in _words)
        {
            sb.Append(w.GetDisplayText());
            sb.Append(' ');
        }

        return reference.GetDisplayText() + sb.ToString();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int randhide = random.Next(0, _words.Count);

        int numberHidden = 0;

        if (IsCompletelyHidden())
        {
            _show = false;
        }


        while (numberHidden != numberToHide && !IsCompletelyHidden())
        {
            // Console.WriteLine($"Trying random number {randhide}");
            Word w = _words[randhide];

            if(!w._isHidden)
            {
                w.Hide();
                numberHidden++;
            }
            randhide = random.Next(0, _words.Count);
        }
    }

    public void PlayGame()
    {
        StartTiming();

        string input = "";
        while (!input.ToLower().Equals("quit") && _show)
        {
            System.Console.Clear();
            GetDisplayText();
            Console.WriteLine(GetDisplayText());

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            input = Console.ReadLine();

            if (input.ToLower().Equals("quit"))
            {
                
            }
            else
            {
                HideRandomWords(3);
            }   
            
        }

        StopTiming();
    }

    public void StartTiming()
    {
        watch = Stopwatch.StartNew();
    }

    public void StopTiming()
    {
        watch.Stop();

        TimeSpan elapsed = watch.Elapsed;
        Console.WriteLine($"Time taken: {elapsed}");
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word w in _words)
        {
            if (!w._isHidden)
            {
                return false;
            }
        }

        return true;
    }
}

class ScriptureReference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;

    public ScriptureReference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }



    public void displayText(string reference)
    {
        
        _chapter = 3;
        _verse = 5;
        _endVerse = 6;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse} ";
    }
}

class Word
{
    public string _text;
    public bool _isHidden;

    public Word(string text)
    {
        this._text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        this._isHidden = true;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}



}