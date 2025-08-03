using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed the {_name} for {_duration} seconds.\n");
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("Loading ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    public void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    public void SetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }
}
