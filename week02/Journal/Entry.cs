using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        PromptGenerator generator = new PromptGenerator();
        _promptText = generator.GetRandomPrompt();
        _date = DateTime.Now.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
    }
}   