using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the highlight of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced today.",
        "What did you learn today?",
        "How did you show kindness today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
