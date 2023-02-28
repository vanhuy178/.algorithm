class Converter
{
    public const decimal Factor = 2.205m;

    public decimal KgToPound(decimal weight)
    {
        return weight * Factor;
    }

    public decimal PoundToKg(decimal weight)
    {
        return weight / Factor;
    }
}