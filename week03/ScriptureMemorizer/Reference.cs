using System;
using System.Collections.Generic;
public class Reference
{
    private List<string> references = new List<string>
    {
        "Acts 3:19-21","John 3:5","Philippians 4:13"
    };
    public string GetRef(int index)
    {
        return references[index];
    }
}