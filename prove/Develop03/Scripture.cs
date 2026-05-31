using System.Runtime.InteropServices;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference = new Reference();

    public Scripture(string book, int chapter, int verse, string text)
    {
        _words = ConvertToWords(text);
        _reference.SetReference(book, chapter, verse, 0);
    }
    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWords(text);
        _reference.SetReference(book, chapter, startVerse, endVerse);
    }
    public Scripture(Reference reference, string text)
    {
        _words = ConvertToWords(text);
        _reference = reference;
    }

    public void ShowScripture()
    {
        string text = string.Join(" ", _words.Select(word => word.GetWord()));
        Console.WriteLine(getReference() + " " + text);
    }

    public bool needHidden()
    {
        //This Code ensures that the same words aren't chosen twice to hide.
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count == 0)
        {
            return false;
        }

        Random random = new Random();
        int hideCount = Math.Min(3, visibleWords.Count);

        for (int i = 0; i < hideCount; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }

        return true;
    }

    private string getReference()
    {
        string fullReference;
        if(_reference.GetEnd() == 0)
        {
            fullReference = _reference.GetBook() + " " + _reference.GetChapter() + ":" + _reference.GetStart();
        }
        else
        {
            fullReference = _reference.GetBook() + " " + _reference.GetChapter() + ":" + _reference.GetStart() + "-" + _reference.GetEnd();
        }
        return fullReference;
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWordList = new List<Word>();
        List<string> tempList = text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
        foreach(string word in tempList)
        {
            Word newWord = new Word(word);
            tempWordList.Add(newWord);
        }
        return tempWordList;
    }
}