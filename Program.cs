namespace _algorithm;
class Program
{
    static void Main(string[] args)
    {
        decimal weightInKg, weightInLbs;
        var converter = new Converter();
        Console.WriteLine($"Convert weight from kg to lbs (factor = {Converter.Factor})");
        while (true)
        {
            // Prompt to enter a weight in Kg:
            Console.Write("Enter a weight in Kg (0 to exit):");
            weightInKg = Convert.ToDecimal(Console.ReadLine());

            if (weightInKg == 0)
            {
                break;
            }
        }
        weightInLbs = converter.KgToPound(weightInKg);
        Console.WriteLine($"{weightInKg}kg = {weightInLbs}lbs");
    }
}
