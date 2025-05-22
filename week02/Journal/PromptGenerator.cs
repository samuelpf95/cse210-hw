using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "How did I feel today and why?",
        "What is one thing I could have done better today?",
        "What did I learn today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}