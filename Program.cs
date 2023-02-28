namespace _algorithm;
class Program
{

    static void Main(string[] args)
    {
        // Program.cs
        Person ps1 = new("Huy");

        Console.WriteLine(ps1.Name);
        Console.WriteLine(Person.Count);

        double weight = UnitConverter.KgToLbs(100);
        Console.WriteLine(weight);
        Random randomANumber = new Random();
        RandomNumber randomNumber = new();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Random number: {randomANumber.Next()}");
        }
    }
}
