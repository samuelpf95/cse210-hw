using System;
using System.Collections.Generic;
public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private int _quantity;
    private static Random _random = new Random();
    private List<string> _possibleTitles = new List<string>
    {
        "Hello World!", "Second part of my previous video", "89 steps to simplify things","Answering your comments!","3 thing you have done wrong your whole life!","I bet you didn't know this!"
    };
    private List<string> _possibleAuthors = new List<string>
    {
        "ProjectYoutube", "TotallyAnAuthor", "Brad04","AnonymousAuthor007","ZagLeppeling31","zzNoobGamer777zz"
    };
    private List<string> _possibleLengths = new List<string>
    {
        "3:21", "58:26", "44:02","12:44","55:12","10:03"
    };
    public Video()
    {
        _title = _possibleTitles[_random.Next(_possibleTitles.Count)];
        _author = _possibleAuthors[_random.Next(_possibleAuthors.Count)];
        _length = _possibleLengths[_random.Next(_possibleLengths.Count)];
        _quantity = _random.Next(3,5);
        for (int i = 0; i < _quantity; i++)
        {
            _comments.Add(new Comment());
        }
    }
    public string GetStats()
    {
        return $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nTitle: {_title}.\nAuthor: {_author}.\nLength: {_length} min.\nAmount of Comments: {_quantity}.\n";
    }
    private List<Comment> _comments = new List<Comment>();
    public void AddComment()
    {
        _comments.Add(new Comment());
        _quantity++;
    }
    public void PrintComments()
    {
        foreach (Comment c in _comments)
        {
            Console.WriteLine(c.GetComment());
        }
    }
}