class Circle : Shape
{
    private double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override int Side => 0;

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}