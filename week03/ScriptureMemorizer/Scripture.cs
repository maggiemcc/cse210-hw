using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordParts = text.Split(" ");

        foreach (string word in wordParts)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWordList = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWordList.Add(word);
            }
        }

        Random random = new Random();
        for (int i = 0; i < numberToHide && visibleWordList.Count > 0; i++)
        {
            int index = random.Next(visibleWordList.Count);
            visibleWordList[index].Hide();
            visibleWordList.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string referenceDisplay = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            referenceDisplay += word.GetDisplayText() + " ";
        }

        return referenceDisplay;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; 
            }
        }
        return true;
    }
}