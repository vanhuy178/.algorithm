class Square : Shape
{
    public double Length { get; set; }

    public override int Side => 4;

    public Square(double length)
    {
        Length = length;
    }
    public override double Area()
    {
        return Length * Length;
    }
}