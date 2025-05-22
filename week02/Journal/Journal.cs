using System;
using System.Collections.Generic;
using System.IO; 
public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry.Display();
        entries.Add(newEntry);
    }
    public void DisplayEntry()
    {
        foreach (Entry i in entries)
        {
            Console.WriteLine(i._date);
            Console.WriteLine(i._promptText);
            Console.WriteLine(i._entryText);
        }
    }
    public void WriteDoc()
    {
        Console.Write("\nWrite the name of the document without extension (like .txt): ");
        string input = Console.ReadLine();
        string filename = input+".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry i in entries)
            {
                outputFile.WriteLine(i._date);
                outputFile.WriteLine(i._promptText);
                outputFile.WriteLine(i._entryText);
            }
        }
        string filecsv= input +".csv";
        using (StreamWriter outputFileCsv = new StreamWriter(filecsv))
        {
            foreach (Entry o in entries)
            {
                outputFileCsv.WriteLine($"{o._date},{o._promptText},{o._entryText}");
            }
        }
    }
    public void LoadDoc()
    {
        Console.Write("\nWrite the name of the document without extension (like .txt): ");
        string input = Console.ReadLine();
        string filename = input+".txt";
        if (!File.Exists(filename))
        {
        Console.WriteLine("File not found.");
        return;
        }
       string[] lines = System.IO.File.ReadAllLines(filename); 
        for (int i = 0; i < lines.Length; i += 3)
        {
            Entry entry = new Entry();
            entry._date = lines[i];
            entry._promptText = lines[i + 1];
            entry._entryText = lines[i + 2];
            entries.Add(entry);
        }
    }
}