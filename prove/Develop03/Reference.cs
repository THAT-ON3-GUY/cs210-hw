public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference()
    {
        _book = "1 Nephi";
        _chapter = 1;
        _startVerse = 1;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetStart()
    {
        return _startVerse;
    }
    public int GetEnd()
    {
        return _endVerse;
    }
    public void SetReference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }
    public void DisplayReference()
    {
        if(_endVerse != 0)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}");
        }
        
    }
}