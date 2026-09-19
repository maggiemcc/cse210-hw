using System;

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

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string wordUnderscores = "";

            foreach (var letter in _text)
            {
                wordUnderscores += "_";
            }
            return wordUnderscores;
        }
        else
        {
            return _text;
        }
    }
}