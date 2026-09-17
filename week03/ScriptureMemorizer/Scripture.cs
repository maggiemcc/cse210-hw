using System;

public class Scripture
{
   private Reference _reference;
   private List<Word> _words;

   public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordParts = text.Split(" ");
        
        foreach(string word in wordParts)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()
    {
        string referenceDisplay = _reference.GetDisplayText() + " ";
        foreach(Word word in _words)
        {
            referenceDisplay += word.GetDisplayText() + " ";
        }

        return referenceDisplay;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}