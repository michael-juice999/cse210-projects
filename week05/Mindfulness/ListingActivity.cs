using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many positive things in your life as you can.",
        "List people who have influenced you positively.",
        "List things you are grateful for today."
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you focus on the good things in your life.")
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
        Console.WriteLine("Start listing:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                responses.Add(input);
            }
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        DisplayEndingMessage();
    }
}
