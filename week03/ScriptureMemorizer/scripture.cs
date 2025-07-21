using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hidden = 0;

        while (hidden < count && !IsCompletelyHidden())
        {
            int i = rand.Next(words.Count);
            if (!words[i].IsHidden())
            {
                words[i].Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string result = reference.GetDisplayText() + "\n";
        foreach (var word in words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
