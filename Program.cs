namespace _algorithm;
class Program
{

    static void Main(string[] args)
    {
        double weight = UnitConverter.KgToLbs(100);
        Console.WriteLine(weight);
        Random randomANumber = new Random();
        RandomNumber randomNumber = new();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Random number: {randomANumber.Next()}");
        }
        // config to pull
        // ok đấy

    }
}
