using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax through guided breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        ShowSpinner(3);

        int cycles = _duration / 10;

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(4);
            Console.WriteLine("Breathe out...");
            Pause(6);
        }

        DisplayEndingMessage();
    }
}
