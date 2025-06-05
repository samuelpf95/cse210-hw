public class Words
{
    private List<string> words = new List<string>();

    public Words (string scripture)
    {
        words = new List<string>(scripture.Split(' '));
    }
    public List<string> GetWords()
    {
        return words;
    }
    public void Hide(int count = 3)
    {
        int wordsHidden = 0;
        int attempts = 0;
        Random rnd = new Random();
        while (wordsHidden < count && attempts < 100)
        {
            int index = rnd.Next(words.Count);
            if (!string.IsNullOrWhiteSpace(words[index]) && words[index][0] != '_')
            {
                words[index] = new string('_', words[index].Length);
                wordsHidden++;
            }
            attempts++;
        }
    }
    public bool Hidden()
    {
        foreach (var w in words)
        {
            if (!string.IsNullOrWhiteSpace(w) && w[0] != '_')
            {
                return false;
            }
        }
        return true;
    }
}
