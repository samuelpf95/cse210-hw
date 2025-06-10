using System;
using System.Collections.Generic;
public class Comment
{
    private string _user;
    private string _comment;
    private static Random _random = new Random();
    private List<string> _possibleComments = new List<string>
    {
        "First comment! :D", "Is always nice to see your videos!", "Idk, your videos are becoming very repetitive", "Hello! :)", "Like if you are watching this in 2025 :P", "Yyour old videos were way cooler than this :(", "My kids and their kids will watch this video every morning!"
    };
    private List<string> _possibleNames = new List<string>
    {
        "GeoDude92", "TotallyANickname", "NotBrad04","AnonymousUser007","LagZeppeling31","xXProGamer777Xx"
    };
    public Comment()
    {
        int _index = _random.Next(_possibleNames.Count);
        _user = _possibleNames[_index];
        int _newIndex = _random.Next(_possibleComments.Count);
        _comment = _possibleComments[_newIndex];    
    }
    public string GetComment()
    {
        string _text = $"\n- {_user}: {_comment}.";
        return _text;
    }
}