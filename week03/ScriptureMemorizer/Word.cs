
public class Word
{

    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string underscore = "";
            int countLater = _text.Length;
            for (int i = 0; i < countLater; i++)
            {
                underscore = underscore + "_";
            }
            return underscore;
        }

        else
        {
            return _text;
        }
    }
}