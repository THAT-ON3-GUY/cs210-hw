public class Comment
{
    private string _writer;
    private string _text;

    public Comment(string writer, string text)
    {
        _writer = writer;
        _text = text;
    }

    public string Writer
    {
        get { return _writer; }
    }

    public string Text
    {
        get { return _text; }
    }
}