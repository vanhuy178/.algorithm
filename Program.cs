namespace _algorithm;
class Program
{

    static void Main(string[] args)
    {
        // Program.cs
        var sentence = new Sentence("C# is awesome");
        ;
        Console.WriteLine(sentence);
        Console.WriteLine(sentence[0]);
        Console.WriteLine(sentence[1]);
        Console.WriteLine(sentence[2]);

        double[,] data = new double[3, 3];
        Console.WriteLine(data);
        Console.ReadLine();
    }
}
