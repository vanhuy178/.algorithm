class RandomNumber
{
    private static Random random;

    static RandomNumber()
    {
        random = new Random();
    }
    public int Get() => random.Next();
}