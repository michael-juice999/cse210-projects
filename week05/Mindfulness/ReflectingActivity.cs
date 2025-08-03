using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a challenge.",
        "Recall a moment of peace you experienced recently.",
        "Reflect on a time when you helped someone in need."
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on meaningful moments.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        ShowSpinner(3);

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Pause(_duration);

        DisplayEndingMessage();
    }
}
