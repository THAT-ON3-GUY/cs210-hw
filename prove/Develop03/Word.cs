using System.Xml;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }

    public void SetWord(string word)
    {
        _text = word;
    }

    public string GetWord()
    {
        
        if(IsHidden() == true)
        {
            string output = "";
            foreach(char i in _text)
            {
                output += "_";
            }
            return output;
        }
        else
        {
            return _text;
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}