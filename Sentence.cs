// Sentence.cs

class Sentence
{
    private string[] words;
    public Sentence(string s)
    {
        words = s.Split(' ');
    }

    public string this[int index] => words[index];

}