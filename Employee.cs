class Employee : Person
{
    public string JobTitle { get; set; }
    public decimal Salary { get; set; }
    public Employee()
    {
        Console.WriteLine("Called the Employee's constructor");
    }
}