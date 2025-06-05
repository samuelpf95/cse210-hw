using System;
using System.Collections.Generic;
public class Scripture
{
    private List<string> scriptures = new List<string>
    {
        "Repent ye therefore, and be converted, that your sins may be blotted out, when the times of refreshing shall come from the presence of the Lord; And he shall send Jesus Christ, which before was preached unto you: Whom the heaven must receive until the times of restitution of all things, which God hath spoken by the mouth of all his holy prophets since the world began.","Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.","I can do all things through Christ which strengtheneth me."
    };
    public string GetScript(int index)
    {
        return scriptures[index];
    }
}